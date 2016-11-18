namespace Visitas
{
    partial class Form1
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
            this.ControlTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientePanel = new System.Windows.Forms.Panel();
            this.datosVisitas = new System.Windows.Forms.Panel();
            this.listaVisitantesCheck = new System.Windows.Forms.DataGridView();
            this.datosPaciente = new System.Windows.Forms.Panel();
            this.horarioP = new System.Windows.Forms.TextBox();
            this.camaP = new System.Windows.Forms.TextBox();
            this.cedulaP = new System.Windows.Forms.TextBox();
            this.nombreP = new System.Windows.Forms.TextBox();
            this.ca = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.ce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPacientes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaPacientesAdmin = new System.Windows.Forms.ListBox();
            this.editPaciente = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelAddV = new System.Windows.Forms.Button();
            this.addV = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cedV = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.nombreV = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.horarioE = new System.Windows.Forms.TextBox();
            this.camaE = new System.Windows.Forms.TextBox();
            this.cedulaE = new System.Windows.Forms.TextBox();
            this.nombreE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addPacientePanel = new System.Windows.Forms.Panel();
            this.cancelP = new System.Windows.Forms.Button();
            this.addP = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.horarioA = new System.Windows.Forms.TextBox();
            this.camaA = new System.Windows.Forms.TextBox();
            this.cedulaA = new System.Windows.Forms.TextBox();
            this.nombreA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listaVisitantesAdd = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ControlTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pacientePanel.SuspendLayout();
            this.datosVisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVisitantesCheck)).BeginInit();
            this.datosPaciente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.editPaciente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addPacientePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVisitantesAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlTab
            // 
            this.ControlTab.Controls.Add(this.tabPage1);
            this.ControlTab.Controls.Add(this.tabPage2);
            this.ControlTab.Location = new System.Drawing.Point(13, 13);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.SelectedIndex = 0;
            this.ControlTab.Size = new System.Drawing.Size(1094, 644);
            this.ControlTab.TabIndex = 0;
            this.ControlTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.VisitaMod_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pacientePanel);
            this.tabPage1.Controls.Add(this.listaPacientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(835, 21);
            this.Buscar.MaxLength = 9;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(179, 22);
            this.Buscar.TabIndex = 3;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Pacientes";
            // 
            // pacientePanel
            // 
            this.pacientePanel.Controls.Add(this.label18);
            this.pacientePanel.Controls.Add(this.datosVisitas);
            this.pacientePanel.Controls.Add(this.datosPaciente);
            this.pacientePanel.Enabled = false;
            this.pacientePanel.Location = new System.Drawing.Point(27, 209);
            this.pacientePanel.Name = "pacientePanel";
            this.pacientePanel.Size = new System.Drawing.Size(1029, 403);
            this.pacientePanel.TabIndex = 1;
            this.pacientePanel.Visible = false;
            // 
            // datosVisitas
            // 
            this.datosVisitas.Controls.Add(this.listaVisitantesCheck);
            this.datosVisitas.Location = new System.Drawing.Point(320, 180);
            this.datosVisitas.Name = "datosVisitas";
            this.datosVisitas.Size = new System.Drawing.Size(537, 213);
            this.datosVisitas.TabIndex = 1;
            // 
            // listaVisitantesCheck
            // 
            this.listaVisitantesCheck.AllowUserToDeleteRows = false;
            this.listaVisitantesCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaVisitantesCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaVisitantesCheck.Location = new System.Drawing.Point(0, 0);
            this.listaVisitantesCheck.Name = "listaVisitantesCheck";
            this.listaVisitantesCheck.RowTemplate.Height = 24;
            this.listaVisitantesCheck.Size = new System.Drawing.Size(537, 213);
            this.listaVisitantesCheck.TabIndex = 1;
            this.listaVisitantesCheck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaVisitantesAdd_CellContentClick);
            // 
            // datosPaciente
            // 
            this.datosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datosPaciente.Controls.Add(this.horarioP);
            this.datosPaciente.Controls.Add(this.camaP);
            this.datosPaciente.Controls.Add(this.cedulaP);
            this.datosPaciente.Controls.Add(this.nombreP);
            this.datosPaciente.Controls.Add(this.ca);
            this.datosPaciente.Controls.Add(this.h);
            this.datosPaciente.Controls.Add(this.ce);
            this.datosPaciente.Controls.Add(this.label2);
            this.datosPaciente.Location = new System.Drawing.Point(320, 3);
            this.datosPaciente.Name = "datosPaciente";
            this.datosPaciente.Size = new System.Drawing.Size(537, 171);
            this.datosPaciente.TabIndex = 0;
            // 
            // horarioP
            // 
            this.horarioP.Location = new System.Drawing.Point(101, 133);
            this.horarioP.MaxLength = 9;
            this.horarioP.Name = "horarioP";
            this.horarioP.ReadOnly = true;
            this.horarioP.Size = new System.Drawing.Size(410, 22);
            this.horarioP.TabIndex = 9;
            // 
            // camaP
            // 
            this.camaP.Location = new System.Drawing.Point(101, 95);
            this.camaP.MaxLength = 9;
            this.camaP.Name = "camaP";
            this.camaP.ReadOnly = true;
            this.camaP.Size = new System.Drawing.Size(410, 22);
            this.camaP.TabIndex = 8;
            // 
            // cedulaP
            // 
            this.cedulaP.Location = new System.Drawing.Point(101, 56);
            this.cedulaP.MaxLength = 9;
            this.cedulaP.Name = "cedulaP";
            this.cedulaP.ReadOnly = true;
            this.cedulaP.Size = new System.Drawing.Size(410, 22);
            this.cedulaP.TabIndex = 7;
            // 
            // nombreP
            // 
            this.nombreP.Location = new System.Drawing.Point(101, 18);
            this.nombreP.MaxLength = 9;
            this.nombreP.Name = "nombreP";
            this.nombreP.ReadOnly = true;
            this.nombreP.Size = new System.Drawing.Size(410, 22);
            this.nombreP.TabIndex = 6;
            // 
            // ca
            // 
            this.ca.AutoSize = true;
            this.ca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ca.Location = new System.Drawing.Point(3, 91);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(65, 25);
            this.ca.TabIndex = 3;
            this.ca.Text = "Cama";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(3, 129);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(75, 25);
            this.h.TabIndex = 2;
            this.h.Text = "Horario";
            // 
            // ce
            // 
            this.ce.AutoSize = true;
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.Location = new System.Drawing.Point(3, 52);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(75, 25);
            this.ce.TabIndex = 1;
            this.ce.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // listaPacientes
            // 
            this.listaPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPacientes.FormattingEnabled = true;
            this.listaPacientes.ItemHeight = 25;
            this.listaPacientes.Location = new System.Drawing.Point(27, 57);
            this.listaPacientes.Name = "listaPacientes";
            this.listaPacientes.Size = new System.Drawing.Size(1029, 129);
            this.listaPacientes.TabIndex = 0;
            this.listaPacientes.SelectedIndexChanged += new System.EventHandler(this.listaPacientes_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listaPacientesAdmin);
            this.tabPage2.Controls.Add(this.addPacientePanel);
            this.tabPage2.Controls.Add(this.editPaciente);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1086, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Datos del paciente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(832, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar";
            // 
            // listaPacientesAdmin
            // 
            this.listaPacientesAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPacientesAdmin.FormattingEnabled = true;
            this.listaPacientesAdmin.ItemHeight = 25;
            this.listaPacientesAdmin.Location = new System.Drawing.Point(77, 63);
            this.listaPacientesAdmin.Name = "listaPacientesAdmin";
            this.listaPacientesAdmin.Size = new System.Drawing.Size(944, 129);
            this.listaPacientesAdmin.TabIndex = 0;
            this.listaPacientesAdmin.SelectedIndexChanged += new System.EventHandler(this.listaPacientes_SelectedIndexChanged);
            // 
            // editPaciente
            // 
            this.editPaciente.Controls.Add(this.label17);
            this.editPaciente.Controls.Add(this.listaVisitantesAdd);
            this.editPaciente.Controls.Add(this.panel1);
            this.editPaciente.Controls.Add(this.Eliminar);
            this.editPaciente.Controls.Add(this.cancelEdit);
            this.editPaciente.Controls.Add(this.Editar);
            this.editPaciente.Controls.Add(this.splitter2);
            this.editPaciente.Controls.Add(this.horarioE);
            this.editPaciente.Controls.Add(this.camaE);
            this.editPaciente.Controls.Add(this.cedulaE);
            this.editPaciente.Controls.Add(this.nombreE);
            this.editPaciente.Controls.Add(this.label11);
            this.editPaciente.Controls.Add(this.label12);
            this.editPaciente.Controls.Add(this.label13);
            this.editPaciente.Controls.Add(this.label14);
            this.editPaciente.Controls.Add(this.label15);
            this.editPaciente.Location = new System.Drawing.Point(16, 232);
            this.editPaciente.Name = "editPaciente";
            this.editPaciente.Size = new System.Drawing.Size(1074, 411);
            this.editPaciente.TabIndex = 16;
            this.editPaciente.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelAddV);
            this.panel1.Controls.Add(this.addV);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.cedV);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.nombreV);
            this.panel1.Location = new System.Drawing.Point(702, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 371);
            this.panel1.TabIndex = 17;
            // 
            // cancelAddV
            // 
            this.cancelAddV.FlatAppearance.BorderSize = 0;
            this.cancelAddV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddV.ForeColor = System.Drawing.Color.Firebrick;
            this.cancelAddV.Location = new System.Drawing.Point(199, 285);
            this.cancelAddV.Name = "cancelAddV";
            this.cancelAddV.Size = new System.Drawing.Size(104, 37);
            this.cancelAddV.TabIndex = 18;
            this.cancelAddV.Text = "Cancelar";
            this.cancelAddV.UseVisualStyleBackColor = true;
            this.cancelAddV.Click += new System.EventHandler(this.button2_Click);
            // 
            // addV
            // 
            this.addV.Enabled = false;
            this.addV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addV.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addV.Location = new System.Drawing.Point(27, 284);
            this.addV.Name = "addV";
            this.addV.Size = new System.Drawing.Size(104, 37);
            this.addV.TabIndex = 18;
            this.addV.Text = "Agregar";
            this.addV.UseVisualStyleBackColor = true;
            this.addV.Click += new System.EventHandler(this.agregarV_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 25);
            this.label16.TabIndex = 6;
            this.label16.Text = "Agregar Visitante";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 20);
            this.label20.TabIndex = 19;
            this.label20.Text = "Nombre";
            // 
            // cedV
            // 
            this.cedV.Location = new System.Drawing.Point(128, 161);
            this.cedV.Name = "cedV";
            this.cedV.Size = new System.Drawing.Size(199, 22);
            this.cedV.TabIndex = 23;
            this.cedV.TextChanged += new System.EventHandler(this.agregarV_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = "Cédula";
            // 
            // nombreV
            // 
            this.nombreV.Location = new System.Drawing.Point(128, 100);
            this.nombreV.Name = "nombreV";
            this.nombreV.Size = new System.Drawing.Size(199, 22);
            this.nombreV.TabIndex = 18;
            this.nombreV.TextChanged += new System.EventHandler(this.agregarV_TextChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.Maroon;
            this.Eliminar.Location = new System.Drawing.Point(462, 337);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(104, 37);
            this.Eliminar.TabIndex = 16;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // cancelEdit
            // 
            this.cancelEdit.FlatAppearance.BorderSize = 0;
            this.cancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEdit.ForeColor = System.Drawing.Color.Firebrick;
            this.cancelEdit.Location = new System.Drawing.Point(300, 337);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(104, 37);
            this.cancelEdit.TabIndex = 15;
            this.cancelEdit.Text = "Cancelar";
            this.cancelEdit.UseVisualStyleBackColor = true;
            this.cancelEdit.Click += new System.EventHandler(this.cancelEdit_Click);
            // 
            // Editar
            // 
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Editar.Location = new System.Drawing.Point(158, 337);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(104, 37);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 411);
            this.splitter2.TabIndex = 13;
            this.splitter2.TabStop = false;
            // 
            // horarioE
            // 
            this.horarioE.Location = new System.Drawing.Point(259, 138);
            this.horarioE.Name = "horarioE";
            this.horarioE.Size = new System.Drawing.Size(344, 22);
            this.horarioE.TabIndex = 12;
            // 
            // camaE
            // 
            this.camaE.Location = new System.Drawing.Point(259, 102);
            this.camaE.Name = "camaE";
            this.camaE.Size = new System.Drawing.Size(344, 22);
            this.camaE.TabIndex = 11;
            // 
            // cedulaE
            // 
            this.cedulaE.Location = new System.Drawing.Point(259, 67);
            this.cedulaE.Name = "cedulaE";
            this.cedulaE.ReadOnly = true;
            this.cedulaE.Size = new System.Drawing.Size(344, 22);
            this.cedulaE.TabIndex = 10;
            // 
            // nombreE
            // 
            this.nombreE.Location = new System.Drawing.Point(259, 32);
            this.nombreE.Name = "nombreE";
            this.nombreE.Size = new System.Drawing.Size(344, 22);
            this.nombreE.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Horario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(154, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(154, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Cédula";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(154, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Editar Paciente";
            // 
            // addPacientePanel
            // 
            this.addPacientePanel.Controls.Add(this.cancelP);
            this.addPacientePanel.Controls.Add(this.addP);
            this.addPacientePanel.Controls.Add(this.splitter1);
            this.addPacientePanel.Controls.Add(this.horarioA);
            this.addPacientePanel.Controls.Add(this.camaA);
            this.addPacientePanel.Controls.Add(this.cedulaA);
            this.addPacientePanel.Controls.Add(this.nombreA);
            this.addPacientePanel.Controls.Add(this.label10);
            this.addPacientePanel.Controls.Add(this.label9);
            this.addPacientePanel.Controls.Add(this.label8);
            this.addPacientePanel.Controls.Add(this.label7);
            this.addPacientePanel.Controls.Add(this.label6);
            this.addPacientePanel.Location = new System.Drawing.Point(13, 232);
            this.addPacientePanel.Name = "addPacientePanel";
            this.addPacientePanel.Size = new System.Drawing.Size(1077, 380);
            this.addPacientePanel.TabIndex = 4;
            // 
            // cancelP
            // 
            this.cancelP.FlatAppearance.BorderSize = 0;
            this.cancelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelP.ForeColor = System.Drawing.Color.Firebrick;
            this.cancelP.Location = new System.Drawing.Point(607, 334);
            this.cancelP.Name = "cancelP";
            this.cancelP.Size = new System.Drawing.Size(104, 37);
            this.cancelP.TabIndex = 15;
            this.cancelP.Text = "Cancelar";
            this.cancelP.UseVisualStyleBackColor = true;
            this.cancelP.Click += new System.EventHandler(this.cancelP_Click);
            // 
            // addP
            // 
            this.addP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addP.Location = new System.Drawing.Point(342, 333);
            this.addP.Name = "addP";
            this.addP.Size = new System.Drawing.Size(104, 37);
            this.addP.TabIndex = 14;
            this.addP.Text = "Agregar";
            this.addP.UseVisualStyleBackColor = true;
            this.addP.Click += new System.EventHandler(this.addP_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 380);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // horarioA
            // 
            this.horarioA.Location = new System.Drawing.Point(342, 262);
            this.horarioA.Name = "horarioA";
            this.horarioA.Size = new System.Drawing.Size(344, 22);
            this.horarioA.TabIndex = 12;
            this.horarioA.TextChanged += new System.EventHandler(this.agregar_TextChanged);
            // 
            // camaA
            // 
            this.camaA.Location = new System.Drawing.Point(342, 193);
            this.camaA.Name = "camaA";
            this.camaA.Size = new System.Drawing.Size(344, 22);
            this.camaA.TabIndex = 11;
            this.camaA.TextChanged += new System.EventHandler(this.agregar_TextChanged);
            // 
            // cedulaA
            // 
            this.cedulaA.Location = new System.Drawing.Point(342, 133);
            this.cedulaA.Name = "cedulaA";
            this.cedulaA.Size = new System.Drawing.Size(344, 22);
            this.cedulaA.TabIndex = 10;
            this.cedulaA.TextChanged += new System.EventHandler(this.agregar_TextChanged);
            // 
            // nombreA
            // 
            this.nombreA.Location = new System.Drawing.Point(342, 70);
            this.nombreA.Name = "nombreA";
            this.nombreA.Size = new System.Drawing.Size(344, 22);
            this.nombreA.TabIndex = 5;
            this.nombreA.TextChanged += new System.EventHandler(this.agregar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(474, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Horario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cédula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agregar Paciente";
            // 
            // listaVisitantesAdd
            // 
            this.listaVisitantesAdd.AllowUserToAddRows = false;
            this.listaVisitantesAdd.AllowUserToDeleteRows = false;
            this.listaVisitantesAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaVisitantesAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaVisitantesAdd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listaVisitantesAdd.Location = new System.Drawing.Point(259, 174);
            this.listaVisitantesAdd.MultiSelect = false;
            this.listaVisitantesAdd.Name = "listaVisitantesAdd";
            this.listaVisitantesAdd.ReadOnly = true;
            this.listaVisitantesAdd.RowTemplate.Height = 24;
            this.listaVisitantesAdd.Size = new System.Drawing.Size(375, 151);
            this.listaVisitantesAdd.TabIndex = 18;
            this.listaVisitantesAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaVisitantesAdd_CellContentClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(154, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Visitantes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(180, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "Visitantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 669);
            this.Controls.Add(this.ControlTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ControlTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pacientePanel.ResumeLayout(false);
            this.pacientePanel.PerformLayout();
            this.datosVisitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaVisitantesCheck)).EndInit();
            this.datosPaciente.ResumeLayout(false);
            this.datosPaciente.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.editPaciente.ResumeLayout(false);
            this.editPaciente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addPacientePanel.ResumeLayout(false);
            this.addPacientePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVisitantesAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ControlTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pacientePanel;
        private System.Windows.Forms.ListBox listaPacientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel datosVisitas;
        private System.Windows.Forms.Panel datosPaciente;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox horarioP;
        private System.Windows.Forms.TextBox camaP;
        private System.Windows.Forms.TextBox cedulaP;
        private System.Windows.Forms.TextBox nombreP;
        private System.Windows.Forms.Label ca;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label ce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaPacientesAdmin;
        private System.Windows.Forms.Panel editPaciente;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button cancelEdit;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TextBox horarioE;
        private System.Windows.Forms.TextBox camaE;
        private System.Windows.Forms.TextBox cedulaE;
        private System.Windows.Forms.TextBox nombreE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel addPacientePanel;
        private System.Windows.Forms.Button cancelP;
        private System.Windows.Forms.Button addP;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox horarioA;
        private System.Windows.Forms.TextBox camaA;
        private System.Windows.Forms.TextBox cedulaA;
        private System.Windows.Forms.TextBox nombreA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cedV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox nombreV;
        private System.Windows.Forms.Button cancelAddV;
        private System.Windows.Forms.Button addV;
        private System.Windows.Forms.DataGridView listaVisitantesCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView listaVisitantesAdd;
        private System.Windows.Forms.Label label18;
    }
}

