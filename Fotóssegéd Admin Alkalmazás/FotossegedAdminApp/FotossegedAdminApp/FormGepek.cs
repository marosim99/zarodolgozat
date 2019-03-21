using ConnectToMysqlDatabase.Database;
using Fotosseged.Database;
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
        GepekOperations GDO;
        
        
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

        private void buttonBack_Click(object sender, EventArgs e)
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
            buttonBack.Visible = false;

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
            buttonBack.Visible = false;

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
            buttonBack.Visible = false;

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
            buttonCancel.Visible = false;
            buttonDelete.Visible = false;
            buttonEdit.Visible = false;
            buttonNew.Visible = false;
            buttonSave.Visible = false;
            buttonBack.Visible = true;

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
            this.ActiveControl = textBoxGyarto;
        }

        private MySQLDatabaseInterface mdi;

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



        private void dataGridViewGepek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            modositva = true;

            int sor = dataGridViewGepek.SelectedRows[0].Index;
            //int gepid = Convert.ToInt32(dataGridViewGepek.Rows[sor].Cells["id"].Value);


            Gepek gepek = new Gepek(
                Convert.ToInt32(dataGridViewGepek.SelectedRows[0].Cells["id"].Value),
                dataGridViewGepek.SelectedRows[0].Cells["gyarto"].Value.ToString(),
                dataGridViewGepek.SelectedRows[0].Cells["sorozat"].Value.ToString(),
                dataGridViewGepek.SelectedRows[0].Cells["tipus"].Value.ToString(),
                Convert.ToDouble(dataGridViewGepek.SelectedRows[0].Cells["pixel"].Value),
                dataGridViewGepek.SelectedRows[0].Cells["szenzor"].Value.ToString(),
                dataGridViewGepek.SelectedRows[0].Cells["objektiv"].Value.ToString(),
                Convert.ToInt32(dataGridViewGepek.SelectedRows[0].Cells["ar"].Value)
                );

                GepekOperations go = new GepekOperations(gepek);

                Gepek modositottGepek = go.getModositottGepek();

                dataGridViewGepek.Rows[sor].Cells["gyarto"].Value = modositottGepek.getGyarto();
                dataGridViewGepek.Rows[sor].Cells["sorozat"].Value = modositottGepek.getSorozat();
                dataGridViewGepek.Rows[sor].Cells["tipus"].Value = modositottGepek.getTipus();
                dataGridViewGepek.Rows[sor].Cells["pixel"].Value = modositottGepek.getPixel();
                dataGridViewGepek.Rows[sor].Cells["szenzor"].Value = modositottGepek.getSzenzor();
                dataGridViewGepek.Rows[sor].Cells["objektiv"].Value = modositottGepek.getObjektiv();
                dataGridViewGepek.Rows[sor].Cells["ar"].Value = modositottGepek.getAr();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int ujId = 0;
            GepekOperations go = new GepekOperations(ujId);
            ujId = go.getUjId();

            string gyarto = textBoxGyarto.Text;
            string sorozat = textBoxSorozat.Text;
            string tipus = textBoxTipus.Text;
            double pixel = Convert.ToDouble(textBoxPixel.Text);
            string szenzor = textBoxSzenzor.Text;
            string objektiv = textBoxObjektiv.Text;
            int ar = Convert.ToInt32(textBoxAr.Text);

            Database update = new Database();
            mdi = update.kapcsolodas();
            mdi.open(); string query = "";
            query += "INSERT INTO gepek (id,gyarto,sorozat,tipus,pixel,szenzor,objektiv,ar) VALUES ";
            query += "(" + ujId + ", ";
            query += "\"" + gyarto + "\", ";
            query += "\"" + sorozat + "\", ";
            query += "\"" + tipus + "\", ";
            query += pixel + ", ";
            query += "\"" + szenzor + "\", ";
            query += "\"" + objektiv + "\", ";
            query += ar + ")";
            mdi.executeDMQuery(query);
            mdi.close();

            int sor = dataGridViewGepek.Rows.Count - 1;

            dataGridViewGepek.Rows[sor].Cells["id"].Value = ujId;
            dataGridViewGepek.Rows[sor].Cells["gyarto"].Value = gyarto;
            dataGridViewGepek.Rows[sor].Cells["sorozat"].Value = sorozat;
            dataGridViewGepek.Rows[sor].Cells["tipus"].Value = tipus;
            dataGridViewGepek.Rows[sor].Cells["pixel"].Value = pixel;
            dataGridViewGepek.Rows[sor].Cells["szenzor"].Value = szenzor;
            dataGridViewGepek.Rows[sor].Cells["objektiv"].Value = objektiv;
            dataGridViewGepek.Rows[sor].Cells["ar"].Value = ar;

            textBoxGyarto.Clear();
            textBoxSorozat.Clear();
            textBoxTipus.Clear();
            textBoxPixel.Clear();
            textBoxSzenzor.Clear();
            textBoxObjektiv.Clear();
            textBoxAr.Clear();

        }



        private void dataGridViewGepek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageObjektivek_Click(object sender, EventArgs e)
        {

        }
    }
}
