using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujosTransformacionesFigGeometricas
{
    internal class Pentagono
    {
        private float side;//Lado
        private float mPerimeter;//Perímetro
        private float mArea;//Área
        private float radius;
        private Graphics mGraph;//Gráficos
        private Pen mPen;//Lápiz para dibujar
        private const int sf = 20; //Factor de escala para el dibujo
        private PointF shapeCenter;
        private PointF[] vertices;//Puntos del rombo
        private PointF[] distances;
        public Pentagono()
        {
            side = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            shapeCenter = new PointF(0, 0);
            vertices = new PointF[5]; //Inicializa el arreglo de puntos
            distances = new PointF[5];
        }
        //Función para leer datos de entrada
        public void readData(TextBox txtSide)
        {
            //Validación de datos y tipo de dato
            try
            {
                side = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        //Función para calcular el perímetro
        public void perimeter()
        {
            mPerimeter = side * 5;
        }
        public void Area()
        {
            //Cálculo usando apotema
            mArea = ((float)(1 / (Math.Tan(Math.PI / 5)))) * ((mPerimeter * side) / 4);
        }
        //Función para inicializar los datos y controles del rectangulo
        public void InitializeData(TextBox txtSides,
            TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            side = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            shapeCenter = new PointF(0, 0);
            vertices = new PointF[5]; //Reinicializa el arreglo de puntos
            distances = new PointF[5];
            txtSides.Text = "";
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
            //Calcula y guarda el punto central de la figura
            Point center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);
            shapeCenter.X = center.X;
            shapeCenter.Y = center.Y;
            //Calcula y guarda el radio
            radius = (float)(side/(2*(Math.Sin(Math.PI/5))));
            //Dibuja los 2 primeros puntos a partir de la diagonal mayor.
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].X = shapeCenter.X + (float)((radius * sf * Math.Cos((2 * Math.PI * i) / 5)));
                vertices[i].Y = shapeCenter.Y + (float)((radius * sf * Math.Sin((2 * Math.PI * i) / 5)));
            }
            //Dibuja el rombo
            mGraph.DrawPolygon(mPen, vertices);
            //Guarda las distancias
            for (int i = 0; i < vertices.Length; i++)
            {
                distances[i] = new PointF(vertices[i].X - shapeCenter.X, vertices[i].Y - shapeCenter.Y);
            }


        }
        public void move(String direction, PictureBox picCanvas)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                if (direction == "up")
                {
                    vertices[i].Y -= 10; //Mover hacia arriba
                }
                else if (direction == "down")
                {
                    vertices[i].Y += 10; //Mover hacia abajo
                }
                else if (direction == "left")
                {
                    vertices[i].X -= 10; //Mover hacia la izquierda
                }
                else
                {
                    vertices[i].X += 10; //Mover hacia la derecha
                }
            }
            //Mueve el centro también
            if (direction == "up")
            {
                shapeCenter.Y -= 10; //Mover hacia arriba
            }
            else if (direction == "down")
            {
                shapeCenter.Y += 10; //Mover hacia abajo
            }
            else if (direction == "left")
            {
                shapeCenter.X -= 10; //Mover hacia la izquierda
            }
            else
            {
                shapeCenter.X += 10; //Mover hacia la derecha
            }
            picCanvas.Refresh();
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();
            mGraph.DrawPolygon(mPen, vertices);
        }
        public void scale(TrackBar tckScale, PictureBox picCanvas)
        {
            float scaleFactor = tckScale.Value;
            //Prepara los elementos gráficos
            picCanvas.Refresh();
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();
            PointF[] scaledVertix = new PointF[5];
            //Cambia las distancias a que están los puntos del centro de la figura
            for (int i = 0; i < scaledVertix.Length; i++)
            {
                scaledVertix[i].X = shapeCenter.X + (distances[i].X * scaleFactor);
                scaledVertix[i].Y = shapeCenter.Y + (distances[i].Y * scaleFactor);
            }
            mGraph.DrawPolygon(mPen, scaledVertix);
        }

        public void rotate(String direction, PictureBox picCanvas)
        {
            //Prepara los elementos gráficos
            picCanvas.Refresh();
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();

            float angle = (float)(Math.PI / 18);//Gira un ángulo de 10 grados
            if (direction == "antihourly")
            {
                angle = -1 * angle;
            }
            for (int i = 0; i < vertices.Length; i++)
            {
                float tempX = vertices[i].X - shapeCenter.X;
                float tempY = vertices[i].Y - shapeCenter.Y;

                float rotatedX = (float)(tempX * Math.Cos(angle) - tempY * Math.Sin(angle));
                float rotatedY = (float)(tempX * Math.Sin(angle) + tempY * Math.Cos(angle));

                vertices[i].X = (float)Math.Round(rotatedX + shapeCenter.X);
                vertices[i].Y = (float)Math.Round(rotatedY + shapeCenter.Y);
            }
            mGraph.DrawPolygon(mPen, vertices);

        }
        //Cerrar el formulario
        public void CloseForm(Form mForm)
        {
            mForm.Close();
        }
    }
}
