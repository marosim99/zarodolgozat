using ConnectToMysqlDatabase.Database;
using Fotosseged.Database;
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
        GepekDatabaseOperations GDO;
        
        
        bool modositva = false;
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
            buttonCancel.Visible = false;
            buttonDelete.Visible = true;
            buttonEdit.Visible = true;
            buttonNew.Visible = true;
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
            buttonSave.Visible = false;

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

        private MySQLDatabaseInterface mdi;
        //private MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();

        private DataTable DTG;

        private void AdatokFeltoltese()
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT * FROM gepek;";
            DTG = mdi.getToDataTable(query);
            mdi.close();
            dataGridViewGepek.DataSource = DTG;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewGepek_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modositva = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {            
                int sor = dataGridViewGepek.SelectedRows[0].Index;
                if (MessageBox.Show("Valóban törölni akarja a sort?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    dataGridViewGepek.Rows.RemoveAt(sor);

                    buttonSave.Visible = true;
                    buttonCancel.Visible = true;
                    modositva = true;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jelölje ki a törlendő sort!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!modositva)
            {
                MessageBox.Show("Nem lett módosítva egy adat sem.", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mdi.updateChangesInTable(DTG);
                beallitVezerloketModositaskor();

                buttonNew.Enabled = true;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        
    }
}
