namespace DibujosTransformacionesFigGeometricas
{
    partial class FrmPentagono
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
            this.grbEscalar = new System.Windows.Forms.GroupBox();
            this.tckScale = new System.Windows.Forms.TrackBar();
            this.grbGirar = new System.Windows.Forms.GroupBox();
            this.btnRotateAHour = new System.Windows.Forms.Button();
            this.btnRotateHour = new System.Windows.Forms.Button();
            this.lblAntihour = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
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
            this.lblSides = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.grbEscalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckScale)).BeginInit();
            this.grbGirar.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grnProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEscalar
            // 
            this.grbEscalar.Controls.Add(this.tckScale);
            this.grbEscalar.Location = new System.Drawing.Point(62, 135);
            this.grbEscalar.Name = "grbEscalar";
            this.grbEscalar.Size = new System.Drawing.Size(360, 132);
            this.grbEscalar.TabIndex = 28;
            this.grbEscalar.TabStop = false;
            this.grbEscalar.Text = "Escalar";
            // 
            // tckScale
            // 
            this.tckScale.Location = new System.Drawing.Point(36, 33);
            this.tckScale.Minimum = 1;
            this.tckScale.Name = "tckScale";
            this.tckScale.Size = new System.Drawing.Size(277, 69);
            this.tckScale.TabIndex = 0;
            this.tckScale.Value = 1;
            this.tckScale.Scroll += new System.EventHandler(this.tckScale_Scroll);
            // 
            // grbGirar
            // 
            this.grbGirar.Controls.Add(this.btnRotateAHour);
            this.grbGirar.Controls.Add(this.btnRotateHour);
            this.grbGirar.Controls.Add(this.lblAntihour);
            this.grbGirar.Controls.Add(this.lblHour);
            this.grbGirar.Location = new System.Drawing.Point(433, 39);
            this.grbGirar.Name = "grbGirar";
            this.grbGirar.Size = new System.Drawing.Size(128, 206);
            this.grbGirar.TabIndex = 27;
            this.grbGirar.TabStop = false;
            this.grbGirar.Text = "Rotar";
            // 
            // btnRotateAHour
            // 
            this.btnRotateAHour.Location = new System.Drawing.Point(10, 129);
            this.btnRotateAHour.Name = "btnRotateAHour";
            this.btnRotateAHour.Size = new System.Drawing.Size(90, 35);
            this.btnRotateAHour.TabIndex = 3;
            this.btnRotateAHour.Text = "10°";
            this.btnRotateAHour.UseVisualStyleBackColor = true;
            this.btnRotateAHour.Click += new System.EventHandler(this.btnRotateAHour_Click);
            // 
            // btnRotateHour
            // 
            this.btnRotateHour.Location = new System.Drawing.Point(10, 68);
            this.btnRotateHour.Name = "btnRotateHour";
            this.btnRotateHour.Size = new System.Drawing.Size(90, 35);
            this.btnRotateHour.TabIndex = 2;
            this.btnRotateHour.Text = "10°";
            this.btnRotateHour.UseVisualStyleBackColor = true;
            this.btnRotateHour.Click += new System.EventHandler(this.btnRotateHour_Click);
            // 
            // lblAntihour
            // 
            this.lblAntihour.AutoSize = true;
            this.lblAntihour.Location = new System.Drawing.Point(6, 106);
            this.lblAntihour.Name = "lblAntihour";
            this.lblAntihour.Size = new System.Drawing.Size(94, 20);
            this.lblAntihour.TabIndex = 1;
            this.lblAntihour.Text = "Anti-Horario";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(2, 36);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(61, 20);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Horario";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbCanvas.Location = new System.Drawing.Point(575, 40);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbCanvas.Size = new System.Drawing.Size(526, 496);
            this.grbCanvas.TabIndex = 26;
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
            this.grnProcess.Location = new System.Drawing.Point(62, 267);
            this.grnProcess.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grnProcess.Name = "grnProcess";
            this.grnProcess.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grnProcess.Size = new System.Drawing.Size(499, 117);
            this.grnProcess.TabIndex = 23;
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
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            this.btnReset.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbOutputs.Location = new System.Drawing.Point(62, 394);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbOutputs.Size = new System.Drawing.Size(499, 142);
            this.grbOutputs.TabIndex = 24;
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
            this.txtPerimeter.Location = new System.Drawing.Point(110, 37);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(295, 26);
            this.txtPerimeter.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtArea.Location = new System.Drawing.Point(110, 93);
            this.txtArea.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(295, 26);
            this.txtArea.TabIndex = 1;
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.lblSides);
            this.grbInputs.Controls.Add(this.txtSide);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbInputs.Location = new System.Drawing.Point(62, 33);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbInputs.Size = new System.Drawing.Size(360, 94);
            this.grbInputs.TabIndex = 25;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSides.Location = new System.Drawing.Point(19, 45);
            this.lblSides.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(62, 20);
            this.lblSides.TabIndex = 0;
            this.lblSides.Text = "Lado(l):";
            // 
            // txtSide
            // 
            this.txtSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSide.Location = new System.Drawing.Point(169, 42);
            this.txtSide.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(170, 26);
            this.txtSide.TabIndex = 4;
            // 
            // FrmPentagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 568);
            this.Controls.Add(this.grbEscalar);
            this.Controls.Add(this.grbGirar);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grnProcess);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.KeyPreview = true;
            this.Name = "FrmPentagono";
            this.Text = "FrmPentagono";
            this.Load += new System.EventHandler(this.FrmPentagono_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPentagono_KeyUp);
            this.grbEscalar.ResumeLayout(false);
            this.grbEscalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckScale)).EndInit();
            this.grbGirar.ResumeLayout(false);
            this.grbGirar.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grnProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEscalar;
        private System.Windows.Forms.TrackBar tckScale;
        private System.Windows.Forms.GroupBox grbGirar;
        private System.Windows.Forms.Button btnRotateAHour;
        private System.Windows.Forms.Button btnRotateHour;
        private System.Windows.Forms.Label lblAntihour;
        private System.Windows.Forms.Label lblHour;
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
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.TextBox txtSide;
    }
}