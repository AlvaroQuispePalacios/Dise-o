using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_notas
{
    public partial class FormViewNotasAsignaturasAlumnos : Form
    {
        public FormViewNotasAsignaturasAlumnos()
        {
            InitializeComponent();
        }

        private void FormViewNotasAsignaturasAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'notasDataSet.notas_asignaturas_alumnos2' Puede moverla o quitarla según sea necesario.
            this.notas_asignaturas_alumnos2TableAdapter.Fill(this.notasDataSet.notas_asignaturas_alumnos2);
            // TODO: esta línea de código carga datos en la tabla 'notasDataSet.notas_asignaturas_alumnos' Puede moverla o quitarla según sea necesario.
            try
            {
                this.notas_asignaturas_alumnosTableAdapter.Fill(this.notasDataSet.notas_asignaturas_alumnos);
            }catch(Exception ex)
            {
                
            }

        }
    }
}
