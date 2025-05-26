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
    public partial class FrmRomboide : Form
    {
        private static FrmRomboide instance=new FrmRomboide();
        private FrmRomboide()
        {
            InitializeComponent();
        }
        public static FrmRomboide getInstance()
        {
            return instance;
        }
        private void FrmRomboide_Load(object sender, EventArgs e)
        {

        }
    }
}
