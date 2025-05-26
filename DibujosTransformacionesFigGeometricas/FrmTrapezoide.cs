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
    public partial class FrmTrapezoide : Form
    {
        private static FrmTrapezoide instance=new FrmTrapezoide();
        private FrmTrapezoide()
        {
            InitializeComponent();
        }
        public static FrmTrapezoide getInstance()
        {
            return instance;
        }
        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {

        }
    }
}
