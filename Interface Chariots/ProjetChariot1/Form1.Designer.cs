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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.GoBtn = new System.Windows.Forms.Button();
            this.labelcountclosed = new System.Windows.Forms.Label();
            this.labelcountopen = new System.Windows.Forms.Label();
            this.labelsolution = new System.Windows.Forms.Label();
            this.InstructionPnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AlgoGbox = new System.Windows.Forms.GroupBox();
            this.MarchandisesBtn = new System.Windows.Forms.Button();
            this.PositionChoisieLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InstructionPnl.SuspendLayout();
            this.AlgoGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 14;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(120, 61);
            this.treeView1.TabIndex = 13;
            // 
            // GoBtn
            // 
            this.GoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.Location = new System.Drawing.Point(25, 144);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 23);
            this.GoBtn.TabIndex = 12;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelcountclosed
            // 
            this.labelcountclosed.AutoSize = true;
            this.labelcountclosed.Location = new System.Drawing.Point(1022, 552);
            this.labelcountclosed.Name = "labelcountclosed";
            this.labelcountclosed.Size = new System.Drawing.Size(0, 13);
            this.labelcountclosed.TabIndex = 11;
            // 
            // labelcountopen
            // 
            this.labelcountopen.AutoSize = true;
            this.labelcountopen.Location = new System.Drawing.Point(1019, 524);
            this.labelcountopen.Name = "labelcountopen";
            this.labelcountopen.Size = new System.Drawing.Size(0, 13);
            this.labelcountopen.TabIndex = 10;
            // 
            // labelsolution
            // 
            this.labelsolution.AutoSize = true;
            this.labelsolution.Location = new System.Drawing.Point(6, 185);
            this.labelsolution.Name = "labelsolution";
            this.labelsolution.Size = new System.Drawing.Size(35, 13);
            this.labelsolution.TabIndex = 15;
            this.labelsolution.Text = "label1";
            // 
            // InstructionPnl
            // 
            this.InstructionPnl.BackColor = System.Drawing.Color.White;
            this.InstructionPnl.Controls.Add(this.label3);
            this.InstructionPnl.Controls.Add(this.AlgoGbox);
            this.InstructionPnl.Controls.Add(this.MarchandisesBtn);
            this.InstructionPnl.Controls.Add(this.PositionChoisieLbl);
            this.InstructionPnl.Controls.Add(this.positionLbl);
            this.InstructionPnl.Controls.Add(this.label2);
            this.InstructionPnl.Controls.Add(this.label1);
            this.InstructionPnl.Location = new System.Drawing.Point(1027, 21);
            this.InstructionPnl.Name = "InstructionPnl";
            this.InstructionPnl.Size = new System.Drawing.Size(150, 708);
            this.InstructionPnl.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marchandises :";
            // 
            // AlgoGbox
            // 
            this.AlgoGbox.Controls.Add(this.treeView1);
            this.AlgoGbox.Controls.Add(this.listBox1);
            this.AlgoGbox.Controls.Add(this.GoBtn);
            this.AlgoGbox.Controls.Add(this.labelsolution);
            this.AlgoGbox.Location = new System.Drawing.Point(11, 455);
            this.AlgoGbox.Name = "AlgoGbox";
            this.AlgoGbox.Size = new System.Drawing.Size(131, 218);
            this.AlgoGbox.TabIndex = 17;
            this.AlgoGbox.TabStop = false;
            // 
            // MarchandisesBtn
            // 
            this.MarchandisesBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MarchandisesBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarchandisesBtn.Location = new System.Drawing.Point(12, 293);
            this.MarchandisesBtn.Name = "MarchandisesBtn";
            this.MarchandisesBtn.Size = new System.Drawing.Size(120, 71);
            this.MarchandisesBtn.TabIndex = 20;
            this.MarchandisesBtn.Text = "Informations sur les marchandises";
            this.MarchandisesBtn.UseVisualStyleBackColor = false;
            this.MarchandisesBtn.Click += new System.EventHandler(this.MarchandisesBtn_Click);
            // 
            // PositionChoisieLbl
            // 
            this.PositionChoisieLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionChoisieLbl.Location = new System.Drawing.Point(7, 179);
            this.PositionChoisieLbl.Name = "PositionChoisieLbl";
            this.PositionChoisieLbl.Size = new System.Drawing.Size(134, 49);
            this.PositionChoisieLbl.TabIndex = 19;
            this.PositionChoisieLbl.Text = "A définir";
            this.PositionChoisieLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PositionChoisieLbl.Visible = false;
            // 
            // positionLbl
            // 
            this.positionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(36, 139);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(80, 26);
            this.positionLbl.TabIndex = 18;
            this.positionLbl.Text = "Position :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Instructions :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Veuillez positionner vos chariots sur la case désirée.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.InstructionPnl);
            this.Controls.Add(this.labelcountclosed);
            this.Controls.Add(this.labelcountopen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Redimensionnement_Fenetre_Fin);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectionChariot);
            this.InstructionPnl.ResumeLayout(false);
            this.InstructionPnl.PerformLayout();
            this.AlgoGbox.ResumeLayout(false);
            this.AlgoGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label labelcountclosed;
        private System.Windows.Forms.Label labelcountopen;
        private System.Windows.Forms.Label labelsolution;
        private System.Windows.Forms.Panel InstructionPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label PositionChoisieLbl;
        private System.Windows.Forms.Button MarchandisesBtn;
        private System.Windows.Forms.GroupBox AlgoGbox;
        private System.Windows.Forms.Label label3;
    }
}

