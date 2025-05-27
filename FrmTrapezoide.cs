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
        private Trapezoide mTrapezoide=new Trapezoide();
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
            mTrapezoide.InitializeData(txtSidesA, txtSidesB, txtSidesC, txtSidesD, txtAngle,
                txtPerimeter, txtArea, picCanvas);
        }
        private bool validateRomboid()
        {
            if (float.Parse(txtSidesD.Text) <= 0 || float.Parse(txtSidesB.Text) <= 0
                || float.Parse(txtSidesA.Text) <= 0 || float.Parse(txtSidesC.Text) <= 0
                || float.Parse(txtAngle.Text) <= 0)
            {
                MessageBox.Show("Error. Ingrese solo números positivos");
                return false;
            }
            else if (float.Parse(txtAngle.Text) >= 180)//Evita colocar un angulo mayor a 180
            {
                MessageBox.Show("Error, ingrese un angulo menor a 180.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void calculate(object sender, EventArgs e)
        {
            mTrapezoide.readData(txtSidesA, txtSidesB, txtSidesC, txtSidesD, txtAngle);
            if (validateRomboid())
            {
                mTrapezoide.perimeter();
                mTrapezoide.Area();
                mTrapezoide.PrintData(txtPerimeter, txtArea);
                picCanvas.Refresh();//Reinicia el lienzo
                mTrapezoide.PlotShape(picCanvas);//Dibuja
            }
        }

        private void reset(object sender, EventArgs e)
        {
            mTrapezoide.InitializeData(txtSidesA, txtSidesB, txtSidesC, txtSidesD, txtAngle,
                txtPerimeter, txtArea, picCanvas);
        }

        private void close(object sender, EventArgs e)
        {
            mTrapezoide.CloseForm(this);
        }
    }
}
