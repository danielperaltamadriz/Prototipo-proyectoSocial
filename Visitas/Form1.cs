using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Visitas
{
    public partial class Form1 : Form
    {
        private TextBox cam;
        private TextBox ced;
        private TextBox hor;
        private ListBox lista;
        private DataGridView listaV;
        private TextBox nom;
        private Panel pacientePa;
        private readonly List<Paciente> pacientes;
        private int tab;

        public Form1()
        {
            pacientes = new List<Paciente>();
            InitializeComponent();
            ControlTab.TabPages[0].Text = "Visitantes";
            ControlTab.TabPages[1].Text = "Administración";
            Tab1();
            addPacientesDefault();
            getPacientes();
            tab = 1;
        }

        private void addPacientesDefault()
        {
            addPaciente("Karla", "1", "Mujeres 2", "10pm - 8am");
            addPaciente("Manuel", "2", "Hombres 2", "4pm - 5pm");
            addPaciente("Juan", "3", "Hombres 23", "4pm - 5pm");
            addPaciente("Miguela", "4", "Mujeres 6", "4pm - 5pm");
        }

        private void addPaciente(string n, string id, string c, string h)
        {
            var p = new Paciente(n, h, id, c);
            pacientes.Add(p);
        }

        private void getPacientes()
        {
            cleanListaPacientes();
            foreach (var paciente in pacientes)
                lista.Items.Add(paciente.getPacienteResumen());
            DisablePacientePanel();
        }

        private void getListaV(Paciente p)
        {
            var bindingList = new BindingList<Visita>(p.GetVisitas());
            var source = new BindingSource(bindingList, null);
            listaV.DataSource = source;
            listaV.Refresh();
        }

        private void getPacientes(List<Paciente> custom)
        {
            cleanListaPacientes();
            foreach (var paciente in custom)
                lista.Items.Add(paciente.getPaciente());
            DisablePacientePanel();
        }

        private void getVisitasOfPaciente(Paciente p)
        {
            pacientePa.Enabled = true;
            pacientePa.Visible = true;
            llenarDatosPaciente(p);
        }

        private void llenarDatosPaciente(Paciente p)
        {
            nom.Text = p.Nombre;
            ced.Text = p.Cedula;
            cam.Text = p.Cama;
            hor.Text = p.Horario;
        }

        private void addVisitaToPaciente(Paciente p, string n, string c)
        {
            var visita = new Visita
            {
                cedula = c,
                nombre = n
            };
            p.addVisita(visita);
        }

        private void VisitaMod_Selected(object sender, TabControlEventArgs e)
        {
            if (ControlTab.SelectedTab == tabPage1)
                Tab1();
            else
                AddPacientePanel();
            getPacientes();
        }

        private void Tab1()
        {
            tab = 1;
            lista = listaPacientes;
            nom = nombreP;
            ced = cedulaP;
            cam = camaP;
            hor = horarioP;
            listaV = listaVisitantesCheck;
            pacientePa = pacientePanel;
        }

        private void AddPacientePanel()
        {
            tab = 2;
            lista = listaPacientesAdmin;
            nom = nombreA;
            ced = cedulaA;
            cam = camaA;
            hor = horarioA;
            editPaciente.Visible = false;
            addPacientePanel.Visible = true;
        }


        private void cleanListaPacientes()
        {
            lista.Items.Clear();
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            getPacientes();
            var tmp = (TextBox)sender;
            if (!string.IsNullOrEmpty(tmp.Text))
            {
                getPacientes(pacientes.Where(p => p.Cedula.Contains(tmp.Text)).ToList());
                DisablePacientePanel();
            }
        }

        private void listaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                if (tab == 2)
                    EditPacientePanel();
                var paciente = pacientes[lista.SelectedIndex];
                getVisitasOfPaciente(paciente);
                getListaV(paciente);
            }
            else
                DisablePacientePanel();
        }

        private void EditPacientePanel()
        {
            pacientePa = editPaciente;
            pacientePa.Enabled = pacientePa.Visible = true;
            nom = nombreE;
            ced = cedulaE;
            cam = camaE;
            hor = horarioE;
            listaV = listaVisitantesAdd;
            addPacientePanel.Visible = false;
        }

        private void DisablePacientePanel()
        {
            pacientePa.Enabled = false;
            pacientePa.Visible = false;
            if (tab == 2)
                AddPacientePanel();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            pacientes.RemoveAll(p => p.Cedula == ced.Text);
            addPaciente(nom.Text, ced.Text, cam.Text, hor.Text);
            getPacientes();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            pacientes.RemoveAll(p => p.Cedula == ced.Text);
            getPacientes();
        }

        private void addP_Click(object sender, EventArgs e)
        {
            addPaciente(nom.Text, ced.Text, cam.Text, hor.Text);
            nom.Text = ced.Text = cam.Text = hor.Text = "";
            getPacientes();
        }

        private void checkAddButton()
        {
            addP.Enabled = !string.IsNullOrWhiteSpace(nom.Text) && !string.IsNullOrWhiteSpace(ced.Text)
                           && !string.IsNullOrWhiteSpace(cam.Text) && !string.IsNullOrWhiteSpace(hor.Text);
        }

        private void checkAddVisitanteButton()
        {
            addV.Enabled = !string.IsNullOrWhiteSpace(nombreV.Text)
                           && !string.IsNullOrWhiteSpace(cedV.Text);
        }

        private void cancelEdit_Click(object sender, EventArgs e)
        {
            lista.SelectedIndex = -1;
        }

        private void agregar_TextChanged(object sender, EventArgs e)
        {
            checkAddButton();
        }

        private void cancelP_Click(object sender, EventArgs e)
        {
            nom.Text = ced.Text = cam.Text = hor.Text = "";
        }

        private void agregarV_TextChanged(object sender, EventArgs e)
        {
            checkAddVisitanteButton();
        }

        private void agregarV_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                if (tab == 2)
                    EditPacientePanel();
                var paciente = pacientes[lista.SelectedIndex];
                addVisitaToPaciente(paciente, nombreV.Text, cedV.Text);
                getListaV(paciente);
                nombreV.Text = cedV.Text = "";
            }
            else
                DisablePacientePanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombreV.Text = cedV.Text = "";
        }

        private void listaVisitantesAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                var paciente = pacientes[lista.SelectedIndex];

                var visita = paciente.getVisita(listaV.Rows[e.RowIndex].Cells[1].Value?.ToString());
                if (paciente.GetVisitas().Exists(v => v.visitando && (v.cedula != visita?.cedula)))
                {
                    MessageBox.Show("Error, en este momento hay otro(a) visitante adentro", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    visita.visitando = false;
                    listaV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }
        }
    }
}