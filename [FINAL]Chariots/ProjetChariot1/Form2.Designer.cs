namespace ProjetChariot1
{
    partial class Form2
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
            this.labelsolution = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.GO_BT = new System.Windows.Forms.Button();
            this.labelcountclosed = new System.Windows.Forms.Label();
            this.labelcountopen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // labelsolution
            // 
            this.labelsolution.AutoSize = true;
            this.labelsolution.Location = new System.Drawing.Point(1261, 734);
            this.labelsolution.Name = "labelsolution";
            this.labelsolution.Size = new System.Drawing.Size(35, 13);
            this.labelsolution.TabIndex = 23;
            this.labelsolution.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1261, 608);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 22;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1185, 393);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(241, 209);
            this.treeView1.TabIndex = 21;
            // 
            // GO_BT
            // 
            this.GO_BT.BackColor = System.Drawing.Color.Transparent;
            this.GO_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GO_BT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GO_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GO_BT.Location = new System.Drawing.Point(1284, 324);
            this.GO_BT.Name = "GO_BT";
            this.GO_BT.Size = new System.Drawing.Size(75, 23);
            this.GO_BT.TabIndex = 20;
            this.GO_BT.Text = "GO";
            this.GO_BT.UseVisualStyleBackColor = false;
            this.GO_BT.Click += new System.EventHandler(this.GO_BT_Click);
            // 
            // labelcountclosed
            // 
            this.labelcountclosed.AutoSize = true;
            this.labelcountclosed.Location = new System.Drawing.Point(1284, 834);
            this.labelcountclosed.Name = "labelcountclosed";
            this.labelcountclosed.Size = new System.Drawing.Size(0, 13);
            this.labelcountclosed.TabIndex = 19;
            // 
            // labelcountopen
            // 
            this.labelcountopen.AutoSize = true;
            this.labelcountopen.Location = new System.Drawing.Point(1281, 806);
            this.labelcountopen.Name = "labelcountopen";
            this.labelcountopen.Size = new System.Drawing.Size(0, 13);
            this.labelcountopen.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 1030);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelsolution);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.GO_BT);
            this.Controls.Add(this.labelcountclosed);
            this.Controls.Add(this.labelcountopen);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsolution;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button GO_BT;
        private System.Windows.Forms.Label labelcountclosed;
        private System.Windows.Forms.Label labelcountopen;
    }
}