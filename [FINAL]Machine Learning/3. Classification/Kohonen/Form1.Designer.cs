namespace Classification_Kohonen
{
    partial class Form1
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
            this.buttonInitDonnees = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KohonenBtn = new System.Windows.Forms.Button();
            this.RegroupementBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInitDonnees
            // 
            this.buttonInitDonnees.Location = new System.Drawing.Point(11, 11);
            this.buttonInitDonnees.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInitDonnees.Name = "buttonInitDonnees";
            this.buttonInitDonnees.Size = new System.Drawing.Size(164, 24);
            this.buttonInitDonnees.TabIndex = 0;
            this.buttonInitDonnees.Text = "Initialisation pb1";
            this.buttonInitDonnees.UseVisualStyleBackColor = true;
            this.buttonInitDonnees.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // KohonenBtn
            // 
            this.KohonenBtn.Location = new System.Drawing.Point(348, 7);
            this.KohonenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.KohonenBtn.Name = "KohonenBtn";
            this.KohonenBtn.Size = new System.Drawing.Size(82, 47);
            this.KohonenBtn.TabIndex = 2;
            this.KohonenBtn.Text = "Algo Kohonen";
            this.KohonenBtn.UseVisualStyleBackColor = true;
            this.KohonenBtn.Click += new System.EventHandler(this.Kohonen_Click);
            // 
            // RegroupementBtn
            // 
            this.RegroupementBtn.Location = new System.Drawing.Point(599, 13);
            this.RegroupementBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegroupementBtn.Name = "RegroupementBtn";
            this.RegroupementBtn.Size = new System.Drawing.Size(92, 35);
            this.RegroupementBtn.TabIndex = 3;
            this.RegroupementBtn.Text = "Regroupement";
            this.RegroupementBtn.UseVisualStyleBackColor = true;
            this.RegroupementBtn.Click += new System.EventHandler(this.RegroupementBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "20";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "nb colonnes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "nb lignes";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(479, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Coef. d\'apprentissage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 873);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RegroupementBtn);
            this.Controls.Add(this.KohonenBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonInitDonnees);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TP carte SOM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitDonnees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button KohonenBtn;
        private System.Windows.Forms.Button RegroupementBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

