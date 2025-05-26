using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujosTransformacionesFigGeometricas
{
    internal class Rombo
    {
      
        private float side;//Lado
        private float diagD;//Diagonal Mayor
        private float diagd;//Diagonal Menor
        private float mPerimeter;//Perímetro
        private float mArea;//Área
        private Graphics mGraph;//Gráficos
        private Pen mPen;//Lápiz para dibujar
        private const int sf=20; //Factor de escala para el dibujo
        private PointF[] vertices;//Puntos del rombo
        public Rombo()
        {
            diagD = 0.0f;
            diagd = 0.0f;
            side = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            vertices = new PointF[4]; //Inicializa el arreglo de puntos
        }
        //Función para leer datos de entrada
        public void readData(TextBox txtSides, TextBox txtDiag1, TextBox txtDiag2)
        {
            //Validación de datos y tipo de dato
            try
            {
                side = float.Parse(txtSides.Text);
                diagD = float.Parse(txtDiag1.Text);
                diagd = float.Parse(txtDiag2.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        //Función para calcular el perímetro
        public void perimeter()
        {
            mPerimeter = side * 4;
        }
        public void Area()
        {
            mArea = (diagD * diagd) / 2;
        }
        //Función para inicializar los datos y controles del rectangulo
        public void InitializeData(TextBox txtDiag1, TextBox txtDiag2, TextBox txtSides,
            TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            diagD = 0.0f;
            diagd = 0.0f;
            side = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            vertices = new PointF[4]; //Reinicializa el arreglo de puntos
            txtDiag1.Text = "";
            txtDiag2.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
        }
        //Mostrar los datos
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Grafica el rectángulo
        public void PlotShape(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();
            //Primero calcula la mitad de la diagonal menor
            float diagSm = (float)Math.Sqrt(Math.Pow(side, 2) - Math.Pow(diagD / 2, 2));
            MessageBox.Show("Diagonal menor mitad: " + diagSm.ToString());
            //Dibuja los 2 primeros puntos a partir de la diagonal mayor.
            Point center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);
            vertices[0] = new PointF(center.X + ((diagD / 2) * sf), center.Y);
            vertices[1] = new PointF(center.X, center.Y + (diagSm * sf));
            vertices[2] = new PointF(center.X - ((diagD / 2) * sf), center.Y);
            vertices[3] = new PointF(center.X, center.Y - (diagSm*sf));
            //Dibuja el rombo
            mGraph.DrawPolygon(mPen, vertices);
        }
        //Cerrar el formulario
        public void CloseForm(Form mForm)
        {
            mForm.Close();
        }
    }
}
