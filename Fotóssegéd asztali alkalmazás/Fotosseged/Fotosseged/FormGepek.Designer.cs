namespace Fotosseged
{
    partial class FormGepek
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
            this.fényképezőgépekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objektívekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fényképezőgépekToolStripMenuItem,
            this.objektívekToolStripMenuItem,
            this.felhasználókToolStripMenuItem,
            this.névjegyToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fényképezőgépekToolStripMenuItem
            // 
            this.fényképezőgépekToolStripMenuItem.Name = "fényképezőgépekToolStripMenuItem";
            this.fényképezőgépekToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.fényképezőgépekToolStripMenuItem.Text = "Fényképezőgépek";
            // 
            // objektívekToolStripMenuItem
            // 
            this.objektívekToolStripMenuItem.Name = "objektívekToolStripMenuItem";
            this.objektívekToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.objektívekToolStripMenuItem.Text = "Objektívek";
            this.objektívekToolStripMenuItem.Click += new System.EventHandler(this.objektívekToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 520);
            this.dataGridView1.TabIndex = 1;
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // FormGepek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(989, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGepek";
            this.Text = "FormGepek";
            this.Load += new System.EventHandler(this.FormGepek_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fényképezőgépekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objektívekToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}