namespace ProjetChariot1
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
            this.components = new System.ComponentModel.Container();
            this.labelsolution = new System.Windows.Forms.Label();
            this.GO_BT = new System.Windows.Forms.Button();
            this.labelcountclosed = new System.Windows.Forms.Label();
            this.labelcountopen = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelsolution
            // 
            this.labelsolution.AutoSize = true;
            this.labelsolution.Location = new System.Drawing.Point(1055, 415);
            this.labelsolution.Name = "labelsolution";
            this.labelsolution.Size = new System.Drawing.Size(35, 13);
            this.labelsolution.TabIndex = 15;
            this.labelsolution.Text = "label1";
            // 
            // GO_BT
            // 
            this.GO_BT.BackColor = System.Drawing.Color.Transparent;
            this.GO_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GO_BT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GO_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GO_BT.Location = new System.Drawing.Point(1140, 324);
            this.GO_BT.Name = "GO_BT";
            this.GO_BT.Size = new System.Drawing.Size(75, 23);
            this.GO_BT.TabIndex = 12;
            this.GO_BT.Text = "GO";
            this.GO_BT.UseVisualStyleBackColor = false;
            this.GO_BT.Click += new System.EventHandler(this.GO_Click);
            // 
            // labelcountclosed
            // 
            this.labelcountclosed.AutoSize = true;
            this.labelcountclosed.Location = new System.Drawing.Point(1078, 515);
            this.labelcountclosed.Name = "labelcountclosed";
            this.labelcountclosed.Size = new System.Drawing.Size(0, 13);
            this.labelcountclosed.TabIndex = 11;
            // 
            // labelcountopen
            // 
            this.labelcountopen.AutoSize = true;
            this.labelcountopen.Location = new System.Drawing.Point(1075, 487);
            this.labelcountopen.Name = "labelcountopen";
            this.labelcountopen.Size = new System.Drawing.Size(0, 13);
            this.labelcountopen.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 1045);
            this.Controls.Add(this.labelsolution);
            this.Controls.Add(this.GO_BT);
            this.Controls.Add(this.labelcountclosed);
            this.Controls.Add(this.labelcountopen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsolution;
        private System.Windows.Forms.Button GO_BT;
        private System.Windows.Forms.Label labelcountclosed;
        private System.Windows.Forms.Label labelcountopen;
        private System.Windows.Forms.Timer timer1;
    }
}

