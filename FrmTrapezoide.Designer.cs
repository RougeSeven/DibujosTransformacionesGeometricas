namespace DibujosTransformacionesFigGeometricas
{
    partial class FrmTrapezoide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grnProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblSidesC = new System.Windows.Forms.Label();
            this.txtSidesC = new System.Windows.Forms.TextBox();
            this.lblSidesB = new System.Windows.Forms.Label();
            this.txtSidesB = new System.Windows.Forms.TextBox();
            this.lblSidesA = new System.Windows.Forms.Label();
            this.lblSidesD = new System.Windows.Forms.Label();
            this.txtSidesA = new System.Windows.Forms.TextBox();
            this.txtSidesD = new System.Windows.Forms.TextBox();
            this.grbGirar = new System.Windows.Forms.GroupBox();
            this.btnRotateAHour = new System.Windows.Forms.Button();
            this.btnRotateHour = new System.Windows.Forms.Button();
            this.lblAntihour = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.grbEscalar = new System.Windows.Forms.GroupBox();
            this.tckScale = new System.Windows.Forms.TrackBar();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grnProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.grbGirar.SuspendLayout();
            this.grbEscalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckScale)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Enabled = false;
            this.grbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbCanvas.Location = new System.Drawing.Point(619, 31);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbCanvas.Size = new System.Drawing.Size(526, 496);
            this.grbCanvas.TabIndex = 36;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.Location = new System.Drawing.Point(27, 38);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(485, 435);
            this.picCanvas.TabIndex = 5;
            this.picCanvas.TabStop = false;
            // 
            // grnProcess
            // 
            this.grnProcess.Controls.Add(this.btnExit);
            this.grnProcess.Controls.Add(this.btnCalculate);
            this.grnProcess.Controls.Add(this.btnReset);
            this.grnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grnProcess.Location = new System.Drawing.Point(16, 265);
            this.grnProcess.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grnProcess.Name = "grnProcess";
            this.grnProcess.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grnProcess.Size = new System.Drawing.Size(514, 117);
            this.grnProcess.TabIndex = 33;
            this.grnProcess.TabStop = false;
            this.grnProcess.Text = "Opciones";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExit.Location = new System.Drawing.Point(338, 48);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.close);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCalculate.Location = new System.Drawing.Point(23, 48);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.calculate);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReset.Location = new System.Drawing.Point(186, 48);
            this.btnReset.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Borrar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.reset);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbOutputs.Location = new System.Drawing.Point(16, 392);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbOutputs.Size = new System.Drawing.Size(353, 142);
            this.grbOutputs.TabIndex = 34;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Resultados";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPerimeter.Location = new System.Drawing.Point(14, 43);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(77, 20);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblArea.Location = new System.Drawing.Point(14, 93);
            this.lblArea.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPerimeter.Location = new System.Drawing.Point(91, 40);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(142, 26);
            this.txtPerimeter.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtArea.Location = new System.Drawing.Point(74, 93);
            this.txtArea.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(159, 26);
            this.txtArea.TabIndex = 1;
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtAngle);
            this.grbInputs.Controls.Add(this.lblAngle);
            this.grbInputs.Controls.Add(this.lblSidesC);
            this.grbInputs.Controls.Add(this.txtSidesC);
            this.grbInputs.Controls.Add(this.lblSidesB);
            this.grbInputs.Controls.Add(this.txtSidesB);
            this.grbInputs.Controls.Add(this.lblSidesA);
            this.grbInputs.Controls.Add(this.lblSidesD);
            this.grbInputs.Controls.Add(this.txtSidesA);
            this.grbInputs.Controls.Add(this.txtSidesD);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbInputs.Location = new System.Drawing.Point(16, 31);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbInputs.Size = new System.Drawing.Size(403, 212);
            this.grbInputs.TabIndex = 35;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtAngle
            // 
            this.txtAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtAngle.Location = new System.Drawing.Point(265, 65);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(111, 26);
            this.txtAngle.TabIndex = 10;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAngle.Location = new System.Drawing.Point(261, 29);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(122, 20);
            this.lblAngle.TabIndex = 9;
            this.lblAngle.Text = "Angulo(ab) en °:";
            // 
            // lblSidesC
            // 
            this.lblSidesC.AutoSize = true;
            this.lblSidesC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSidesC.Location = new System.Drawing.Point(30, 109);
            this.lblSidesC.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSidesC.Name = "lblSidesC";
            this.lblSidesC.Size = new System.Drawing.Size(67, 20);
            this.lblSidesC.TabIndex = 7;
            this.lblSidesC.Text = "Lado(c):";
            // 
            // txtSidesC
            // 
            this.txtSidesC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSidesC.Location = new System.Drawing.Point(122, 109);
            this.txtSidesC.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSidesC.Name = "txtSidesC";
            this.txtSidesC.Size = new System.Drawing.Size(111, 26);
            this.txtSidesC.TabIndex = 8;
            // 
            // lblSidesB
            // 
            this.lblSidesB.AutoSize = true;
            this.lblSidesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSidesB.Location = new System.Drawing.Point(30, 71);
            this.lblSidesB.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSidesB.Name = "lblSidesB";
            this.lblSidesB.Size = new System.Drawing.Size(68, 20);
            this.lblSidesB.TabIndex = 5;
            this.lblSidesB.Text = "Lado(b):";
            // 
            // txtSidesB
            // 
            this.txtSidesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSidesB.Location = new System.Drawing.Point(122, 68);
            this.txtSidesB.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSidesB.Name = "txtSidesB";
            this.txtSidesB.Size = new System.Drawing.Size(111, 26);
            this.txtSidesB.TabIndex = 6;
            // 
            // lblSidesA
            // 
            this.lblSidesA.AutoSize = true;
            this.lblSidesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSidesA.Location = new System.Drawing.Point(30, 29);
            this.lblSidesA.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSidesA.Name = "lblSidesA";
            this.lblSidesA.Size = new System.Drawing.Size(68, 20);
            this.lblSidesA.TabIndex = 0;
            this.lblSidesA.Text = "Lado(a):";
            // 
            // lblSidesD
            // 
            this.lblSidesD.AutoSize = true;
            this.lblSidesD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSidesD.Location = new System.Drawing.Point(32, 147);
            this.lblSidesD.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSidesD.Name = "lblSidesD";
            this.lblSidesD.Size = new System.Drawing.Size(68, 20);
            this.lblSidesD.TabIndex = 1;
            this.lblSidesD.Text = "Lado(d):";
            // 
            // txtSidesA
            // 
            this.txtSidesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSidesA.Location = new System.Drawing.Point(122, 29);
            this.txtSidesA.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSidesA.Name = "txtSidesA";
            this.txtSidesA.Size = new System.Drawing.Size(111, 26);
            this.txtSidesA.TabIndex = 4;
            // 
            // txtSidesD
            // 
            this.txtSidesD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSidesD.Location = new System.Drawing.Point(122, 145);
            this.txtSidesD.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSidesD.Name = "txtSidesD";
            this.txtSidesD.Size = new System.Drawing.Size(111, 26);
            this.txtSidesD.TabIndex = 3;
            // 
            // grbGirar
            // 
            this.grbGirar.Controls.Add(this.btnRotateAHour);
            this.grbGirar.Controls.Add(this.btnRotateHour);
            this.grbGirar.Controls.Add(this.lblAntihour);
            this.grbGirar.Controls.Add(this.lblHour);
            this.grbGirar.Location = new System.Drawing.Point(429, 43);
            this.grbGirar.Name = "grbGirar";
            this.grbGirar.Size = new System.Drawing.Size(180, 200);
            this.grbGirar.TabIndex = 37;
            this.grbGirar.TabStop = false;
            this.grbGirar.Text = "Rotar";
            // 
            // btnRotateAHour
            // 
            this.btnRotateAHour.Location = new System.Drawing.Point(40, 129);
            this.btnRotateAHour.Name = "btnRotateAHour";
            this.btnRotateAHour.Size = new System.Drawing.Size(90, 35);
            this.btnRotateAHour.TabIndex = 3;
            this.btnRotateAHour.Text = "10°";
            this.btnRotateAHour.UseVisualStyleBackColor = true;
            // 
            // btnRotateHour
            // 
            this.btnRotateHour.Location = new System.Drawing.Point(40, 68);
            this.btnRotateHour.Name = "btnRotateHour";
            this.btnRotateHour.Size = new System.Drawing.Size(90, 35);
            this.btnRotateHour.TabIndex = 2;
            this.btnRotateHour.Text = "10°";
            this.btnRotateHour.UseVisualStyleBackColor = true;
            // 
            // lblAntihour
            // 
            this.lblAntihour.AutoSize = true;
            this.lblAntihour.Location = new System.Drawing.Point(36, 106);
            this.lblAntihour.Name = "lblAntihour";
            this.lblAntihour.Size = new System.Drawing.Size(94, 20);
            this.lblAntihour.TabIndex = 1;
            this.lblAntihour.Text = "Anti-Horario";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(48, 42);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(61, 20);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Horario";
            // 
            // grbEscalar
            // 
            this.grbEscalar.Controls.Add(this.tckScale);
            this.grbEscalar.Location = new System.Drawing.Point(397, 402);
            this.grbEscalar.Name = "grbEscalar";
            this.grbEscalar.Size = new System.Drawing.Size(184, 132);
            this.grbEscalar.TabIndex = 38;
            this.grbEscalar.TabStop = false;
            this.grbEscalar.Text = "Escalar";
            // 
            // tckScale
            // 
            this.tckScale.Location = new System.Drawing.Point(6, 33);
            this.tckScale.Minimum = 1;
            this.tckScale.Name = "tckScale";
            this.tckScale.Size = new System.Drawing.Size(172, 69);
            this.tckScale.TabIndex = 0;
            this.tckScale.Value = 1;
            // 
            // FrmTrapezoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 564);
            this.Controls.Add(this.grbEscalar);
            this.Controls.Add(this.grbGirar);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grnProcess);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.KeyPreview = true;
            this.Name = "FrmTrapezoide";
            this.Text = "FrmTrapezoide";
            this.Load += new System.EventHandler(this.FrmTrapezoide_Load);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grnProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbGirar.ResumeLayout(false);
            this.grbGirar.PerformLayout();
            this.grbEscalar.ResumeLayout(false);
            this.grbEscalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grnProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblSidesC;
        private System.Windows.Forms.TextBox txtSidesC;
        private System.Windows.Forms.Label lblSidesB;
        private System.Windows.Forms.TextBox txtSidesB;
        private System.Windows.Forms.Label lblSidesA;
        private System.Windows.Forms.Label lblSidesD;
        private System.Windows.Forms.TextBox txtSidesA;
        private System.Windows.Forms.TextBox txtSidesD;
        private System.Windows.Forms.GroupBox grbGirar;
        private System.Windows.Forms.Button btnRotateAHour;
        private System.Windows.Forms.Button btnRotateHour;
        private System.Windows.Forms.Label lblAntihour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.GroupBox grbEscalar;
        private System.Windows.Forms.TrackBar tckScale;
    }
}