﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private PointF shapeCenter;
        private PointF[] vertices;//Puntos del rombo
        private PointF[] distances;
        public Rombo()
        {
            diagD = 0.0f;
            diagd = 0.0f;
            side = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            shapeCenter = new PointF(0,0);
            vertices = new PointF[4]; //Inicializa el arreglo de puntos
            distances = new PointF[4];
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
            shapeCenter = new PointF(0,0);
            vertices = new PointF[4]; //Reinicializa el arreglo de puntos
            distances = new PointF[4];
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
            //Calcula y guarda el punto central de la figura
            Point center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);
            shapeCenter.X = center.X;
            shapeCenter.Y= center.Y;
            //Primero calcula la mitad de la diagonal menor
            float diagSm = (float)Math.Sqrt(Math.Pow(side, 2) - Math.Pow(diagD / 2, 2));
            MessageBox.Show("Diagonal menor mitad: " + diagSm.ToString());
            //Dibuja los 2 primeros puntos a partir de la diagonal mayor.
            vertices[0] = new PointF(center.X + ((diagD / 2) * sf), center.Y);
            vertices[1] = new PointF(center.X, center.Y + (diagSm * sf));
            vertices[2] = new PointF(center.X - ((diagD / 2) * sf), center.Y);
            vertices[3] = new PointF(center.X, center.Y - (diagSm*sf));
            //Dibuja el rombo
            mGraph.DrawPolygon(mPen, vertices);
            //Guarda las distancias
            for (int i = 0; i < vertices.Length; i++)
            {
                distances[i]=new PointF(vertices[i].X - shapeCenter.X, vertices[i].Y - shapeCenter.Y);
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
            PointF[] scaledVertix=new PointF[4];
            //Cambia las distancias a que están los puntos del centro de la figura
            for(int i = 0;i < scaledVertix.Length;i++)
            {
                scaledVertix[i].X = shapeCenter.X + (distances[i].X * scaleFactor);
                scaledVertix[i].Y = shapeCenter.Y + (distances[i].Y*scaleFactor);
            }
            mGraph.DrawPolygon(mPen, scaledVertix);
        }

        public void rotate(String direction,PictureBox picCanvas)
        {
            //Prepara los elementos gráficos
            picCanvas.Refresh();
            mPen = new Pen(Color.Black, 2);
            mGraph = picCanvas.CreateGraphics();

            float angle = (float)(Math.PI / 18);//Gira un ángulo de 10 grados
            if(direction=="antihourly")
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
