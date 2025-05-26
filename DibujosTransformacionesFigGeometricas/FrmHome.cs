using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujosTransformacionesFigGeometricas
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void mbRombo_Click(object sender, EventArgs e)
        {
            FrmRombo mRombo = FrmRombo.getInstance(); //Crea un nuevo hijo
            mRombo.MdiParent = this; //Define al formulario inicio como padre del hijo
            mRombo.Show(); //Muestra el hijo
        }
        private void mbPentagono_Click(object sender, EventArgs e)
        {
            FrmPentagono mPentagono = FrmPentagono.getInstance(); //Crea un nuevo hijo
            mPentagono.MdiParent = this; //Define al formulario inicio como padre del hijo
            mPentagono.Show(); //Muestra el hijo
        }
        private void mbRomboide_Click(object sender, EventArgs e)
        {
            FrmRomboide mRomboide = FrmRomboide.getInstance(); //Crea un nuevo hijo
            mRomboide.MdiParent = this; //Define al formulario inicio como padre del hijo
            mRomboide.Show(); //Muestra el hijo
        }
        private void mbTrapezoide_Click(object sender, EventArgs e)
        {
            FrmTrapezoide mTrapezoide = FrmTrapezoide.getInstance(); //Crea un nuevo hijo
            mTrapezoide.MdiParent = this; //Define al formulario inicio como padre del hijo
            mTrapezoide.Show(); //Muestra el hijo
        }
    }
}
