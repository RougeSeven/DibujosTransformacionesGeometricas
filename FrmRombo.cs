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
        private Rombo mRombo = new Rombo();
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
            mRombo.InitializeData(txtDiag1, txtDiag2, txtSides, txtPerimeter, txtArea, picCanvas);  
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            mRombo.readData(txtSides, txtDiag1, txtDiag2);
            mRombo.perimeter();
            mRombo.Area();
            mRombo.PrintData(txtPerimeter,txtArea);
            mRombo.PlotShape(picCanvas);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            mRombo.InitializeData(txtDiag1, txtDiag2, txtSides, txtPerimeter, txtArea, picCanvas);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            mRombo.CloseForm(this);
        }
        
   

        private void FrmRombo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                mRombo.move("up", picCanvas);
            }
            else if (e.KeyCode == Keys.Down)
            {
                mRombo.move("down", picCanvas);
            }
            else if (e.KeyCode == Keys.Left)
            {
                mRombo.move("left", picCanvas);
            }
            else if(e.KeyCode == Keys.Right) 
            {
                mRombo.move("right", picCanvas);
            }
        }

        private void tckScale_Scroll(object sender, EventArgs e)
        {
            mRombo.scale(tckScale,picCanvas);
        }

        private void btnRotateHour_Click(object sender, EventArgs e)
        {
            mRombo.rotate("hourly", picCanvas);
        }

        private void btnRotateAHour_Click(object sender, EventArgs e)
        {
            mRombo.rotate("antihourly", picCanvas);
        }
    }
}
