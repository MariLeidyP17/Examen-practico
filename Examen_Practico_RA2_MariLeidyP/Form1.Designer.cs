namespace Examen_Practico_RA2_MariLeidyP
{
    partial class Form1
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Teléfono = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.Rdb_Femenino = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_Maestro = new System.Windows.Forms.Label();
            this.txt_maestro = new System.Windows.Forms.TextBox();
            this.lbl_seccion = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.cmb_curso = new System.Windows.Forms.ComboBox();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.Dvg_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(386, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(241, 21);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Formulario Estudiantes";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricula.Location = new System.Drawing.Point(12, 74);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(54, 15);
            this.lbl_Matricula.TabIndex = 1;
            this.lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 109);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(46, 15);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(12, 149);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(53, 15);
            this.lbl_Direccion.TabIndex = 3;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Teléfono
            // 
            this.lbl_Teléfono.AutoSize = true;
            this.lbl_Teléfono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teléfono.Location = new System.Drawing.Point(12, 189);
            this.lbl_Teléfono.Name = "lbl_Teléfono";
            this.lbl_Teléfono.Size = new System.Drawing.Size(49, 15);
            this.lbl_Teléfono.TabIndex = 4;
            this.lbl_Teléfono.Text = "Teléfono";
            // 
            // txt_matricula
            // 
            this.txt_matricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_matricula.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula.Location = new System.Drawing.Point(68, 67);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 21);
            this.txt_matricula.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(68, 106);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 21);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_telefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(68, 189);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 21);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_Direccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(68, 149);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 21);
            this.txt_Direccion.TabIndex = 9;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.Location = new System.Drawing.Point(185, 78);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(42, 15);
            this.lbl_Genero.TabIndex = 10;
            this.lbl_Genero.Text = "Género";
            // 
            // Rdb_Femenino
            // 
            this.Rdb_Femenino.AutoSize = true;
            this.Rdb_Femenino.BackColor = System.Drawing.Color.Thistle;
            this.Rdb_Femenino.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Femenino.Location = new System.Drawing.Point(233, 74);
            this.Rdb_Femenino.Name = "Rdb_Femenino";
            this.Rdb_Femenino.Size = new System.Drawing.Size(72, 19);
            this.Rdb_Femenino.TabIndex = 11;
            this.Rdb_Femenino.TabStop = true;
            this.Rdb_Femenino.Text = "Femenino";
            this.Rdb_Femenino.UseVisualStyleBackColor = false;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.BackColor = System.Drawing.Color.Thistle;
            this.Rdb_Masculino.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Masculino.Location = new System.Drawing.Point(233, 97);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(76, 19);
            this.Rdb_Masculino.TabIndex = 12;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "Masculino";
            this.Rdb_Masculino.UseVisualStyleBackColor = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(185, 156);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(34, 15);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email";
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_mail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(223, 149);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 21);
            this.txt_mail.TabIndex = 14;
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso.Location = new System.Drawing.Point(188, 195);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(36, 15);
            this.lbl_curso.TabIndex = 15;
            this.lbl_curso.Text = "Curso";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Area.Location = new System.Drawing.Point(372, 73);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(70, 15);
            this.lbl_Area.TabIndex = 17;
            this.lbl_Area.Text = "Área Técnica";
            // 
            // lbl_Maestro
            // 
            this.lbl_Maestro.AutoSize = true;
            this.lbl_Maestro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maestro.Location = new System.Drawing.Point(372, 112);
            this.lbl_Maestro.Name = "lbl_Maestro";
            this.lbl_Maestro.Size = new System.Drawing.Size(84, 15);
            this.lbl_Maestro.TabIndex = 19;
            this.lbl_Maestro.Text = "Maestro Titular";
            // 
            // txt_maestro
            // 
            this.txt_maestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_maestro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maestro.Location = new System.Drawing.Point(471, 106);
            this.txt_maestro.Name = "txt_maestro";
            this.txt_maestro.Size = new System.Drawing.Size(100, 21);
            this.txt_maestro.TabIndex = 20;
            // 
            // lbl_seccion
            // 
            this.lbl_seccion.AutoSize = true;
            this.lbl_seccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seccion.Location = new System.Drawing.Point(372, 156);
            this.lbl_seccion.Name = "lbl_seccion";
            this.lbl_seccion.Size = new System.Drawing.Size(43, 15);
            this.lbl_seccion.TabIndex = 21;
            this.lbl_seccion.Text = "Sección";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Agregar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(675, 128);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(93, 41);
            this.btn_Agregar.TabIndex = 23;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Eliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(675, 181);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(93, 41);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Thistle;
            this.btn_guardar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(808, 182);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 41);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Thistle;
            this.btn_cerrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(744, 228);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(93, 41);
            this.btn_cerrar.TabIndex = 27;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Dgv_estudiantes
            // 
            this.Dgv_estudiantes.AllowUserToAddRows = false;
            this.Dgv_estudiantes.AllowUserToDeleteRows = false;
            this.Dgv_estudiantes.BackgroundColor = System.Drawing.Color.Thistle;
            this.Dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_estudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dvg_Matricula,
            this.Dgv_Nombre,
            this.Dgv_Direccion,
            this.Dgv_Telefono,
            this.Dgv_Género,
            this.Dgv_Email,
            this.Dgv_Curso,
            this.Dgv_Area,
            this.Dgv_Maestro,
            this.Dgv_Seccion});
            this.Dgv_estudiantes.GridColor = System.Drawing.Color.Gray;
            this.Dgv_estudiantes.Location = new System.Drawing.Point(-4, 319);
            this.Dgv_estudiantes.Name = "Dgv_estudiantes";
            this.Dgv_estudiantes.ReadOnly = true;
            this.Dgv_estudiantes.Size = new System.Drawing.Size(1005, 195);
            this.Dgv_estudiantes.TabIndex = 28;
            // 
            // cmb_Area
            // 
            this.cmb_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmb_Area.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Items.AddRange(new object[] {
            "Enfermeria",
            "Contabilidad ",
            "Gastronomia",
            "Informática",
            "Electricidad"});
            this.cmb_Area.Location = new System.Drawing.Point(469, 73);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(102, 23);
            this.cmb_Area.TabIndex = 29;
            // 
            // cmb_curso
            // 
            this.cmb_curso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmb_curso.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_curso.FormattingEnabled = true;
            this.cmb_curso.Items.AddRange(new object[] {
            "4TO",
            "5TO",
            "6TO"});
            this.cmb_curso.Location = new System.Drawing.Point(223, 190);
            this.cmb_curso.Name = "cmb_curso";
            this.cmb_curso.Size = new System.Drawing.Size(100, 23);
            this.cmb_curso.TabIndex = 30;
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmb_seccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmb_seccion.Location = new System.Drawing.Point(471, 149);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(100, 23);
            this.cmb_seccion.TabIndex = 31;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Thistle;
            this.btn_nuevo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(808, 128);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(93, 41);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Dvg_Matricula
            // 
            this.Dvg_Matricula.HeaderText = "Matricula";
            this.Dvg_Matricula.Name = "Dvg_Matricula";
            this.Dvg_Matricula.ReadOnly = true;
            // 
            // Dgv_Nombre
            // 
            this.Dgv_Nombre.HeaderText = "Nombre";
            this.Dgv_Nombre.Name = "Dgv_Nombre";
            this.Dgv_Nombre.ReadOnly = true;
            // 
            // Dgv_Direccion
            // 
            this.Dgv_Direccion.HeaderText = "Dirección";
            this.Dgv_Direccion.Name = "Dgv_Direccion";
            this.Dgv_Direccion.ReadOnly = true;
            // 
            // Dgv_Telefono
            // 
            this.Dgv_Telefono.HeaderText = "Teléfono";
            this.Dgv_Telefono.Name = "Dgv_Telefono";
            this.Dgv_Telefono.ReadOnly = true;
            // 
            // Dgv_Género
            // 
            this.Dgv_Género.HeaderText = "Género";
            this.Dgv_Género.Name = "Dgv_Género";
            this.Dgv_Género.ReadOnly = true;
            // 
            // Dgv_Email
            // 
            this.Dgv_Email.HeaderText = "Email";
            this.Dgv_Email.Name = "Dgv_Email";
            this.Dgv_Email.ReadOnly = true;
            // 
            // Dgv_Curso
            // 
            this.Dgv_Curso.HeaderText = "Curso";
            this.Dgv_Curso.Name = "Dgv_Curso";
            this.Dgv_Curso.ReadOnly = true;
            // 
            // Dgv_Area
            // 
            this.Dgv_Area.HeaderText = "Área Técnica";
            this.Dgv_Area.Name = "Dgv_Area";
            this.Dgv_Area.ReadOnly = true;
            // 
            // Dgv_Maestro
            // 
            this.Dgv_Maestro.HeaderText = "Maestro Titular";
            this.Dgv_Maestro.Name = "Dgv_Maestro";
            this.Dgv_Maestro.ReadOnly = true;
            // 
            // Dgv_Seccion
            // 
            this.Dgv_Seccion.HeaderText = "Sección";
            this.Dgv_Seccion.Name = "Dgv_Seccion";
            this.Dgv_Seccion.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 543);
            this.Controls.Add(this.cmb_seccion);
            this.Controls.Add(this.cmb_curso);
            this.Controls.Add(this.cmb_Area);
            this.Controls.Add(this.Dgv_estudiantes);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_seccion);
            this.Controls.Add(this.txt_maestro);
            this.Controls.Add(this.lbl_Maestro);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.Rdb_Masculino);
            this.Controls.Add(this.Rdb_Femenino);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_Teléfono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_estudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Teléfono;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.RadioButton Rdb_Femenino;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Label lbl_Maestro;
        private System.Windows.Forms.TextBox txt_maestro;
        private System.Windows.Forms.Label lbl_seccion;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView Dgv_estudiantes;
        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.ComboBox cmb_curso;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvg_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Maestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Seccion;
    }
}

