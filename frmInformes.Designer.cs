namespace TIA1
{
    partial class frmInformes
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
            lblGenInformesFacturacion = new Label();
            lblSeleccioneInforme = new Label();
            cmbSeleccioneInforme = new ComboBox();
            lblOrdenarPor = new Label();
            cmbOrdenarPor = new ComboBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            lblFechaFinal = new Label();
            rbEnPantalla = new RadioButton();
            rbPDF = new RadioButton();
            rbExcel = new RadioButton();
            btnGenerarInforme = new Button();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblGenInformesFacturacion
            // 
            lblGenInformesFacturacion.AutoSize = true;
            lblGenInformesFacturacion.Font = new Font("Segoe UI", 24F);
            lblGenInformesFacturacion.Location = new Point(36, 22);
            lblGenInformesFacturacion.Name = "lblGenInformesFacturacion";
            lblGenInformesFacturacion.Size = new Size(678, 45);
            lblGenInformesFacturacion.TabIndex = 0;
            lblGenInformesFacturacion.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // lblSeleccioneInforme
            // 
            lblSeleccioneInforme.AutoSize = true;
            lblSeleccioneInforme.Location = new Point(53, 101);
            lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            lblSeleccioneInforme.Size = new Size(120, 15);
            lblSeleccioneInforme.TabIndex = 1;
            lblSeleccioneInforme.Text = "Seleccione el Informe";
            // 
            // cmbSeleccioneInforme
            // 
            cmbSeleccioneInforme.FormattingEnabled = true;
            cmbSeleccioneInforme.Location = new Point(186, 98);
            cmbSeleccioneInforme.Name = "cmbSeleccioneInforme";
            cmbSeleccioneInforme.Size = new Size(121, 23);
            cmbSeleccioneInforme.TabIndex = 2;
            // 
            // lblOrdenarPor
            // 
            lblOrdenarPor.AutoSize = true;
            lblOrdenarPor.Location = new Point(355, 101);
            lblOrdenarPor.Name = "lblOrdenarPor";
            lblOrdenarPor.Size = new Size(74, 15);
            lblOrdenarPor.TabIndex = 3;
            lblOrdenarPor.Text = "Ordenar por:";
            // 
            // cmbOrdenarPor
            // 
            cmbOrdenarPor.FormattingEnabled = true;
            cmbOrdenarPor.Location = new Point(436, 98);
            cmbOrdenarPor.Name = "cmbOrdenarPor";
            cmbOrdenarPor.Size = new Size(121, 23);
            cmbOrdenarPor.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(53, 142);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(186, 134);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(121, 23);
            dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(436, 136);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(121, 23);
            dtpFechaFinal.TabIndex = 8;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(355, 140);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(66, 15);
            lblFechaFinal.TabIndex = 7;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // rbEnPantalla
            // 
            rbEnPantalla.AutoSize = true;
            rbEnPantalla.Location = new Point(214, 203);
            rbEnPantalla.Name = "rbEnPantalla";
            rbEnPantalla.Size = new Size(83, 19);
            rbEnPantalla.TabIndex = 9;
            rbEnPantalla.TabStop = true;
            rbEnPantalla.Text = "En pantalla";
            rbEnPantalla.UseVisualStyleBackColor = true;
            rbEnPantalla.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbPDF
            // 
            rbPDF.AutoSize = true;
            rbPDF.Location = new Point(316, 203);
            rbPDF.Name = "rbPDF";
            rbPDF.Size = new Size(46, 19);
            rbPDF.TabIndex = 10;
            rbPDF.TabStop = true;
            rbPDF.Text = "PDF";
            rbPDF.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            rbExcel.AutoSize = true;
            rbExcel.Location = new Point(386, 203);
            rbExcel.Name = "rbExcel";
            rbExcel.Size = new Size(51, 19);
            rbExcel.TabIndex = 11;
            rbExcel.TabStop = true;
            rbExcel.Text = "Excel";
            rbExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(184, 250);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(140, 23);
            btnGenerarInforme.TabIndex = 12;
            btnGenerarInforme.Text = "GENERAR INFORME";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(395, 254);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(678, 209);
            dataGridView1.TabIndex = 14;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 520);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarInforme);
            Controls.Add(rbExcel);
            Controls.Add(rbPDF);
            Controls.Add(rbEnPantalla);
            Controls.Add(dtpFechaFinal);
            Controls.Add(lblFechaFinal);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(cmbOrdenarPor);
            Controls.Add(lblOrdenarPor);
            Controls.Add(cmbSeleccioneInforme);
            Controls.Add(lblSeleccioneInforme);
            Controls.Add(lblGenInformesFacturacion);
            Name = "frmInformes";
            Text = "Generador de Informes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenInformesFacturacion;
        private Label lblSeleccioneInforme;
        private ComboBox cmbSeleccioneInforme;
        private Label lblOrdenarPor;
        private ComboBox cmbOrdenarPor;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFinal;
        private Label lblFechaFinal;
        private RadioButton rbEnPantalla;
        private RadioButton rbPDF;
        private RadioButton rbExcel;
        private Button btnGenerarInforme;
        private Button btnSalir;
        private DataGridView dataGridView1;
    }
}