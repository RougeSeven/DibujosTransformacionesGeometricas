namespace DibujosTransformacionesFigGeometricas
{
    partial class FrmRomboide
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
            this.txtBases = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblBases = new System.Windows.Forms.Label();
            this.lblHieght = new System.Windows.Forms.Label();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
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
            this.grbCanvas.Location = new System.Drawing.Point(563, 17);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbCanvas.Size = new System.Drawing.Size(526, 496);
            this.grbCanvas.TabIndex = 28;
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
            this.grnProcess.Location = new System.Drawing.Point(5, 212);
            this.grnProcess.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grnProcess.Name = "grnProcess";
            this.grnProcess.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grnProcess.Size = new System.Drawing.Size(499, 117);
            this.grnProcess.TabIndex = 25;
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
            this.grbOutputs.Location = new System.Drawing.Point(5, 357);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbOutputs.Size = new System.Drawing.Size(324, 151);
            this.grbOutputs.TabIndex = 26;
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
            this.txtPerimeter.Location = new System.Drawing.Point(101, 37);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(202, 26);
            this.txtPerimeter.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtArea.Location = new System.Drawing.Point(101, 93);
            this.txtArea.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(202, 26);
            this.txtArea.TabIndex = 1;
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtBases);
            this.grbInputs.Controls.Add(this.lblBase);
            this.grbInputs.Controls.Add(this.lblBases);
            this.grbInputs.Controls.Add(this.lblHieght);
            this.grbInputs.Controls.Add(this.txtSides);
            this.grbInputs.Controls.Add(this.txtHeight);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbInputs.Location = new System.Drawing.Point(5, 5);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grbInputs.Size = new System.Drawing.Size(324, 182);
            this.grbInputs.TabIndex = 27;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtBases
            // 
            this.txtBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtBases.Location = new System.Drawing.Point(101, 85);
            this.txtBases.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtBases.Name = "txtBases";
            this.txtBases.Size = new System.Drawing.Size(202, 26);
            this.txtBases.TabIndex = 8;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBase.Location = new System.Drawing.Point(19, 85);
            this.lblBase.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(69, 20);
            this.lblBase.TabIndex = 7;
            this.lblBase.Text = "Base(b):";
            // 
            // lblBases
            // 
            this.lblBases.AutoSize = true;
            this.lblBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBases.Location = new System.Drawing.Point(19, 45);
            this.lblBases.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBases.Name = "lblBases";
            this.lblBases.Size = new System.Drawing.Size(68, 20);
            this.lblBases.TabIndex = 0;
            this.lblBases.Text = "Lado(a):";
            // 
            // lblHieght
            // 
            this.lblHieght.AutoSize = true;
            this.lblHieght.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblHieght.Location = new System.Drawing.Point(19, 129);
            this.lblHieght.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHieght.Name = "lblHieght";
            this.lblHieght.Size = new System.Drawing.Size(55, 20);
            this.lblHieght.TabIndex = 1;
            this.lblHieght.Text = "Altura:";
            // 
            // txtSides
            // 
            this.txtSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSides.Location = new System.Drawing.Point(101, 42);
            this.txtSides.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(202, 26);
            this.txtSides.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtHeight.Location = new System.Drawing.Point(101, 123);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(202, 26);
            this.txtHeight.TabIndex = 3;
            // 
            // grbGirar
            // 
            this.grbGirar.Controls.Add(this.btnRotateAHour);
            this.grbGirar.Controls.Add(this.btnRotateHour);
            this.grbGirar.Controls.Add(this.lblAntihour);
            this.grbGirar.Controls.Add(this.lblHour);
            this.grbGirar.Location = new System.Drawing.Point(343, 5);
            this.grbGirar.Name = "grbGirar";
            this.grbGirar.Size = new System.Drawing.Size(198, 182);
            this.grbGirar.TabIndex = 22;
            this.grbGirar.TabStop = false;
            this.grbGirar.Text = "Rotar";
            // 
            // btnRotateAHour
            // 
            this.btnRotateAHour.Location = new System.Drawing.Point(56, 129);
            this.btnRotateAHour.Name = "btnRotateAHour";
            this.btnRotateAHour.Size = new System.Drawing.Size(90, 35);
            this.btnRotateAHour.TabIndex = 3;
            this.btnRotateAHour.Text = "10°";
            this.btnRotateAHour.UseVisualStyleBackColor = true;
            this.btnRotateAHour.Click += new System.EventHandler(this.btnRotateAHour_Click);
            // 
            // btnRotateHour
            // 
            this.btnRotateHour.Location = new System.Drawing.Point(56, 68);
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
            this.lblAntihour.Location = new System.Drawing.Point(52, 106);
            this.lblAntihour.Name = "lblAntihour";
            this.lblAntihour.Size = new System.Drawing.Size(94, 20);
            this.lblAntihour.TabIndex = 1;
            this.lblAntihour.Text = "Anti-Horario";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(64, 42);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(61, 20);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Horario";
            // 
            // grbEscalar
            // 
            this.grbEscalar.Controls.Add(this.tckScale);
            this.grbEscalar.Location = new System.Drawing.Point(343, 358);
            this.grbEscalar.Name = "grbEscalar";
            this.grbEscalar.Size = new System.Drawing.Size(184, 132);
            this.grbEscalar.TabIndex = 29;
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
            this.tckScale.Scroll += new System.EventHandler(this.tckScale_Scroll);
            // 
            // FrmRomboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 522);
            this.Controls.Add(this.grbEscalar);
            this.Controls.Add(this.grbGirar);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grnProcess);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.KeyPreview = true;
            this.Name = "FrmRomboide";
            this.Text = "FrmRomboide";
            this.Load += new System.EventHandler(this.FrmRomboide_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmRombo_KeyUp);
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
        private System.Windows.Forms.TextBox txtBases;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblBases;
        private System.Windows.Forms.Label lblHieght;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox grbGirar;
        private System.Windows.Forms.Button btnRotateAHour;
        private System.Windows.Forms.Button btnRotateHour;
        private System.Windows.Forms.Label lblAntihour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.GroupBox grbEscalar;
        private System.Windows.Forms.TrackBar tckScale;
    }
}