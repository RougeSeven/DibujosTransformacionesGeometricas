using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujosTransformacionesFigGeometricas
{
    internal class Romboide
    {
        private float sidesA;//Valor de un par de lados
        private float sidesB;//Valor del otro par de lados(Base)
        private float height;//Altura
        private float mPerimeter;//Perímetro
        private float mArea;//Área
        private Graphics mGraph;//Gráficos
        private Pen mPen;//Lápiz para dibujar
        private const int sf = 20; //Factor de escala para el dibujo
        private PointF shapeCenter;
        private PointF[] vertices;//Puntos del romboide
        private PointF[] distances;

        public Romboide()
        {
            height = 0.0f;
            sidesA = 0.0f;
            sidesB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            shapeCenter = new PointF(0, 0);
            vertices = new PointF[4]; //Inicializa el arreglo de puntos
            distances = new PointF[4];
        }
        //Función para leer datos de entrada
        public void readData(TextBox txtSidesA, TextBox txtSidesB, TextBox txtHeight)
        {
            //Validación de datos y tipo de dato
            try
            {
                sidesA = float.Parse(txtSidesA.Text);
                sidesB = float.Parse(txtSidesB.Text);
                height = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        //Función para calcular el perímetro
        public void perimeter()
        {
            mPerimeter = 2 * (sidesA + sidesB);//Los lados son iguales de 2 en 2
        }
        public void Area()
        {
            mArea = sidesB * height;//Su area es el producto de la base por su altura
        }
        //Función para inicializar los datos y controles del rectangulo
        public void InitializeData(TextBox txtSidesA, TextBox txtSidesB, TextBox txtHeight,
            TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            height = 0.0f;
            sidesA = 0.0f;
            sidesB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSidesA.Text = "";
            txtSidesB.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            shapeCenter = new PointF(0, 0);
            vertices = new PointF[4]; //Inicializa el arreglo de puntos
            distances = new PointF[4];
            picCanvas.Refresh();
        }
        //Mostrar los datos
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Grafica el romboide
        public void PlotShape(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();
            //Calcula y guarda el punto central de la figura
            Point center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);
            shapeCenter.X = center.X;
            shapeCenter.Y = center.Y;
            //Establece los 2 puntos de la base inferior
            //Punto A
            vertices[0].X = shapeCenter.X + ((sidesB / 2)*sf);
            vertices[0].Y = shapeCenter.Y + ((sidesB / 2)*sf);
            //Punto B
            vertices[1].X = shapeCenter.X - ((sidesB / 2) * sf);
            vertices[1].Y = vertices[0].Y;
            //Calcula la distancia horizontal al punto C, usando la alutra y teorema de pitágoras
            float distanceC = (float)(Math.Sqrt(Math.Pow(sidesA, 2) - Math.Pow(height, 2)));
            vertices[2].X = vertices[1].X + (distanceC*sf);
            vertices[2].Y = vertices[1].Y - (height*sf);
            //Como C, esta a verticalmente igual que D, se usa para calcularlo
            vertices[3].X= vertices[2].X + (sidesB*sf);
            vertices[3].Y= vertices[2].Y;
            mGraph.DrawPolygon(mPen, vertices);
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
            PointF[] scaledVertix = new PointF[4];
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
