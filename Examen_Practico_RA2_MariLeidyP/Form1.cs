using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Practico_RA2_MariLeidyP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
           
            this.btn_cerrar.Click += btn_cerrar_Click;
            this.btn_Eliminar.Click += btn_Eliminar_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
                Close();

            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_matricula.Clear();
            txt_Nombre.Clear();
            cmb_curso.SelectedIndex = -1;
            cmb_seccion.SelectedIndex = -1;
            cmb_Area.SelectedIndex = -1;
            txt_Direccion.Clear();
            txt_telefono.Clear();
            txt_mail.Clear();
            txt_maestro.Clear();

            Dgv_estudiantes.Rows.Clear();
            txt_matricula.Clear();
            txt_Nombre.Clear();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {



        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Dgv_estudiantes.Rows.Add(txt_matricula.Text, txt_Nombre.Text,  txt_Direccion.Text, txt_telefono.Text, Rdb_Femenino.Text, 
              txt_mail.Text, cmb_curso, cmb_Area, txt_maestro.Text, cmb_seccion); 

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarEstudianteSeleccionado(); 
        }

        private void EliminarEstudianteSeleccionado()
        {

            int fila;
            if (Dgv_estudiantes.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {

                    fila = Dgv_estudiantes.CurrentRow.Index;
                    Dgv_estudiantes.Rows.RemoveAt(fila);
                    MessageBox.Show("Registro eliminado", "Registro");
                }

            }
        }
                private void ActivarControles()
        {
            txt_matricula.Enabled = true;
            txt_Nombre.Enabled = true;
            cmb_curso.Enabled = true;
            cmb_seccion.Enabled = true;
            cmb_Area.Enabled = true;
            btn_guardar.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_Agregar.Enabled = true;




        }
    }





}
   