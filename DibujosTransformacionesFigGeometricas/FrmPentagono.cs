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
    public partial class FrmPentagono : Form
    {
        private static FrmPentagono instance=new FrmPentagono();

        private FrmPentagono()
        {
            InitializeComponent();
        }
        public static FrmPentagono getInstance()
        {
            return instance;
        }

        private void FrmPentagono_Load(object sender, EventArgs e)
        {

        }
    }
}
