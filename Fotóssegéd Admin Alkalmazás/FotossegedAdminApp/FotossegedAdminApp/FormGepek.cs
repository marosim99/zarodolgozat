using ConnectToMysqlDatabase;
using Fotosseged.Model;
using FotossegedAdminApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotossegedAdminApp
{
    
    public partial class FormGepek : Form
    {
        private DataTable DTG;
        GepekDatabaseOperations GDO;
        public FormGepek()
        {
            InitializeComponent();
        }

        private void FormGepek_Load(object sender, EventArgs e)
        {
            beallitVezerloketIndulaskor();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            AdatokFeltoltese();
            beallitVezerloketBetolteskor();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            beallitVezerloketModositaskor();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatFelvitelhez();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdatokFeltoltese();
            beallitVezerloketModositaskor();
        }

        /// <summary>
        /// Program indulása után csak a betöltés gomb legyen látható
        /// </summary>
        private void beallitVezerloketIndulaskor()
        {
            buttonAdd.Visible = false;
            buttonCancel.Visible = false;
            buttonDelete.Visible = false;
            buttonEdit.Visible = false;
            buttonNew.Visible = false;
            buttonSave.Visible = false;

            textBoxAr.Visible = false;
            textBoxGyarto.Visible = false;
            textBoxObjektiv.Visible = false;
            textBoxPixel.Visible = false;
            textBoxAr.Visible = false;
            textBoxSorozat.Visible = false;
            textBoxSzenzor.Visible = false;
            textBoxTipus.Visible = false;

            labelAr.Visible = false;
            labelGyarto.Visible = false;
            labelObjektiv.Visible = false;
            labelPixel.Visible = false;
            labelAr.Visible = false;
            labelSorozat.Visible = false;
            labelSzenzor.Visible = false;
            labelTipus.Visible = false;

            buttonLoad.Visible = true;
        }

        

        /// <summary>
        /// Adatok betöltése után csak a módosít gomb legyen látható, a DGV legyen csak olvasható
        /// </summary>
        private void beallitVezerloketBetolteskor()
        {
            buttonAdd.Visible = false;
            buttonCancel.Visible = false;
            buttonDelete.Visible = false;
            buttonEdit.Visible = true;
            buttonNew.Visible = false;
            buttonSave.Visible = false;

            textBoxAr.Visible = false;
            textBoxGyarto.Visible = false;
            textBoxObjektiv.Visible = false;
            textBoxPixel.Visible = false;
            textBoxAr.Visible = false;
            textBoxSorozat.Visible = false;
            textBoxSzenzor.Visible = false;
            textBoxTipus.Visible = false;

            labelAr.Visible = false;
            labelGyarto.Visible = false;
            labelObjektiv.Visible = false;
            labelPixel.Visible = false;
            labelAr.Visible = false;
            labelSorozat.Visible = false;
            labelSzenzor.Visible = false;
            labelTipus.Visible = false;

            buttonLoad.Visible = true;

            dataGridViewGepek.ReadOnly = true;
            dataGridViewGepek.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Módosításra megjeleníti a gombokat
        /// </summary>
        private void beallitVezerloketModositaskor()
        {
            buttonAdd.Visible = false;
            buttonCancel.Visible = true;
            buttonDelete.Visible = true;
            buttonEdit.Visible = true;
            buttonNew.Visible = true;
            buttonSave.Visible = true;

            textBoxAr.Visible = false;
            textBoxGyarto.Visible = false;
            textBoxObjektiv.Visible = false;
            textBoxPixel.Visible = false;
            textBoxAr.Visible = false;
            textBoxSorozat.Visible = false;
            textBoxSzenzor.Visible = false;
            textBoxTipus.Visible = false;

            labelAr.Visible = false;
            labelGyarto.Visible = false;
            labelObjektiv.Visible = false;
            labelPixel.Visible = false;
            labelAr.Visible = false;
            labelSorozat.Visible = false;
            labelSzenzor.Visible = false;
            labelTipus.Visible = false;

            buttonLoad.Visible = true;

            dataGridViewGepek.ReadOnly = false;
            dataGridViewGepek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGepek.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Megjeleníti a beviteli mezőket
        /// </summary>
        private void beallitVezerloketUjAdatFelvitelhez()
        {
            buttonLoad.Visible = false;
            buttonAdd.Visible = true;
            buttonCancel.Visible = true;
            buttonDelete.Visible = false;
            buttonEdit.Visible = false;
            buttonNew.Visible = false;
            buttonSave.Visible = true;

            textBoxAr.Visible = true;
            textBoxGyarto.Visible = true;
            textBoxObjektiv.Visible = true;
            textBoxPixel.Visible = true;
            textBoxAr.Visible = true;
            textBoxSorozat.Visible = true;
            textBoxSzenzor.Visible = true;
            textBoxTipus.Visible = true;

            labelAr.Visible = true;
            labelGyarto.Visible = true;
            labelObjektiv.Visible = true;
            labelPixel.Visible = true;
            labelAr.Visible = true;
            labelSorozat.Visible = true;
            labelSzenzor.Visible = true;
            labelTipus.Visible = true;

            dataGridViewGepek.ReadOnly = false;
            dataGridViewGepek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGepek.AllowUserToDeleteRows = false;
        }

        private void AdatokFeltoltese()
        {
            Database md = new Database();
            MySQLDatabaseInterface mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT * FROM gepek ";
            DTG = mdi.getToDataTable(query);
            mdi.close();
            dataGridViewGepek.DataSource = DTG;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
