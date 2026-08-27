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
            lblGenInformesFacturacion.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenInformesFacturacion.ForeColor = Color.White;
            lblGenInformesFacturacion.Location = new Point(15, 21);
            lblGenInformesFacturacion.Name = "lblGenInformesFacturacion";
            lblGenInformesFacturacion.Size = new Size(719, 45);
            lblGenInformesFacturacion.TabIndex = 0;
            lblGenInformesFacturacion.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // lblSeleccioneInforme
            // 
            lblSeleccioneInforme.AutoSize = true;
            lblSeleccioneInforme.Font = new Font("Segoe UI", 11F);
            lblSeleccioneInforme.ForeColor = Color.White;
            lblSeleccioneInforme.Location = new Point(53, 101);
            lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            lblSeleccioneInforme.Size = new Size(152, 20);
            lblSeleccioneInforme.TabIndex = 1;
            lblSeleccioneInforme.Text = "Seleccione el Informe";
            // 
            // cmbSeleccioneInforme
            // 
            cmbSeleccioneInforme.FormattingEnabled = true;
            cmbSeleccioneInforme.Location = new Point(211, 98);
            cmbSeleccioneInforme.Name = "cmbSeleccioneInforme";
            cmbSeleccioneInforme.Size = new Size(121, 23);
            cmbSeleccioneInforme.TabIndex = 2;
            // 
            // lblOrdenarPor
            // 
            lblOrdenarPor.AutoSize = true;
            lblOrdenarPor.Font = new Font("Segoe UI", 11F);
            lblOrdenarPor.ForeColor = Color.White;
            lblOrdenarPor.Location = new Point(355, 101);
            lblOrdenarPor.Name = "lblOrdenarPor";
            lblOrdenarPor.Size = new Size(93, 20);
            lblOrdenarPor.TabIndex = 3;
            lblOrdenarPor.Text = "Ordenar por:";
            // 
            // cmbOrdenarPor
            // 
            cmbOrdenarPor.FormattingEnabled = true;
            cmbOrdenarPor.Location = new Point(454, 98);
            cmbOrdenarPor.Name = "cmbOrdenarPor";
            cmbOrdenarPor.Size = new Size(121, 23);
            cmbOrdenarPor.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 11F);
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(53, 142);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(87, 20);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(211, 134);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(121, 23);
            dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(454, 136);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(121, 23);
            dtpFechaFinal.TabIndex = 8;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new Font("Segoe UI", 11F);
            lblFechaFinal.ForeColor = Color.White;
            lblFechaFinal.Location = new Point(355, 140);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(82, 20);
            lblFechaFinal.TabIndex = 7;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // rbEnPantalla
            // 
            rbEnPantalla.AutoSize = true;
            rbEnPantalla.Font = new Font("Segoe UI", 11F);
            rbEnPantalla.Location = new Point(214, 203);
            rbEnPantalla.Name = "rbEnPantalla";
            rbEnPantalla.Size = new Size(101, 24);
            rbEnPantalla.TabIndex = 9;
            rbEnPantalla.TabStop = true;
            rbEnPantalla.Text = "En pantalla";
            rbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            rbPDF.AutoSize = true;
            rbPDF.Font = new Font("Segoe UI", 11F);
            rbPDF.Location = new Point(321, 203);
            rbPDF.Name = "rbPDF";
            rbPDF.Size = new Size(53, 24);
            rbPDF.TabIndex = 10;
            rbPDF.TabStop = true;
            rbPDF.Text = "PDF";
            rbPDF.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            rbExcel.AutoSize = true;
            rbExcel.Font = new Font("Segoe UI", 11F);
            rbExcel.Location = new Point(386, 203);
            rbExcel.Name = "rbExcel";
            rbExcel.Size = new Size(61, 24);
            rbExcel.TabIndex = 11;
            rbExcel.TabStop = true;
            rbExcel.Text = "Excel";
            rbExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = SystemColors.Highlight;
            btnGenerarInforme.FlatStyle = FlatStyle.Flat;
            btnGenerarInforme.Font = new Font("Segoe UI", 11F);
            btnGenerarInforme.ForeColor = Color.White;
            btnGenerarInforme.Location = new Point(184, 250);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(159, 32);
            btnGenerarInforme.TabIndex = 12;
            btnGenerarInforme.Text = "GENERAR INFORME";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Highlight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(397, 250);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 32);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            BackColor = Color.FromArgb(0, 0, 64);
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
            ForeColor = Color.White;
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