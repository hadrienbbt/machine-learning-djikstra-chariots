using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChariot1
{
    public partial class InitialiseForm : Form
    {
        int nombreChariot;
        TextBox[] CoordonneesDepart;
        TextBox[] CoordonneesDestination;
        int[] CoordonneesFinales;
        public InitialiseForm()
        {
            InitializeComponent();
        }

        private void valid_BT_Click(object sender, EventArgs e)
        {
            nombreChariot = (int)nbChariot_UD.Value;
            CoordonneesDepart = new TextBox[nombreChariot * 2];
            CoordonneesDestination = new TextBox[nombreChariot * 2];
            CoordonneesFinales = new int[CoordonneesDepart.Length + CoordonneesDestination.Length];
            initialiseCoordonnees();

            MarchandiseLbl.Visible = true;
            ChariotLbl.Visible = true;
            PositionxCLbl.Visible = true;
            PositionyCLbl.Visible = true;
            PositionxMLbl.Visible = true;
            PositionyMLbl.Visible = true;

        }

        private void initialiseCoordonnees()
        {
            for (int i = 0; i < CoordonneesDepart.Length; i += 2)
            {
                CoordonneesDepart[i] = new TextBox();
                CoordonneesDepart[i + 1] = new TextBox();
                CoordonneesDestination[i] = new TextBox();
                CoordonneesDestination[i + 1] = new TextBox();
                CoordonneesDepart[i].Location = new Point(25, 20 * i + 190);
                CoordonneesDepart[i + 1].Location = new Point(175, 20 * i + 190);
                CoordonneesDestination[i].Location = new Point(360, 20 * i + 190);
                CoordonneesDestination[i + 1].Location = new Point(510, 20 * i + 190);
                Controls.Add(CoordonneesDepart[i]);
                Controls.Add(CoordonneesDepart[i + 1]);
                Controls.Add(CoordonneesDestination[i]);
                Controls.Add(CoordonneesDestination[i + 1]);

                PositionsPnl.Controls.Add(this.CoordonneesDepart[i]);
                PositionsPnl.Controls.Add(this.CoordonneesDepart[i + 1]);
                PositionsPnl.Controls.Add(this.CoordonneesDestination[i]);
                PositionsPnl.Controls.Add(this.CoordonneesDestination[i + 1]);

                CoordonneesDepart[i].TextChanged += new System.EventHandler(Lbl_TxtChanged);
                CoordonneesDepart[i + 1].TextChanged += new System.EventHandler(Lbl_TxtChanged);
                CoordonneesDestination[i].TextChanged += new System.EventHandler(Lbl_TxtChanged);
                CoordonneesDestination[i + 1].TextChanged += new System.EventHandler(Lbl_TxtChanged);
            }

        }

        private void LoadForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            convertCoordonnees();
            var myForm = new Form1(CoordonneesFinales);//CoordonneesFinales
            myForm.Show();
        }

        private void convertCoordonnees()
        {
            for (int i = 0; i < CoordonneesDepart.Length; i += 2)
            {
                CoordonneesFinales[i * 2] = int.Parse(CoordonneesDepart[i].Text);
                CoordonneesFinales[i * 2 + 1] = int.Parse(CoordonneesDepart[i + 1].Text);
                CoordonneesFinales[i * 2 + 2] = int.Parse(CoordonneesDestination[i].Text);
                CoordonneesFinales[i * 2 + 3] = int.Parse(CoordonneesDestination[i + 1].Text);
            }

        }

        private void Lbl_TxtChanged(object sender, EventArgs e)
        {
            foreach (TextBox T in PositionsPnl.Controls.OfType<TextBox>())
            {
                if (!Regex.IsMatch(T.Text, @"^[0-9]+$"))
                {
                    T.BackColor = Color.LightCoral;
                    LoadForm1.Enabled = false;
                    LoadForm1.BackColor = Color.Gainsboro;
                }
                else
                {
                    T.BackColor = Color.MediumSeaGreen;
                    LoadForm1.Enabled = true;
                    LoadForm1.BackColor = Color.MediumSeaGreen;
                }
            }

        }

    }
}
