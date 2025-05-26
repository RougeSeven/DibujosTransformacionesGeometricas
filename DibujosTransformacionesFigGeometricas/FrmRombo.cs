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
    public partial class FrmRombo : Form
    {
        private static FrmRombo instance=new FrmRombo();
        private FrmRombo()
        {
            InitializeComponent();
        }
        public static FrmRombo getInstance()
        {
            return instance;
        }

        private void FrmRombo_Load(object sender, EventArgs e)
        {

        }
    }
}
