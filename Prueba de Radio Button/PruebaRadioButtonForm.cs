using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_Radio_Button
{
    public partial class PruebaRadioButtonForm : Form
    {
        private MessageBoxIcon tipoIcono;
        private MessageBoxButtons tipoBoton;
        public PruebaRadioButtonForm()
        {
            InitializeComponent();
        }

        private void tipoBoton_CheckChanged(Object sender, EventArgs e)
        {

            if (sender == aceptar_Btn) // Muestra Boton Aceptar
                tipoBoton = MessageBoxButtons.OK;
            else if (sender == cancelar_Btn) //Muestra botones Acpetar y Cancelar
                tipoBoton = MessageBoxButtons.OKCancel;
            else if (sender == abortarReintentarIgnorar_Btn) // Mostrar botones Abortar, Reintentar e Ignorar
                tipoBoton = MessageBoxButtons.AbortRetryIgnore;
            else if (sender == siNoCancelar_Btn) // Muestra Botones Si, No y Cancelar
                tipoBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == siNo_Btn) // Muestra Botones Si y No
                tipoBoton = MessageBoxButtons.YesNo;
            else // Solo queda una opcion, mostrar botones, reintentar y cancelar
                tipoBoton = MessageBoxButtons.RetryCancel;

        }// Fin del metodo tipoBoton_CheckedChange

        private void tipoIcono_CheckChanged(object sender, EventArgs)
        {
            if (sender == asterisco_Btn) // Muestra Icono de asterisco
                tipoIcono = MessageBoxIcon.Asterisk;
            else if (sender == error_Btn)
                tipoIcono = MessageBoxIcon.Error;
            // Muestra -icono de signo de exclamacion
            else if (sender == exclamacion_Btn)
                tipoIcono = MessageBoxIcon.Exclamation;
            // Muestra icono de mano
            else if (sender == mano_Btn)
                tipoIcono = MessageBoxIcon.Hand;
            // Muestra Icono información
            else if (sender == informacion_Btn)
                tipoIcono = MessageBoxIcon.Information;
            // Muestra icono de signo de interrogación
            else if (sender == pregunta_Btn)
                tipoIcono = MessageBoxIcon.Question;
            // Muestra icono de alto
            else if (sender == alto_Btn)
                tipoIcono = MessageBoxIcon.Stop;
            // Muestra icono advertencia
            else
                tipoIcono = MessageBoxIcon.Warning;
        }

        private void mostrar_Btn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Este es una wea fome",
                                                     "MessageBox personalizado",
                                                     tipoBoton,
                                                     tipoIcono, 
                                                     0, 0);
            // Comprubra que control Button se oprimio en el MessageBox
            // Cambia el texto mostrado de manera acorde
            switch (resultado)
            {
                case DialogResult.OK:
                    mostrar_Lbl.Text = "Se Oprimio Aceptar";
                    break;
                case DialogResult.Cancel:
                    mostrar_Lbl.Text = "Se oprimio cancelar";
                    break;
                case DialogResult.Abort:
                    mostrar_Lbl.Text = "Se oprimio abortar";
                    break;
                case DialogResult.Retry:
                    mostrar_Lbl.Text = "Se oprimio Reintentar";
                    break;
                case DialogResult.Ignore:
                    mostrar_Lbl.Text = "Se oprimio ignorar";
                    break;
                case DialogResult.Yes:
                    mostrar_Lbl.Text = "Se oprimio Sí";
                    break;
                case DialogResult.No:
                    mostrar_Lbl.Text = "Se oprimio No";
                    break;
            }
        }
    }
}
