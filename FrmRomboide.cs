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
        private Romboide mRomboide=new Romboide();
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
            mRomboide.InitializeData(txtSides,txtBases,txtHeight,txtPerimeter,txtArea,picCanvas);
        }
        private bool validateRomboid()
        {
            if (float.Parse(txtSides.Text) <= 0 || float.Parse(txtBases.Text) <= 0
                || float.Parse(txtHeight.Text) <= 0)
            {
                MessageBox.Show("Error. Ingrese solo números positivos");
                return false;
            }
            else if (float.Parse(txtHeight.Text) > float.Parse(txtSides.Text))
            {
                MessageBox.Show("Error. La altura no puede ser mayor al valor de un lado.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void calculate(object sender, EventArgs e)
        {//Validación
            if (validateRomboid())
            {
                mRomboide.readData(txtSides, txtBases, txtHeight);
                mRomboide.perimeter();
                mRomboide.Area();
                //Impresión de datos
                mRomboide.PrintData(txtPerimeter, txtArea);
                //Graficación de un Rectángulo
                picCanvas.Refresh();//Reinicia el lienzo
                mRomboide.PlotShape(picCanvas);//Dibuja
            }

        }

        private void reset(object sender, EventArgs e)
        {
            //Inicialización de datos y controles
            mRomboide.InitializeData(txtSides, txtBases, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void close(object sender, EventArgs e)
        {
            //Cierra
            mRomboide.CloseForm(this);
        }

        private void tckScale_Scroll(object sender, EventArgs e)
        {
            mRomboide.scale(tckScale, picCanvas);
        }

        private void btnRotateHour_Click(object sender, EventArgs e)
        {
            mRomboide.rotate("hourly", picCanvas);
        }

        private void btnRotateAHour_Click(object sender, EventArgs e)
        {
            mRomboide.rotate("antihourly", picCanvas);
        }
        private void FrmRombo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                mRomboide.move("up", picCanvas);
            }
            else if (e.KeyCode == Keys.Down)
            {
                mRomboide.move("down", picCanvas);
            }
            else if (e.KeyCode == Keys.Left)
            {
                mRomboide.move("left", picCanvas);
            }
            else if (e.KeyCode == Keys.Right)
            {
                mRomboide.move("right", picCanvas);
            }
        }
    }
}
