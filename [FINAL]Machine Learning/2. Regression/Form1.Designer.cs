namespace Regression
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.InitBtn = new System.Windows.Forms.Button();
            this.ApprentissageBtn = new System.Windows.Forms.Button();
            this.textBoxnbentrees = new System.Windows.Forms.TextBox();
            this.textBoxnbcouches = new System.Windows.Forms.TextBox();
            this.textBoxnbneurcouche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxnumneur = new System.Windows.Forms.TextBox();
            this.textBoxnumcouche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AfficheInfoBtn = new System.Windows.Forms.Button();
            this.textBoxnbiter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxalpha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.erreurLbl = new System.Windows.Forms.Label();
            this.TauxErreurLbl = new System.Windows.Forms.Label();
            this.erreurLbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InitBtn
            // 
            this.InitBtn.Location = new System.Drawing.Point(38, 124);
            this.InitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InitBtn.Name = "InitBtn";
            this.InitBtn.Size = new System.Drawing.Size(116, 47);
            this.InitBtn.TabIndex = 0;
            this.InitBtn.Text = "Init réseau";
            this.InitBtn.UseVisualStyleBackColor = true;
            this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // ApprentissageBtn
            // 
            this.ApprentissageBtn.Location = new System.Drawing.Point(262, 124);
            this.ApprentissageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ApprentissageBtn.Name = "ApprentissageBtn";
            this.ApprentissageBtn.Size = new System.Drawing.Size(128, 47);
            this.ApprentissageBtn.TabIndex = 1;
            this.ApprentissageBtn.Text = "apprentissage";
            this.ApprentissageBtn.UseVisualStyleBackColor = true;
            this.ApprentissageBtn.Click += new System.EventHandler(this.ApprentissageBtn_Click);
            // 
            // textBoxnbentrees
            // 
            this.textBoxnbentrees.Location = new System.Drawing.Point(146, 6);
            this.textBoxnbentrees.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbentrees.Name = "textBoxnbentrees";
            this.textBoxnbentrees.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbentrees.TabIndex = 3;
            this.textBoxnbentrees.Text = "3";
            // 
            // textBoxnbcouches
            // 
            this.textBoxnbcouches.Location = new System.Drawing.Point(146, 28);
            this.textBoxnbcouches.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbcouches.Name = "textBoxnbcouches";
            this.textBoxnbcouches.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbcouches.TabIndex = 4;
            this.textBoxnbcouches.Text = "3";
            // 
            // textBoxnbneurcouche
            // 
            this.textBoxnbneurcouche.Location = new System.Drawing.Point(146, 51);
            this.textBoxnbneurcouche.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbneurcouche.Name = "textBoxnbneurcouche";
            this.textBoxnbneurcouche.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbneurcouche.TabIndex = 5;
            this.textBoxnbneurcouche.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "nb entrées";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "nb couches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "nb neurones par couche";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 267);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(472, 99);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 147);
            this.listBox1.TabIndex = 9;
            // 
            // textBoxnumneur
            // 
            this.textBoxnumneur.Location = new System.Drawing.Point(601, 27);
            this.textBoxnumneur.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnumneur.Name = "textBoxnumneur";
            this.textBoxnumneur.Size = new System.Drawing.Size(76, 20);
            this.textBoxnumneur.TabIndex = 10;
            this.textBoxnumneur.Text = "0";
            // 
            // textBoxnumcouche
            // 
            this.textBoxnumcouche.Location = new System.Drawing.Point(472, 27);
            this.textBoxnumcouche.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnumcouche.Name = "textBoxnumcouche";
            this.textBoxnumcouche.Size = new System.Drawing.Size(76, 20);
            this.textBoxnumcouche.TabIndex = 11;
            this.textBoxnumcouche.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numéro couche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numéro neurone";
            // 
            // AfficheInfoBtn
            // 
            this.AfficheInfoBtn.Location = new System.Drawing.Point(519, 63);
            this.AfficheInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AfficheInfoBtn.Name = "AfficheInfoBtn";
            this.AfficheInfoBtn.Size = new System.Drawing.Size(127, 24);
            this.AfficheInfoBtn.TabIndex = 14;
            this.AfficheInfoBtn.Text = "Affiche info neurone";
            this.AfficheInfoBtn.UseVisualStyleBackColor = true;
            this.AfficheInfoBtn.Click += new System.EventHandler(this.AfficheInfoBtn_Click);
            // 
            // textBoxnbiter
            // 
            this.textBoxnbiter.Location = new System.Drawing.Point(837, 34);
            this.textBoxnbiter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbiter.Name = "textBoxnbiter";
            this.textBoxnbiter.Size = new System.Drawing.Size(60, 20);
            this.textBoxnbiter.TabIndex = 15;
            this.textBoxnbiter.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "nb d\'itérations pour chaque apprentissage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(789, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "alpha (coefficient d\'apprentissage)";
            // 
            // textBoxalpha
            // 
            this.textBoxalpha.Location = new System.Drawing.Point(837, 89);
            this.textBoxalpha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxalpha.Name = "textBoxalpha";
            this.textBoxalpha.Size = new System.Drawing.Size(60, 20);
            this.textBoxalpha.TabIndex = 18;
            this.textBoxalpha.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(les entrées comptent pour 1 couche)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "(par couche cachée)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "(y compris la constante)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Obligatoire pour créer le réseau";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cliquez plusieurs fois pour converger";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(519, 267);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(799, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Erreur max :";
            // 
            // erreurLbl
            // 
            this.erreurLbl.AutoSize = true;
            this.erreurLbl.Location = new System.Drawing.Point(923, 187);
            this.erreurLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurLbl.Name = "erreurLbl";
            this.erreurLbl.Size = new System.Drawing.Size(34, 13);
            this.erreurLbl.TabIndex = 27;
            this.erreurLbl.Text = "erreur";
            // 
            // TauxErreurLbl
            // 
            this.TauxErreurLbl.AutoSize = true;
            this.TauxErreurLbl.Location = new System.Drawing.Point(796, 211);
            this.TauxErreurLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TauxErreurLbl.Name = "TauxErreurLbl";
            this.TauxErreurLbl.Size = new System.Drawing.Size(114, 13);
            this.TauxErreurLbl.TabIndex = 28;
            this.TauxErreurLbl.Text = "Taux d\'erreur résiduel :";
            // 
            // erreurLbl2
            // 
            this.erreurLbl2.AutoSize = true;
            this.erreurLbl2.Location = new System.Drawing.Point(923, 211);
            this.erreurLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurLbl2.Name = "erreurLbl2";
            this.erreurLbl2.Size = new System.Drawing.Size(34, 13);
            this.erreurLbl2.TabIndex = 29;
            this.erreurLbl2.Text = "erreur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 787);
            this.Controls.Add(this.erreurLbl2);
            this.Controls.Add(this.TauxErreurLbl);
            this.Controls.Add(this.erreurLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxalpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxnbiter);
            this.Controls.Add(this.AfficheInfoBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnumcouche);
            this.Controls.Add(this.textBoxnumneur);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnbneurcouche);
            this.Controls.Add(this.textBoxnbcouches);
            this.Controls.Add(this.textBoxnbentrees);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApprentissageBtn);
            this.Controls.Add(this.InitBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Perceptron multi-couches";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.Button ApprentissageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxnbentrees;
        private System.Windows.Forms.TextBox textBoxnbcouches;
        private System.Windows.Forms.TextBox textBoxnbneurcouche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxnumneur;
        private System.Windows.Forms.TextBox textBoxnumcouche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AfficheInfoBtn;
        private System.Windows.Forms.TextBox textBoxnbiter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxalpha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label erreurLbl;
        private System.Windows.Forms.Label TauxErreurLbl;
        private System.Windows.Forms.Label erreurLbl2;
    }
}