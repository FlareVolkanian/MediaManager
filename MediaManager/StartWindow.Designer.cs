namespace ImageTagII
{
    partial class StartWindow
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
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To get started just add some places to look for images in";
            // 
            // lstFolders
            // 
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.ItemHeight = 20;
            this.lstFolders.Location = new System.Drawing.Point(12, 139);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(761, 244);
            this.lstFolders.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(652, 389);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(122, 47);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 26);
            this.textBox1.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(652, 94);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(121, 39);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add a folder:";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
    }
}