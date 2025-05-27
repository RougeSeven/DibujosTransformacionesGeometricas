using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujosTransformacionesFigGeometricas
{
    internal class Trapezoide
    {
        //Lados
        private float sideA;
        private float sideB;
        private float sideC;
        private float sideD;
        private float angle;
        private float mPerimeter;//Perímetro
        private float mArea;//Área
        private float diag;
        private Graphics mGraph;//Gráficos
        private Pen mPen;//Lápiz para dibujar
        private const int sf = 20; //Factor de escala para el dibujo
        private PointF shapeCenter;
        private PointF[] vertices;//Puntos del trapezoide
        private PointF[] distances;
        public Trapezoide()
        {
            sideA = 0.0f;
            sideB = 0.0f;
            sideC = 0.0f;
            sideD = 0.0f;
            angle = 0.0f;
            diag = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            shapeCenter = new PointF(0, 0);
            vertices = new PointF[4]; //Inicializa el arreglo de puntos
            distances = new PointF[4];
        }
        //Función para leer datos de entrada
        public void readData(TextBox txtSidesA, TextBox txtSidesB, TextBox txtSidesC, TextBox txtSidesD,
            TextBox txtAngle)
        {
            //Validación de datos y tipo de dato
            try
            {
                sideA = float.Parse(txtSidesA.Text);
                sideB = float.Parse(txtSidesB.Text);
                sideC = float.Parse(txtSidesC.Text);
                sideD = float.Parse(txtSidesD.Text);
                angle = float.Parse(txtAngle.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        //Función para calcular el perímetro
        public void perimeter()
        {
            mPerimeter = sideA + sideC + sideB + sideD;//Los lados son iguales de 2 en 2
        }
        public void Area()
        {
            float a = sideA;
            float b = sideB;
            float c = sideC;
            float d = sideD;
            float ang = (float)((angle * Math.PI) / 180);
            //Se calcula una diagonal para dividir en 2 triángulos y sumar sus áreas.
            //La diagonal proviene de la ley de cosenos
            diag = (float)(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * b * a * Math.Cos(ang))));
            //Área del primer triángulo con fórmula de Herón
            float sp = (c + d + diag) / 2;
            float triang1Area = (float)(Math.Sqrt((sp * (sp - c) * (sp - d) * (sp - diag))));
            MessageBox.Show(triang1Area.ToString());
            //Área del 2do triángulo con fórmula de Herón
            sp = (a + b + diag) / 2;
            float triang2Area = (float)(Math.Sqrt((sp * (sp - a) * (sp - b) * (sp - diag))));
            MessageBox.Show(triang2Area.ToString());
            //Suma de áreas
            mArea = triang1Area + triang2Area;
        }
       
        public void InitializeData(TextBox txtSidesA, TextBox txtSidesB, TextBox txtSidesC,
           TextBox txtSidesD, TextBox txtAngle,
           TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            sideA = 0.0f;
            sideB = 0.0f;
            sideC = 0.0f;
            sideD = 0.0f;
            angle = 0.0f;
            diag = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSidesA.Text = "";
            txtSidesB.Text = "";
            txtSidesC.Text = "";
            txtSidesD.Text = "";
            txtAngle.Text = "";
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
        //Grafica la figura
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
            vertices[0].X = shapeCenter.X - ((sideA/2)*sf);
            vertices[0].Y = picCanvas.Height-(10*sf);
            //Punto B
            vertices[1].X = shapeCenter.X + ((sideA / 2)*sf);
            vertices[1].Y = vertices[0].Y;
            //Calcula la ubicacion del punto C, usando el lado y angulo
            float externalAngle = (180 - angle) * (float)(Math.PI / 180);//Primero calcula el angulo externo y pasa a radianes
            vertices[2].X = (float)(vertices[1].X + (Math.Cos(externalAngle))*sf); 
            vertices[2].Y = (float)(vertices[1].Y + (Math.Sin(externalAngle))*sf);
            //Calcula el valor del ángulo opuesto al que tenemos con ley de cosenos a la inversa
            float angleOpposite = (float)(Math.Acos(
                (Math.Pow(diag, 2) - Math.Pow(sideC, 2) - Math.Pow(sideD, 2)) /
                (-2 * sideC * sideD)
                ));
            //Ahora, ese angulo y la diagonal permiten hacer ley de senos y despejar el angulo interno al punto D
            float ang = (float)((angle * Math.PI) / 180);
            float angleC = (float)(((sideA * Math.Sin(ang)) + (sideD * Math.Sin(angleOpposite))) / diag);
            //Con eso se dibuja el último punto
            vertices[3].X = (float)(vertices[2].X - (Math.Cos(angleC)*sf));
            vertices[3].Y = (float)(vertices[2].Y + (Math.Sin(angleC)*sf));
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
