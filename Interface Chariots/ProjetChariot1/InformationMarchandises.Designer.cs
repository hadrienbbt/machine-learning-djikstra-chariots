namespace ProjetChariot1
{
    partial class InformationMarchandises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumEtagereLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAYONNAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 666);
            this.label2.TabIndex = 1;
            this.label2.Text = "8\r\n\r\n\r\n\r\n7\r\n\r\n\r\n\r\n6\r\n\r\n\r\n\r\n5\r\n\r\n\r\n\r\n4\r\n\r\n\r\n\r\n3\r\n\r\n\r\n\r\n2\r\n\r\n\r\n\r\n1";
            // 
            // NumEtagereLbl
            // 
            this.NumEtagereLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEtagereLbl.Location = new System.Drawing.Point(265, 150);
            this.NumEtagereLbl.Name = "NumEtagereLbl";
            this.NumEtagereLbl.Size = new System.Drawing.Size(110, 25);
            this.NumEtagereLbl.TabIndex = 2;
            this.NumEtagereLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 62);
            this.label4.TabIndex = 3;
            this.label4.Text = "---------------\r\nMarchandise\r\n---------------";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InformationMarchandises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 761);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumEtagereLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InformationMarchandises";
            this.Text = "Marchandises";
            this.Load += new System.EventHandler(this.InformationMarchandises_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumEtagereLbl;
        private System.Windows.Forms.Label label4;
    }
}