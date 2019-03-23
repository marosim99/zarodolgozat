using ConnectToMysqlDatabase.Database;
using Fotosseged.Database;
using Fotosseged.Model;
using FotossegedAdminApp.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace FotossegedAdminApp
{

    public partial class FormGepek : Form
    {
        //GepekOperations GDO;
        //ObjektivOperations OO;
        
        
        bool modositva_gep = false;
        bool modositva_objektiv = false;
        bool modositva_user = false;

        public FormGepek()
        {
            InitializeComponent();
        }

        private MySQLDatabaseInterface mdi;

        private DataTable DTG; //Gépek tábla
        private DataTable DTO; //Objektívek tábla
        private DataTable DTU; //Felhasználók tábla

        private void FormGepek_Load(object sender, EventArgs e)
        {
            beallitVezerloketIndulaskor();
            beallitVezerloketIndulaskor_Objektivre();
            beallitVezerloketIndulaskor_User();
        }

        #region Fényképezőgépek Tab

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
            labelSorozat.Visible = false;
            labelSzenzor.Visible = false;
            labelTipus.Visible = false;

            buttonLoad.Visible = true;
            buttonExit.Visible = true;
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
            textBoxSorozat.Visible = false;
            textBoxSzenzor.Visible = false;
            textBoxTipus.Visible = false;

            labelAr.Visible = false;
            labelGyarto.Visible = false;
            labelObjektiv.Visible = false;
            labelPixel.Visible = false;
            labelSorozat.Visible = false;
            labelSzenzor.Visible = false;
            labelTipus.Visible = false;

            buttonLoad.Visible = true;
            buttonExit.Visible = true;

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
            textBoxSorozat.Visible = false;
            textBoxSzenzor.Visible = false;
            textBoxTipus.Visible = false;

            labelAr.Visible = false;
            labelGyarto.Visible = false;
            labelObjektiv.Visible = false;
            labelPixel.Visible = false;
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
            textBoxSorozat.Visible = true;
            textBoxSzenzor.Visible = true;
            textBoxTipus.Visible = true;

            labelAr.Visible = true;
            labelGyarto.Visible = true;
            labelObjektiv.Visible = true;
            labelPixel.Visible = true;
            labelSorozat.Visible = true;
            labelSzenzor.Visible = true;
            labelTipus.Visible = true;

            buttonExit.Visible = true;

            dataGridViewGepek.ReadOnly = false;
            dataGridViewGepek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGepek.AllowUserToDeleteRows = false;
            this.ActiveControl = textBoxGyarto;
        }

        /// <summary>
        /// Feltölti a gépek táblát adatbázisból
        /// </summary>
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
            modositva_gep = true;
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
                    modositva_gep = true;
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
            
            if (!modositva_gep)
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
            modositva_gep = true;

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
        #endregion
        
        #region Objektívek Tab

        private void buttonLoadO_Click(object sender, EventArgs e)
        {
            ObjektivAdatokFeltoltese();
            beallitVezerloketBetolteskor_Objektivre();
        }

        private void buttonEditO_Click(object sender, EventArgs e)
        {
            beallitVezerloketModositaskor_Objektivre();
        }

        private void buttonNewO_Click(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatFelvitelhez_Objektivre();
        }

        private void buttonCancelO_Click(object sender, EventArgs e)
        {
            ObjektivAdatokFeltoltese();
            beallitVezerloketModositaskor_Objektivre();
        }

        private void buttonBackO_Click(object sender, EventArgs e)
        {
            AdatokFeltoltese();
            beallitVezerloketModositaskor_Objektivre();
        }

        private void ObjektivAdatokFeltoltese()
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT * FROM objektiv;";
            DTO = mdi.getToDataTable(query);
            mdi.close();
            dataGridViewObjektiv.DataSource = DTO;
        }

        private void beallitVezerloketIndulaskor_Objektivre()
        {
            buttonAddO.Visible = false;
            buttonCancelO.Visible = false;
            buttonDeleteO.Visible = false;
            buttonEditO.Visible = false;
            buttonNewO.Visible = false;
            buttonSaveO.Visible = false;
            buttonBackO.Visible = false;
 
            textBoxGyartoO.Visible = false;
            textBoxTipusO.Visible = false;
            textBoxNev.Visible = false;
            textBoxGyujto.Visible = false;
            radioButtonNincs.Visible = false;
            radioButtonVan.Visible = false;
            textBoxMaxB.Visible = false;
            textBoxMinB.Visible = false;
            textBoxHossz.Visible = false;
            textBoxSuly.Visible = false;
            textBoxArO.Visible = false;

            
            labelGyartoO.Visible = false;
            labelTipusO.Visible = false;
            labelNev.Visible = false;
            labelGyujto.Visible = false;
            labelStabil.Visible = false;
            labelMinB.Visible = false;
            labelMaxB.Visible = false;
            labelHossz.Visible = false;
            labelSuly.Visible = false;
            labelArO.Visible = false;

            buttonLoadO.Visible = true;
            buttonExit.Visible = true;
            
        }

        private void beallitVezerloketBetolteskor_Objektivre()
        {
            buttonAddO.Visible = false;
            buttonCancelO.Visible = false;
            buttonDeleteO.Visible = false;
            buttonEditO.Visible = true;
            buttonNewO.Visible = false;
            buttonSaveO.Visible = false;
            buttonBackO.Visible = false;

            textBoxGyartoO.Visible = false;
            textBoxTipusO.Visible = false;
            textBoxNev.Visible = false;
            textBoxGyujto.Visible = false;
            radioButtonNincs.Visible = false;
            radioButtonVan.Visible = false;
            textBoxMaxB.Visible = false;
            textBoxMinB.Visible = false;
            textBoxHossz.Visible = false;
            textBoxSuly.Visible = false;
            textBoxArO.Visible = false;


            labelGyartoO.Visible = false;
            labelTipusO.Visible = false;
            labelNev.Visible = false;
            labelGyujto.Visible = false;
            labelStabil.Visible = false;
            labelMinB.Visible = false;
            labelMaxB.Visible = false;
            labelHossz.Visible = false;
            labelSuly.Visible = false;
            labelArO.Visible = false;

            buttonLoadO.Visible = true;
            buttonExit.Visible = true;

            dataGridViewObjektiv.ReadOnly = true;
            dataGridViewObjektiv.AllowUserToDeleteRows = false;
        }

        private void beallitVezerloketModositaskor_Objektivre()
        {
            buttonAddO.Visible = false;
            buttonCancelO.Visible = false;
            buttonDeleteO.Visible = true;
            buttonEditO.Visible = true;
            buttonNewO.Visible = true;
            buttonSaveO.Visible = false;
            buttonBackO.Visible = false;

            textBoxGyartoO.Visible = false;
            textBoxTipusO.Visible = false;
            textBoxNev.Visible = false;
            textBoxGyujto.Visible = false;
            radioButtonNincs.Visible = false;
            radioButtonVan.Visible = false;
            textBoxMaxB.Visible = false;
            textBoxMinB.Visible = false;
            textBoxHossz.Visible = false;
            textBoxSuly.Visible = false;
            textBoxArO.Visible = false;


            labelGyartoO.Visible = false;
            labelTipusO.Visible = false;
            labelNev.Visible = false;
            labelGyujto.Visible = false;
            labelStabil.Visible = false;
            labelMinB.Visible = false;
            labelMaxB.Visible = false;
            labelHossz.Visible = false;
            labelSuly.Visible = false;
            labelArO.Visible = false;

            buttonLoadO.Visible = true;
            buttonExit.Visible = true;

            dataGridViewObjektiv.ReadOnly = true;
            dataGridViewObjektiv.AllowUserToDeleteRows = false;

            dataGridViewObjektiv.ReadOnly = false;
            dataGridViewObjektiv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewObjektiv.AllowUserToDeleteRows = false;
        }

        private void beallitVezerloketUjAdatFelvitelhez_Objektivre()
        {
            buttonAddO.Visible = true;
            buttonCancelO.Visible = false;
            buttonDeleteO.Visible = false;
            buttonEditO.Visible = false;
            buttonNewO.Visible = false;
            buttonSaveO.Visible = false;
            buttonBackO.Visible = true;

            textBoxGyartoO.Visible = true;
            textBoxTipusO.Visible = true;
            textBoxNev.Visible = true;
            textBoxGyujto.Visible = true;
            radioButtonNincs.Visible = true;
            radioButtonVan.Visible = true;
            textBoxMaxB.Visible = true;
            textBoxMinB.Visible = true;
            textBoxHossz.Visible = true;
            textBoxSuly.Visible = true;
            textBoxArO.Visible = true;


            labelGyartoO.Visible = true;
            labelTipusO.Visible = true;
            labelNev.Visible = true;
            labelGyujto.Visible = true;
            labelStabil.Visible = true;
            labelMinB.Visible = true;
            labelMaxB.Visible = true;
            labelHossz.Visible = true;
            labelSuly.Visible = true;
            labelArO.Visible = true;

            buttonLoadO.Visible = false;
            buttonExit.Visible = true;

            dataGridViewObjektiv.ReadOnly = true;
            dataGridViewObjektiv.AllowUserToDeleteRows = false;

            dataGridViewObjektiv.ReadOnly = false;
            dataGridViewObjektiv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewObjektiv.AllowUserToDeleteRows = false;
            this.ActiveControl = textBoxTipusO;
        }

        private void dataGridViewObjektiv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modositva_objektiv = true;
        }

        private void buttonDeleteO_Click(object sender, EventArgs e)
        {
            try
            {
                int sor = dataGridViewObjektiv.SelectedRows[0].Index;
                if (MessageBox.Show("Valóban törölni akarja a sort?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    dataGridViewObjektiv.Rows.RemoveAt(sor);

                    buttonSaveO.Visible = true;
                    buttonCancelO.Visible = true;
                    modositva_objektiv = true;
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

        private void buttonSaveO_Click(object sender, EventArgs e)
        {
            if (!modositva_objektiv)
            {
                MessageBox.Show("Nem lett módosítva egy adat sem.", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mdi.updateChangesInTable(DTO);
                beallitVezerloketModositaskor_Objektivre();

                buttonNewO.Enabled = true;
                buttonEditO.Enabled = true;
                buttonDeleteO.Enabled = true;
            }
        }

        private void dataGridViewObjektiv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSaveO.Visible = true;
            buttonCancelO.Visible = true;
            modositva_objektiv = true;

            int sor = dataGridViewObjektiv.SelectedRows[0].Index;

            Objektivek objektiv = new Objektivek(
                Convert.ToInt32(dataGridViewObjektiv.SelectedRows[0].Cells["id"].Value),
                dataGridViewObjektiv.SelectedRows[0].Cells["tipus"].Value.ToString(),
                dataGridViewObjektiv.SelectedRows[0].Cells["gyarto"].Value.ToString(),
                dataGridViewObjektiv.SelectedRows[0].Cells["nev"].Value.ToString(),
                Convert.ToInt32(dataGridViewObjektiv.SelectedRows[0].Cells["gyujtotav"].Value),
                Convert.ToBoolean(dataGridViewObjektiv.SelectedRows[0].Cells["stabil"].Value),
                Convert.ToDouble(dataGridViewObjektiv.SelectedRows[0].Cells["minblende"].Value),
                Convert.ToDouble(dataGridViewObjektiv.SelectedRows[0].Cells["maxblende"].Value),
                Convert.ToInt32(dataGridViewObjektiv.SelectedRows[0].Cells["hossz"].Value),
                Convert.ToInt32(dataGridViewObjektiv.SelectedRows[0].Cells["suly"].Value),
                Convert.ToInt32(dataGridViewObjektiv.SelectedRows[0].Cells["ar"].Value)
                );

            ObjektivOperations oo = new ObjektivOperations(objektiv);

            Objektivek modositottObejktivek = oo.getModositottObjektivek();

            dataGridViewObjektiv.Rows[sor].Cells["tipus"].Value = modositottObejktivek.getTipus();
            dataGridViewObjektiv.Rows[sor].Cells["gyarto"].Value = modositottObejktivek.getGyarto();
            dataGridViewObjektiv.Rows[sor].Cells["nev"].Value = modositottObejktivek.getNev();
            dataGridViewObjektiv.Rows[sor].Cells["gyujtotav"].Value = modositottObejktivek.getGyujtotav();
            dataGridViewObjektiv.Rows[sor].Cells["stabil"].Value = modositottObejktivek.getStabil();
            dataGridViewObjektiv.Rows[sor].Cells["minblende"].Value = modositottObejktivek.getMinblende();
            dataGridViewObjektiv.Rows[sor].Cells["maxblende"].Value = modositottObejktivek.getMaxblende();
            dataGridViewObjektiv.Rows[sor].Cells["hossz"].Value = modositottObejktivek.getHossz();
            dataGridViewObjektiv.Rows[sor].Cells["suly"].Value = modositottObejktivek.getSuly();
            dataGridViewObjektiv.Rows[sor].Cells["ar"].Value = modositottObejktivek.getAr();
        }

        private void buttonAddO_Click(object sender, EventArgs e)
        {
            int ujObjektivId = 0;
            ObjektivOperations oo = new ObjektivOperations(ujObjektivId);
            ujObjektivId = oo.getUjObjektivId();

            bool stabil = false;
            if (radioButtonVan.Checked)
            {
                stabil = true;
            }
            else
            {
                stabil = false;
            }

            string tipus = textBoxTipusO.Text;
            string gyarto = textBoxGyartoO.Text;
            string nev = textBoxNev.Text;
            int gyujtotav = Convert.ToInt32(textBoxGyujto.Text);
            double minblende = Convert.ToDouble(textBoxMinB.Text);
            double maxblende = Convert.ToDouble(textBoxMaxB.Text);
            int hossz = Convert.ToInt32(textBoxHossz.Text);
            int suly = Convert.ToInt32(textBoxSuly.Text);
            int ar = Convert.ToInt32(textBoxArO.Text);

            Database update = new Database();
            mdi = update.kapcsolodas();
            mdi.open(); string query = "";
            query += "INSERT INTO objektiv (id, tipus, gyarto, nev, gyujtotav, stabil, minblende, maxblende, hossz, suly, ar) VALUES ";
            query += "(" + ujObjektivId + ", ";
            query += "\"" + tipus + "\", ";
            query += "\"" + gyarto + "\", ";
            query += "\"" + nev + "\", ";
            query += gyujtotav + ", ";
            query += stabil + ", ";
            query += minblende + ", ";
            query += maxblende + ", ";
            query += hossz + ", ";
            query += suly + ", ";
            query += ar + ")";
            mdi.executeDMQuery(query);
            mdi.close();

            int sor = dataGridViewObjektiv.Rows.Count - 1;

            dataGridViewObjektiv.Rows[sor].Cells["id"].Value = ujObjektivId;
            dataGridViewObjektiv.Rows[sor].Cells["tipus"].Value = tipus;
            dataGridViewObjektiv.Rows[sor].Cells["gyarto"].Value = gyarto;
            dataGridViewObjektiv.Rows[sor].Cells["nev"].Value = nev;
            dataGridViewObjektiv.Rows[sor].Cells["gyujtotav"].Value = gyujtotav;
            dataGridViewObjektiv.Rows[sor].Cells["stabil"].Value = stabil;
            dataGridViewObjektiv.Rows[sor].Cells["minblende"].Value = minblende;
            dataGridViewObjektiv.Rows[sor].Cells["maxblende"].Value = maxblende;
            dataGridViewObjektiv.Rows[sor].Cells["hossz"].Value = hossz;
            dataGridViewObjektiv.Rows[sor].Cells["suly"].Value = suly;
            dataGridViewObjektiv.Rows[sor].Cells["ar"].Value = ar;

            textBoxTipusO.Clear();
            textBoxGyartoO.Clear();
            textBoxNev.Clear();
            textBoxGyujto.Clear();
            textBoxMinB.Clear();
            textBoxMaxB.Clear();
            textBoxHossz.Clear();
            textBoxSuly.Clear();
            textBoxArO.Clear();
        }

        #endregion

        #region Felhasználók tab

        private void buttonLoadU_Click(object sender, EventArgs e)
        {
            UserAdatokFeltoltese();
            beallitVezerloketBetolteskor_User();
        }

        private void buttonEditU_Click(object sender, EventArgs e)
        {
            beallitVezerloketModositaskor_User();
        }

        private void buttonCancelU_Click(object sender, EventArgs e)
        {
            UserAdatokFeltoltese();
            beallitVezerloketModositaskor_User();
        }

        private void UserAdatokFeltoltese()
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT id, username, neme, email, admin FROM user;";
            DTU = mdi.getToDataTable(query);
            mdi.close();
            dataGridViewUsers.DataSource = DTU;
        }

        private void beallitVezerloketIndulaskor_User()
        {
            buttonCancelU.Visible = false;
            buttonDeleteU.Visible = false;
            buttonEditU.Visible = false;
            buttonSaveU.Visible = false;

            buttonLoadU.Visible = true;
            buttonExit.Visible = true;
        }

        private void beallitVezerloketBetolteskor_User()
        {
            buttonCancelU.Visible = false;
            buttonDeleteU.Visible = false;
            buttonEditU.Visible = true;
            buttonSaveU.Visible = false;

            buttonLoadU.Visible = true;
            buttonExit.Visible = true;

            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.AllowUserToDeleteRows = false;

        }

        private void beallitVezerloketModositaskor_User()
        {
            buttonCancelU.Visible = true;
            buttonDeleteU.Visible = true;
            buttonEditU.Visible = true;
            buttonSaveU.Visible = true;

            buttonLoadU.Visible = true;
            buttonExit.Visible = true;

            dataGridViewUsers.ReadOnly = false;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.AllowUserToDeleteRows = false;
        }

        private void dataGridViewUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modositva_user = true;
        }

        private void buttonDeleteU_Click(object sender, EventArgs e)
        {
            try
            {
                int sor = dataGridViewUsers.SelectedRows[0].Index;
                if (MessageBox.Show("Valóban törölni akarja a sort?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    dataGridViewUsers.Rows.RemoveAt(sor);

                    buttonSaveU.Visible = true;
                    buttonCancelU.Visible = true;
                    modositva_user = true;
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

        private void buttonSaveU_Click(object sender, EventArgs e)
        {
            if (!modositva_user)
            {
                MessageBox.Show("Nem lett módosítva egy adat sem.", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mdi.updateChangesInTable(DTU);
                beallitVezerloketModositaskor_User();

                buttonEditU.Enabled = true;
                buttonDeleteU.Enabled = true;
            }
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSaveU.Visible = true;
            buttonCancelU.Visible = true;
            modositva_user = true;

            int sor = dataGridViewUsers.SelectedRows[0].Index;


            Felhasznalok users = new Felhasznalok(
                Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["id"].Value),
                dataGridViewUsers.SelectedRows[0].Cells["username"].Value.ToString(),
                dataGridViewUsers.SelectedRows[0].Cells["neme"].Value.ToString(),
                dataGridViewUsers.SelectedRows[0].Cells["email"].Value.ToString(),
                Convert.ToBoolean(dataGridViewUsers.SelectedRows[0].Cells["admin"].Value)                
                );

            UserOperations uo = new UserOperations(users);

            Felhasznalok modositottFelhasznalok = uo.getModositottFelhasznalok();

            dataGridViewUsers.Rows[sor].Cells["username"].Value = modositottFelhasznalok.getFnev();
            dataGridViewUsers.Rows[sor].Cells["neme"].Value = modositottFelhasznalok.getNem();
            dataGridViewUsers.Rows[sor].Cells["email"].Value = modositottFelhasznalok.getEmail();
            dataGridViewUsers.Rows[sor].Cells["admin"].Value = modositottFelhasznalok.getAdmin();
        }

        #endregion

        
    }
}
