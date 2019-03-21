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
        public FormGepek()
        {
            InitializeComponent();
        }

        private void FormGepek_Load(object sender, EventArgs e)
        {
            beallitVezerloketIndulaskor();
        }

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
    }
}
