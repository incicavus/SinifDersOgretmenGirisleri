namespace Challenge
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veriGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.classessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriGirişiToolStripMenuItem,
            this.güncellemeToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veriGirişiToolStripMenuItem
            // 
            this.veriGirişiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachersToolStripMenuItem,
            this.lessonsToolStripMenuItem,
            this.classesToolStripMenuItem});
            this.veriGirişiToolStripMenuItem.Name = "veriGirişiToolStripMenuItem";
            this.veriGirişiToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.veriGirişiToolStripMenuItem.Text = "İnsert";
            this.veriGirişiToolStripMenuItem.Click += new System.EventHandler(this.veriGirişiToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.teachersToolStripMenuItem_Click);
            // 
            // lessonsToolStripMenuItem
            // 
            this.lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            this.lessonsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.lessonsToolStripMenuItem.Text = "Lessons";
            this.lessonsToolStripMenuItem.Click += new System.EventHandler(this.lessonsToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // güncellemeToolStripMenuItem
            // 
            this.güncellemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachersToolStripMenuItem1,
            this.lessonsToolStripMenuItem1,
            this.classessToolStripMenuItem});
            this.güncellemeToolStripMenuItem.Name = "güncellemeToolStripMenuItem";
            this.güncellemeToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.güncellemeToolStripMenuItem.Text = "Update";
            // 
            // teachersToolStripMenuItem1
            // 
            this.teachersToolStripMenuItem1.Name = "teachersToolStripMenuItem1";
            this.teachersToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.teachersToolStripMenuItem1.Text = "Teachers";
            this.teachersToolStripMenuItem1.Click += new System.EventHandler(this.teachersToolStripMenuItem1_Click);
            // 
            // lessonsToolStripMenuItem1
            // 
            this.lessonsToolStripMenuItem1.Name = "lessonsToolStripMenuItem1";
            this.lessonsToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.lessonsToolStripMenuItem1.Text = "Lessons";
            this.lessonsToolStripMenuItem1.Click += new System.EventHandler(this.lessonsToolStripMenuItem1_Click);
            // 
            // classessToolStripMenuItem
            // 
            this.classessToolStripMenuItem.Name = "classessToolStripMenuItem";
            this.classessToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.classessToolStripMenuItem.Text = "Classes";
            this.classessToolStripMenuItem.Click += new System.EventHandler(this.classessToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachersToolStripMenuItem2,
            this.lessonsToolStripMenuItem2,
            this.classessToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // teachersToolStripMenuItem2
            // 
            this.teachersToolStripMenuItem2.Name = "teachersToolStripMenuItem2";
            this.teachersToolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.teachersToolStripMenuItem2.Text = "Teachers";
            this.teachersToolStripMenuItem2.Click += new System.EventHandler(this.teachersToolStripMenuItem2_Click);
            // 
            // lessonsToolStripMenuItem2
            // 
            this.lessonsToolStripMenuItem2.Name = "lessonsToolStripMenuItem2";
            this.lessonsToolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.lessonsToolStripMenuItem2.Text = "Lessons";
            this.lessonsToolStripMenuItem2.Click += new System.EventHandler(this.lessonsToolStripMenuItem2_Click);
            // 
            // classessToolStripMenuItem1
            // 
            this.classessToolStripMenuItem1.Name = "classessToolStripMenuItem1";
            this.classessToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.classessToolStripMenuItem1.Text = "Classes";
            this.classessToolStripMenuItem1.Click += new System.EventHandler(this.classessToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 380);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veriGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lessonsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lessonsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem classessToolStripMenuItem1;
    }
}

