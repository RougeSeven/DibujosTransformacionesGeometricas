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
        private Pentagono mPentagono = new Pentagono();
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
            mPentagono.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            mPentagono.readData(txtSide);
            mPentagono.perimeter();
            mPentagono.Area();
            mPentagono.PrintData(txtPerimeter, txtArea);
            mPentagono.PlotShape(picCanvas);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            mPentagono.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            mPentagono.CloseForm(this);
        }
        private void tckScale_Scroll(object sender, EventArgs e)
        {
            mPentagono.scale(tckScale, picCanvas);
        }

        private void btnRotateHour_Click(object sender, EventArgs e)
        {
            mPentagono.rotate("hourly", picCanvas);
        }

        private void btnRotateAHour_Click(object sender, EventArgs e)
        {
            mPentagono.rotate("antihourly", picCanvas);
        }

        private void FrmPentagono_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                mPentagono.move("up", picCanvas);
            }
            else if (e.KeyCode == Keys.Down)
            {
                mPentagono.move("down", picCanvas);
            }
            else if (e.KeyCode == Keys.Left)
            {
                mPentagono.move("left", picCanvas);
            }
            else if (e.KeyCode == Keys.Right)
            {
                mPentagono.move("right", picCanvas);
            }
        }
    }
}
