namespace Classroom
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.radioButton1 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.textBoxHorario = new RJCodeAdvance.RJControls.RJTextBox();
            this.buttonAgendar = new RJCodeAdvance.RJControls.RJButton();
            this.comboBoxMaterias = new RJCodeAdvance.RJControls.RJComboBox();
            this.comboBoxAlumno = new RJCodeAdvance.RJControls.RJComboBox();
            this.datePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.labelNuevaClase = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxAsignatura = new RJCodeAdvance.RJControls.RJComboBox();
            this.labelPendiente = new System.Windows.Forms.Label();
            this.toggleButton = new RJCodeAdvance.RJControls.RJToggleButton();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.comboBoxAlumnos = new RJCodeAdvance.RJControls.RJComboBox();
            this.comboBoxType = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(502, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBoxHorario);
            this.panel1.Controls.Add(this.buttonAgendar);
            this.panel1.Controls.Add(this.comboBoxMaterias);
            this.panel1.Controls.Add(this.comboBoxAlumno);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.labelNuevaClase);
            this.panel1.Location = new System.Drawing.Point(523, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 250);
            this.panel1.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(198, 158);
            this.radioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton2.Size = new System.Drawing.Size(49, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "2H";
            this.radioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(143, 158);
            this.radioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton1.Size = new System.Drawing.Size(49, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1H";
            this.radioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxHorario
            // 
            this.textBoxHorario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHorario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxHorario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxHorario.BorderRadius = 0;
            this.textBoxHorario.BorderSize = 2;
            this.textBoxHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxHorario.Location = new System.Drawing.Point(8, 153);
            this.textBoxHorario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHorario.Multiline = false;
            this.textBoxHorario.Name = "textBoxHorario";
            this.textBoxHorario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxHorario.PasswordChar = false;
            this.textBoxHorario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxHorario.PlaceholderText = "";
            this.textBoxHorario.Size = new System.Drawing.Size(128, 31);
            this.textBoxHorario.TabIndex = 5;
            this.textBoxHorario.Texts = "Horario";
            this.textBoxHorario.UnderlinedStyle = false;
            // 
            // buttonAgendar
            // 
            this.buttonAgendar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAgendar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAgendar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAgendar.BorderRadius = 0;
            this.buttonAgendar.BorderSize = 0;
            this.buttonAgendar.FlatAppearance.BorderSize = 0;
            this.buttonAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgendar.ForeColor = System.Drawing.Color.White;
            this.buttonAgendar.Location = new System.Drawing.Point(61, 192);
            this.buttonAgendar.Name = "buttonAgendar";
            this.buttonAgendar.Size = new System.Drawing.Size(150, 40);
            this.buttonAgendar.TabIndex = 4;
            this.buttonAgendar.Text = "Agendar";
            this.buttonAgendar.TextColor = System.Drawing.Color.White;
            this.buttonAgendar.UseVisualStyleBackColor = false;
            this.buttonAgendar.Click += new System.EventHandler(this.buttonAgendar_Click);
            // 
            // comboBoxMaterias
            // 
            this.comboBoxMaterias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxMaterias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxMaterias.BorderSize = 1;
            this.comboBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxMaterias.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxMaterias.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxMaterias.Items.AddRange(new object[] {
            "Informatica 3er año",
            "Particular",
            "Sistemas de Desarollo 5to",
            "Sistemas de Desarollo 6to",
            "Proyecto Final 6to",
            "Informatica UNR",
            "AyED UTN"});
            this.comboBoxMaterias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxMaterias.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxMaterias.Location = new System.Drawing.Point(8, 116);
            this.comboBoxMaterias.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxMaterias.Name = "comboBoxMaterias";
            this.comboBoxMaterias.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxMaterias.Size = new System.Drawing.Size(254, 30);
            this.comboBoxMaterias.TabIndex = 3;
            this.comboBoxMaterias.Texts = "Asignatura";
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxAlumno.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxAlumno.BorderSize = 1;
            this.comboBoxAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxAlumno.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxAlumno.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxAlumno.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxAlumno.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxAlumno.Location = new System.Drawing.Point(8, 80);
            this.comboBoxAlumno.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxAlumno.Size = new System.Drawing.Size(254, 30);
            this.comboBoxAlumno.TabIndex = 2;
            this.comboBoxAlumno.Texts = "Alumno";
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker.BorderSize = 0;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker.Location = new System.Drawing.Point(8, 39);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(254, 35);
            this.datePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker.TabIndex = 1;
            this.datePicker.TextColor = System.Drawing.Color.White;
            // 
            // labelNuevaClase
            // 
            this.labelNuevaClase.AutoSize = true;
            this.labelNuevaClase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaClase.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelNuevaClase.Location = new System.Drawing.Point(72, 6);
            this.labelNuevaClase.Name = "labelNuevaClase";
            this.labelNuevaClase.Size = new System.Drawing.Size(129, 23);
            this.labelNuevaClase.TabIndex = 0;
            this.labelNuevaClase.Text = "Nueva Clase";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboBoxAsignatura);
            this.panel2.Controls.Add(this.labelPendiente);
            this.panel2.Controls.Add(this.toggleButton);
            this.panel2.Controls.Add(this.labelBuscar);
            this.panel2.Controls.Add(this.comboBoxAlumnos);
            this.panel2.Controls.Add(this.comboBoxType);
            this.panel2.Location = new System.Drawing.Point(523, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 170);
            this.panel2.TabIndex = 6;
            // 
            // comboBoxAsignatura
            // 
            this.comboBoxAsignatura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxAsignatura.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxAsignatura.BorderSize = 1;
            this.comboBoxAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxAsignatura.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxAsignatura.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxAsignatura.Items.AddRange(new object[] {
            "Todas las asignaturas",
            "Particular",
            "Informatica 3er año",
            "Sistemas de Desarollo 5to",
            "Sistemas de Desarollo 6to",
            "Proyecto Final 6to",
            "Informatica UNR",
            "AyED UTN"});
            this.comboBoxAsignatura.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxAsignatura.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxAsignatura.Location = new System.Drawing.Point(8, 109);
            this.comboBoxAsignatura.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxAsignatura.Name = "comboBoxAsignatura";
            this.comboBoxAsignatura.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxAsignatura.Size = new System.Drawing.Size(254, 30);
            this.comboBoxAsignatura.TabIndex = 9;
            this.comboBoxAsignatura.Texts = "Todas las asignaturas";
            this.comboBoxAsignatura.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxAsignatura_OnSelectedIndexChanged);
            // 
            // labelPendiente
            // 
            this.labelPendiente.AutoSize = true;
            this.labelPendiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendiente.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelPendiente.Location = new System.Drawing.Point(3, 142);
            this.labelPendiente.Name = "labelPendiente";
            this.labelPendiente.Size = new System.Drawing.Size(174, 21);
            this.labelPendiente.TabIndex = 8;
            this.labelPendiente.Text = "Solo pago pendiente";
            // 
            // toggleButton
            // 
            this.toggleButton.AutoSize = true;
            this.toggleButton.Location = new System.Drawing.Point(183, 143);
            this.toggleButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton.Size = new System.Drawing.Size(45, 22);
            this.toggleButton.TabIndex = 7;
            this.toggleButton.UseVisualStyleBackColor = true;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelBuscar.Location = new System.Drawing.Point(72, 5);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(137, 23);
            this.labelBuscar.TabIndex = 6;
            this.labelBuscar.Text = "Buscar Clases";
            // 
            // comboBoxAlumnos
            // 
            this.comboBoxAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxAlumnos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxAlumnos.BorderSize = 1;
            this.comboBoxAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxAlumnos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxAlumnos.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxAlumnos.Items.AddRange(new object[] {
            "Todos los alumnos"});
            this.comboBoxAlumnos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxAlumnos.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxAlumnos.Location = new System.Drawing.Point(8, 73);
            this.comboBoxAlumnos.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxAlumnos.Name = "comboBoxAlumnos";
            this.comboBoxAlumnos.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxAlumnos.Size = new System.Drawing.Size(254, 30);
            this.comboBoxAlumnos.TabIndex = 5;
            this.comboBoxAlumnos.Texts = "Todos los alumnos";
            this.comboBoxAlumnos.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxAlumnos_OnSelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxType.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxType.BorderSize = 1;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxType.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxType.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxType.Items.AddRange(new object[] {
            "Todas las clases",
            "Proximas clases",
            "Clases completas"});
            this.comboBoxType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxType.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxType.Location = new System.Drawing.Point(8, 37);
            this.comboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxType.Size = new System.Drawing.Size(254, 30);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.Texts = "Todas las clases";
            this.comboBoxType.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox3_OnSelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton buttonAgendar;
        private RJCodeAdvance.RJControls.RJComboBox comboBoxMaterias;
        private RJCodeAdvance.RJControls.RJComboBox comboBoxAlumno;
        private RJCodeAdvance.RJControls.RJDatePicker datePicker;
        private System.Windows.Forms.Label labelNuevaClase;
        private System.Windows.Forms.Label labelBuscar;
        private RJCodeAdvance.RJControls.RJComboBox comboBoxAlumnos;
        private RJCodeAdvance.RJControls.RJComboBox comboBoxType;
        private RJCodeAdvance.RJControls.RJRadioButton radioButton2;
        private RJCodeAdvance.RJControls.RJRadioButton radioButton1;
        private RJCodeAdvance.RJControls.RJTextBox textBoxHorario;
        private System.Windows.Forms.Label labelPendiente;
        private RJCodeAdvance.RJControls.RJToggleButton toggleButton;
        private RJCodeAdvance.RJControls.RJComboBox comboBoxAsignatura;
    }
}

