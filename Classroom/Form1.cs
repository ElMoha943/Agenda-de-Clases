using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classroom.Models;

namespace Classroom
{
    public partial class FormMain : Form
    {
        DB adaptador = new DB();
        DateTime startDate = DateTime.Parse("1/1/1754 12:00:00 AM ");
        DateTime endDate = DateTime.MaxValue;
        bool searchAllStudents = true;
        bool searchAllSubjects = true;
        public FormMain()
        {
            InitializeComponent();
            //adaptador.AddClase(DateTime.Now, "Maxi", 1, "FiscellaDaun");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //DATAGRID SETTINGS
            dataGridView1.DataSource = adaptador.GetClases(startDate, endDate);
            dataGridView1.Columns["Alumno"].Width = 50;
            dataGridView1.Columns["Asignatura"].Width = 100;
            dataGridView1.Columns["Duracion"].Width = 40;
            dataGridView1.Columns["Duracion"].DefaultCellStyle.Format = $"{0} hs";
            dataGridView1.Columns["Costo"].Width = 50;
            dataGridView1.Columns["Costo"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["Paga"].Width = 50;
            //ComboBox Settings
            List<Alumno> alumnos = adaptador.GetAlumnos();
            foreach (Alumno a in alumnos)
            {
                comboBoxAlumnos.Items.Add(a.Name);
                comboBoxAlumno.Items.Add(a.Name);
            }
        }

        //BUSQUEDA
        private void Busqueda()
        {
            if (searchAllStudents && searchAllSubjects) dataGridView1.DataSource = adaptador.GetClases(startDate, endDate);
            else if (!searchAllStudents && !searchAllSubjects) dataGridView1.DataSource = adaptador.GetClases(startDate, endDate, comboBoxAlumnos.Texts, comboBoxAsignatura.Texts);
            else if (!searchAllStudents) dataGridView1.DataSource = adaptador.GetClases(startDate, endDate, comboBoxAlumnos.Texts);
            else if (!searchAllSubjects) dataGridView1.DataSource = adaptador.GetClases(comboBoxAsignatura.Texts, startDate, endDate);
        }
        private void rjComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Todas las clases")
            {
                startDate = DateTime.Parse("1/1/1754 12:00:00 AM ");
                endDate = DateTime.MaxValue;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Proximas clases")
            {
                startDate = DateTime.Now;
                endDate = DateTime.MaxValue;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Clases completas")
            {
                startDate = DateTime.Parse("1/1/1754 12:00:00 AM ");
                endDate = DateTime.Now;
            }
            Busqueda();
        }

        private void comboBoxAlumnos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxAlumnos.Texts == "Todos los alumnos") searchAllStudents = true;
            else searchAllStudents = false;
            Busqueda();
        }

        private void comboBoxAsignatura_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAsignatura.Texts == "Todas las asignaturas") searchAllSubjects = true;
            else searchAllSubjects = false;
            Busqueda();
        }

        //NUEVA CLASE
        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            int duracion;
            DateTime fecha;
            if (radioButton1.Checked) duracion = 1;
            else duracion = 2;
            try
            {
                string str = datePicker.Value.ToString().Substring(0, datePicker.Value.ToString().IndexOf(" ") + 1);
                fecha = DateTime.Parse(str + textBoxHorario.Texts);
                adaptador.AddClase(fecha, comboBoxAlumno.Texts.ToString(), duracion, comboBoxMaterias.Texts.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Clase agendada correctamente");
            dataGridView1.DataSource = adaptador.GetClases(startDate, endDate);
        }
    }
}
