namespace FotossegedAdminApp
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
            this.tabControlGepek = new System.Windows.Forms.TabControl();
            this.tabPageGepek = new System.Windows.Forms.TabPage();
            this.tabPageObjektivek = new System.Windows.Forms.TabPage();
            this.dataGridViewGepek = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAr = new System.Windows.Forms.Label();
            this.labelObjektiv = new System.Windows.Forms.Label();
            this.labelSzenzor = new System.Windows.Forms.Label();
            this.labelPixel = new System.Windows.Forms.Label();
            this.labelTipus = new System.Windows.Forms.Label();
            this.labelSorozat = new System.Windows.Forms.Label();
            this.labelGyarto = new System.Windows.Forms.Label();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.textBoxObjektiv = new System.Windows.Forms.TextBox();
            this.textBoxSzenzor = new System.Windows.Forms.TextBox();
            this.textBoxPixel = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.textBoxSorozat = new System.Windows.Forms.TextBox();
            this.textBoxGyarto = new System.Windows.Forms.TextBox();
            this.tabPageFelhasznalok = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlGepek.SuspendLayout();
            this.tabPageGepek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGepek)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGepek
            // 
            this.tabControlGepek.Controls.Add(this.tabPageGepek);
            this.tabControlGepek.Controls.Add(this.tabPageObjektivek);
            this.tabControlGepek.Controls.Add(this.tabPageFelhasznalok);
            this.tabControlGepek.Location = new System.Drawing.Point(-1, 0);
            this.tabControlGepek.Name = "tabControlGepek";
            this.tabControlGepek.SelectedIndex = 0;
            this.tabControlGepek.Size = new System.Drawing.Size(995, 558);
            this.tabControlGepek.TabIndex = 0;
            // 
            // tabPageGepek
            // 
            this.tabPageGepek.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageGepek.Controls.Add(this.buttonExit);
            this.tabPageGepek.Controls.Add(this.labelAr);
            this.tabPageGepek.Controls.Add(this.dataGridViewGepek);
            this.tabPageGepek.Controls.Add(this.labelObjektiv);
            this.tabPageGepek.Controls.Add(this.buttonAdd);
            this.tabPageGepek.Controls.Add(this.labelSzenzor);
            this.tabPageGepek.Controls.Add(this.buttonLoad);
            this.tabPageGepek.Controls.Add(this.labelPixel);
            this.tabPageGepek.Controls.Add(this.buttonEdit);
            this.tabPageGepek.Controls.Add(this.labelTipus);
            this.tabPageGepek.Controls.Add(this.buttonDelete);
            this.tabPageGepek.Controls.Add(this.labelSorozat);
            this.tabPageGepek.Controls.Add(this.buttonNew);
            this.tabPageGepek.Controls.Add(this.labelGyarto);
            this.tabPageGepek.Controls.Add(this.buttonSave);
            this.tabPageGepek.Controls.Add(this.textBoxAr);
            this.tabPageGepek.Controls.Add(this.buttonCancel);
            this.tabPageGepek.Controls.Add(this.textBoxObjektiv);
            this.tabPageGepek.Controls.Add(this.textBoxGyarto);
            this.tabPageGepek.Controls.Add(this.textBoxSzenzor);
            this.tabPageGepek.Controls.Add(this.textBoxSorozat);
            this.tabPageGepek.Controls.Add(this.textBoxPixel);
            this.tabPageGepek.Controls.Add(this.textBoxTipus);
            this.tabPageGepek.Location = new System.Drawing.Point(4, 22);
            this.tabPageGepek.Name = "tabPageGepek";
            this.tabPageGepek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGepek.Size = new System.Drawing.Size(987, 532);
            this.tabPageGepek.TabIndex = 0;
            this.tabPageGepek.Text = "Fényképezőgépek";
            // 
            // tabPageObjektivek
            // 
            this.tabPageObjektivek.Location = new System.Drawing.Point(4, 22);
            this.tabPageObjektivek.Name = "tabPageObjektivek";
            this.tabPageObjektivek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObjektivek.Size = new System.Drawing.Size(987, 532);
            this.tabPageObjektivek.TabIndex = 1;
            this.tabPageObjektivek.Text = "Objektívek";
            this.tabPageObjektivek.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGepek
            // 
            this.dataGridViewGepek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGepek.Location = new System.Drawing.Point(3, 7);
            this.dataGridViewGepek.Name = "dataGridViewGepek";
            this.dataGridViewGepek.Size = new System.Drawing.Size(527, 522);
            this.dataGridViewGepek.TabIndex = 0;
            this.dataGridViewGepek.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGepek_CellValueChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoad.Location = new System.Drawing.Point(564, 7);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(178, 34);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Adatok betöltése";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEdit.Location = new System.Drawing.Point(564, 59);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(178, 34);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Adatok módosítása";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(564, 109);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(178, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Kijelölt sor törlése";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNew.Location = new System.Drawing.Point(564, 160);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(178, 34);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Új fényképezőgép";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(790, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(178, 34);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(790, 59);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(178, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(564, 467);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(178, 34);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Adatok felvitele";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelAr
            // 
            this.labelAr.AutoSize = true;
            this.labelAr.Location = new System.Drawing.Point(608, 444);
            this.labelAr.Name = "labelAr";
            this.labelAr.Size = new System.Drawing.Size(17, 13);
            this.labelAr.TabIndex = 33;
            this.labelAr.Text = "Ár";
            // 
            // labelObjektiv
            // 
            this.labelObjektiv.AutoSize = true;
            this.labelObjektiv.Location = new System.Drawing.Point(577, 403);
            this.labelObjektiv.Name = "labelObjektiv";
            this.labelObjektiv.Size = new System.Drawing.Size(48, 13);
            this.labelObjektiv.TabIndex = 32;
            this.labelObjektiv.Text = "Objektív";
            // 
            // labelSzenzor
            // 
            this.labelSzenzor.AutoSize = true;
            this.labelSzenzor.Location = new System.Drawing.Point(580, 362);
            this.labelSzenzor.Name = "labelSzenzor";
            this.labelSzenzor.Size = new System.Drawing.Size(45, 13);
            this.labelSzenzor.TabIndex = 31;
            this.labelSzenzor.Text = "Szenzor";
            // 
            // labelPixel
            // 
            this.labelPixel.AutoSize = true;
            this.labelPixel.Location = new System.Drawing.Point(596, 322);
            this.labelPixel.Name = "labelPixel";
            this.labelPixel.Size = new System.Drawing.Size(29, 13);
            this.labelPixel.TabIndex = 30;
            this.labelPixel.Text = "Pixel";
            // 
            // labelTipus
            // 
            this.labelTipus.AutoSize = true;
            this.labelTipus.Location = new System.Drawing.Point(590, 284);
            this.labelTipus.Name = "labelTipus";
            this.labelTipus.Size = new System.Drawing.Size(35, 13);
            this.labelTipus.TabIndex = 29;
            this.labelTipus.Text = "Típus";
            // 
            // labelSorozat
            // 
            this.labelSorozat.AutoSize = true;
            this.labelSorozat.Location = new System.Drawing.Point(582, 243);
            this.labelSorozat.Name = "labelSorozat";
            this.labelSorozat.Size = new System.Drawing.Size(43, 13);
            this.labelSorozat.TabIndex = 28;
            this.labelSorozat.Text = "Sorozat";
            // 
            // labelGyarto
            // 
            this.labelGyarto.AutoSize = true;
            this.labelGyarto.Location = new System.Drawing.Point(587, 203);
            this.labelGyarto.Name = "labelGyarto";
            this.labelGyarto.Size = new System.Drawing.Size(38, 13);
            this.labelGyarto.TabIndex = 27;
            this.labelGyarto.Text = "Gyártó";
            // 
            // textBoxAr
            // 
            this.textBoxAr.Location = new System.Drawing.Point(639, 441);
            this.textBoxAr.Name = "textBoxAr";
            this.textBoxAr.Size = new System.Drawing.Size(103, 20);
            this.textBoxAr.TabIndex = 26;
            // 
            // textBoxObjektiv
            // 
            this.textBoxObjektiv.Location = new System.Drawing.Point(639, 400);
            this.textBoxObjektiv.Name = "textBoxObjektiv";
            this.textBoxObjektiv.Size = new System.Drawing.Size(103, 20);
            this.textBoxObjektiv.TabIndex = 25;
            // 
            // textBoxSzenzor
            // 
            this.textBoxSzenzor.Location = new System.Drawing.Point(639, 359);
            this.textBoxSzenzor.Name = "textBoxSzenzor";
            this.textBoxSzenzor.Size = new System.Drawing.Size(103, 20);
            this.textBoxSzenzor.TabIndex = 24;
            // 
            // textBoxPixel
            // 
            this.textBoxPixel.Location = new System.Drawing.Point(639, 319);
            this.textBoxPixel.Name = "textBoxPixel";
            this.textBoxPixel.Size = new System.Drawing.Size(103, 20);
            this.textBoxPixel.TabIndex = 23;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Location = new System.Drawing.Point(639, 281);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(103, 20);
            this.textBoxTipus.TabIndex = 22;
            // 
            // textBoxSorozat
            // 
            this.textBoxSorozat.Location = new System.Drawing.Point(639, 240);
            this.textBoxSorozat.Name = "textBoxSorozat";
            this.textBoxSorozat.Size = new System.Drawing.Size(103, 20);
            this.textBoxSorozat.TabIndex = 21;
            // 
            // textBoxGyarto
            // 
            this.textBoxGyarto.Location = new System.Drawing.Point(639, 200);
            this.textBoxGyarto.Name = "textBoxGyarto";
            this.textBoxGyarto.Size = new System.Drawing.Size(103, 20);
            this.textBoxGyarto.TabIndex = 20;
            // 
            // tabPageFelhasznalok
            // 
            this.tabPageFelhasznalok.Location = new System.Drawing.Point(4, 22);
            this.tabPageFelhasznalok.Name = "tabPageFelhasznalok";
            this.tabPageFelhasznalok.Size = new System.Drawing.Size(987, 532);
            this.tabPageFelhasznalok.TabIndex = 2;
            this.tabPageFelhasznalok.Text = "Felhasználók";
            this.tabPageFelhasznalok.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(803, 488);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 34);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGepek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(993, 556);
            this.Controls.Add(this.tabControlGepek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGepek";
            this.Text = "FormGepek";
            this.Load += new System.EventHandler(this.FormGepek_Load);
            this.tabControlGepek.ResumeLayout(false);
            this.tabPageGepek.ResumeLayout(false);
            this.tabPageGepek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGepek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGepek;
        private System.Windows.Forms.TabPage tabPageGepek;
        private System.Windows.Forms.TabPage tabPageObjektivek;
        private System.Windows.Forms.DataGridView dataGridViewGepek;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAr;
        private System.Windows.Forms.Label labelObjektiv;
        private System.Windows.Forms.Label labelSzenzor;
        private System.Windows.Forms.Label labelPixel;
        private System.Windows.Forms.Label labelTipus;
        private System.Windows.Forms.Label labelSorozat;
        private System.Windows.Forms.Label labelGyarto;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.TextBox textBoxObjektiv;
        private System.Windows.Forms.TextBox textBoxSzenzor;
        private System.Windows.Forms.TextBox textBoxPixel;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.TextBox textBoxSorozat;
        private System.Windows.Forms.TextBox textBoxGyarto;
        private System.Windows.Forms.TabPage tabPageFelhasznalok;
        private System.Windows.Forms.Button buttonExit;
    }
}

