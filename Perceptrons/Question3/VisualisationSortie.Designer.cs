namespace Question3
{
    partial class VisualisationSortie
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
            this.ImageSortiePBox = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxnbneurcouche = new System.Windows.Forms.TextBox();
            this.textBoxnbcouches = new System.Windows.Forms.TextBox();
            this.textBoxnbentrees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxalpha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxnbiter = new System.Windows.Forms.TextBox();
            this.nbErreurs = new System.Windows.Forms.Label();
            this.nbErreur = new System.Windows.Forms.Label();
            this.incertitudes = new System.Windows.Forms.Label();
            this.incertitude = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbInclassable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSortiePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageSortiePBox
            // 
            this.ImageSortiePBox.Location = new System.Drawing.Point(11, 22);
            this.ImageSortiePBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImageSortiePBox.Name = "ImageSortiePBox";
            this.ImageSortiePBox.Size = new System.Drawing.Size(800, 800);
            this.ImageSortiePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageSortiePBox.TabIndex = 4;
            this.ImageSortiePBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(828, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Obligatoire pour créer le réseau";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "Init réseau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(993, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cliquez une fois pour converger";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1009, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "apprentissage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxnbneurcouche
            // 
            this.textBoxnbneurcouche.Location = new System.Drawing.Point(955, 246);
            this.textBoxnbneurcouche.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbneurcouche.Name = "textBoxnbneurcouche";
            this.textBoxnbneurcouche.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbneurcouche.TabIndex = 30;
            this.textBoxnbneurcouche.Text = "6";
            // 
            // textBoxnbcouches
            // 
            this.textBoxnbcouches.Location = new System.Drawing.Point(955, 219);
            this.textBoxnbcouches.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbcouches.Name = "textBoxnbcouches";
            this.textBoxnbcouches.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbcouches.TabIndex = 29;
            this.textBoxnbcouches.Text = "3";
            // 
            // textBoxnbentrees
            // 
            this.textBoxnbentrees.Location = new System.Drawing.Point(955, 190);
            this.textBoxnbentrees.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbentrees.Name = "textBoxnbentrees";
            this.textBoxnbentrees.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbentrees.TabIndex = 28;
            this.textBoxnbentrees.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "nb neurones par couche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "nb couches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(880, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "nb entrées";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1036, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "(par couche cachée)";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1036, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 33);
            this.label8.TabIndex = 35;
            this.label8.Text = "(les entrées comptent pour 1 couche)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1036, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "(y compris la constante)";
            // 
            // textBoxalpha
            // 
            this.textBoxalpha.Location = new System.Drawing.Point(955, 424);
            this.textBoxalpha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxalpha.Name = "textBoxalpha";
            this.textBoxalpha.Size = new System.Drawing.Size(76, 20);
            this.textBoxalpha.TabIndex = 40;
            this.textBoxalpha.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(913, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "alpha (coefficient d\'apprentissage)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(894, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "nb d\'itérations pour chaque apprentissage";
            // 
            // textBoxnbiter
            // 
            this.textBoxnbiter.Location = new System.Drawing.Point(955, 337);
            this.textBoxnbiter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnbiter.Name = "textBoxnbiter";
            this.textBoxnbiter.Size = new System.Drawing.Size(76, 20);
            this.textBoxnbiter.TabIndex = 37;
            this.textBoxnbiter.Text = "50";
            // 
            // nbErreurs
            // 
            this.nbErreurs.AutoSize = true;
            this.nbErreurs.Location = new System.Drawing.Point(1047, 569);
            this.nbErreurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nbErreurs.Name = "nbErreurs";
            this.nbErreurs.Size = new System.Drawing.Size(10, 13);
            this.nbErreurs.TabIndex = 44;
            this.nbErreurs.Text = "-";
            // 
            // nbErreur
            // 
            this.nbErreur.AutoSize = true;
            this.nbErreur.Location = new System.Drawing.Point(891, 569);
            this.nbErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nbErreur.Name = "nbErreur";
            this.nbErreur.Size = new System.Drawing.Size(54, 13);
            this.nbErreur.TabIndex = 43;
            this.nbErreur.Text = "NbErreurs";
            // 
            // incertitudes
            // 
            this.incertitudes.AutoSize = true;
            this.incertitudes.Location = new System.Drawing.Point(1047, 516);
            this.incertitudes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incertitudes.Name = "incertitudes";
            this.incertitudes.Size = new System.Drawing.Size(10, 13);
            this.incertitudes.TabIndex = 42;
            this.incertitudes.Text = "-";
            // 
            // incertitude
            // 
            this.incertitude.AutoSize = true;
            this.incertitude.Location = new System.Drawing.Point(891, 516);
            this.incertitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incertitude.Name = "incertitude";
            this.incertitude.Size = new System.Drawing.Size(57, 13);
            this.incertitude.TabIndex = 41;
            this.incertitude.Text = "Incertitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "NbInclassable";
            // 
            // nbInclassable
            // 
            this.nbInclassable.AutoSize = true;
            this.nbInclassable.Location = new System.Drawing.Point(1047, 544);
            this.nbInclassable.Name = "nbInclassable";
            this.nbInclassable.Size = new System.Drawing.Size(10, 13);
            this.nbInclassable.TabIndex = 46;
            this.nbInclassable.Text = "-";
            // 
            // VisualisationSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 873);
            this.Controls.Add(this.nbInclassable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nbErreurs);
            this.Controls.Add(this.nbErreur);
            this.Controls.Add(this.incertitudes);
            this.Controls.Add(this.incertitude);
            this.Controls.Add(this.textBoxalpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxnbiter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnbneurcouche);
            this.Controls.Add(this.textBoxnbcouches);
            this.Controls.Add(this.textBoxnbentrees);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImageSortiePBox);
            this.Name = "VisualisationSortie";
            this.Text = "VisualisationSortie";
            this.Load += new System.EventHandler(this.VisualisationSortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSortiePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxnbneurcouche;
        private System.Windows.Forms.TextBox textBoxnbcouches;
        private System.Windows.Forms.TextBox textBoxnbentrees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxalpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxnbiter;
        private System.Windows.Forms.Label nbErreurs;
        private System.Windows.Forms.Label nbErreur;
        private System.Windows.Forms.Label incertitudes;
        private System.Windows.Forms.Label incertitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nbInclassable;
    }
}