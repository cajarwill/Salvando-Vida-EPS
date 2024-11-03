using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3WilsonCastro
{
    public partial class frmEstructurasDatos : Form
    {
        private string strTipodeIdentificacion;
        private string strNrodeIdentificacion;
        private string strNombreCompleto;
        private string strEdad;
        private string strEstratoSocioeconomico;
        private string strTipodeAtencion;
        private string strValordeCopago;
        private string strFechadeAcceso;
        private string strTipodeEstructura;
        private int intEstructurasDatosPila, intEstructurasDatosCola, intEstructurasDatosLista;
        private int intSumaEdadesListas = 0;

        Stack<EstructurasDatosUsuarios> pilaUsuarios = new Stack<EstructurasDatosUsuarios>();
        Queue<EstructurasDatosUsuarios> colaUsuarios = new Queue<EstructurasDatosUsuarios>();
        List<EstructurasDatosUsuarios> listaUsuarios = new List<EstructurasDatosUsuarios>();

        public frmEstructurasDatos()
        {
            InitializeComponent();
            cargarElementosIniciales();
            this.intEstructurasDatosPila = 0;
            this.intEstructurasDatosCola = 0;
            this.intEstructurasDatosLista = 0;
            this.btnReportePila.Enabled = false;
            this.btnReporteCola.Enabled = false;
            this.btnReporteLista.Enabled = false;
            this.btnEliminarPila.Enabled = false;
            this.btnEliminarCola.Enabled = false;
            this.btnEliminarLista.Enabled = false;
        }

        public void cargarElementosIniciales()
        {
            this.boxTipodeIdentificacion.Text = "";
            this.txtNrodeIdentificacion.Text = "";
            this.txtNombreCompleto.Text = "";
            this.txtEdad.Text = "";
            this.boxEstratoSocioeconomico.Text = "";
            this.rdMedicinaGeneral.Checked = false;
            this.rdExamendeLaboratorio.Checked = false;
            this.txtValordelCopago.Text = "";
            this.dtFechadeAcceso.Value = DateTime.Now;
            this.boxTipodeEstructura.Text = "";
            this.txtReportedeDatos.Text = "";

            this.boxTipodeIdentificacion.Items.Clear();
            this.boxEstratoSocioeconomico.Items.Clear();
            this.boxTipodeEstructura.Items.Clear();

            this.boxTipodeIdentificacion.Items.Add("CC");
            this.boxTipodeIdentificacion.Items.Add("CE");
            this.boxTipodeIdentificacion.Items.Add("NUIP");
            this.boxTipodeIdentificacion.Items.Add("PAS");

            this.boxEstratoSocioeconomico.Items.Add("1");
            this.boxEstratoSocioeconomico.Items.Add("2");
            this.boxEstratoSocioeconomico.Items.Add("3");
            this.boxEstratoSocioeconomico.Items.Add("4");
            this.boxEstratoSocioeconomico.Items.Add("5");
            this.boxEstratoSocioeconomico.Items.Add("6");

            this.boxTipodeEstructura.Items.Add("Pila");
            this.boxTipodeEstructura.Items.Add("Cola");
            this.boxTipodeEstructura.Items.Add("Lista");

            this.boxTipodeIdentificacion.Focus();


        }

        public bool validarFormulario()
        {
            String strMsg = "";

            this.strTipodeIdentificacion = this.boxTipodeIdentificacion.Text.Trim();

            if (this.strTipodeIdentificacion.Equals(""))
            {
                strMsg = strMsg + "- Tipo de identificación \n";
            }

            this.strNrodeIdentificacion = this.txtNrodeIdentificacion.Text.Trim();

            if (this.strNrodeIdentificacion.Equals(""))
            {
                strMsg = strMsg + "- Nro. de identificacion \n";
            }

            this.strNombreCompleto = this.txtNombreCompleto.Text.Trim();

            if (this.strNombreCompleto.Equals(""))
            {
                strMsg = strMsg + "- Nombre completo \n";
            }

            this.strEdad = this.txtEdad.Text.Trim();

            if (this.strEdad.Equals(""))
            {
                strMsg = strMsg + "- Edad \n";
            }

            this.strEstratoSocioeconomico = this.boxEstratoSocioeconomico.Text.Trim();

            if (this.strEstratoSocioeconomico.Equals(""))
            {
                strMsg = strMsg + "- Estrato socioeconómico \n";
            }

            if (this.rdMedicinaGeneral.Checked == false && this.rdExamendeLaboratorio.Checked == false)
            {
                strMsg = strMsg + "- Tipo de atención \n";
            }
            else
            {
                if (this.rdMedicinaGeneral.Checked == true)
                {
                    this.strTipodeAtencion = "Medicina general";
                }

                if (this.rdExamendeLaboratorio.Checked == true)
                {
                    this.strTipodeAtencion = "Examen de laboratorio";
                }
            }

            //this.strValordeCopago = this.txtValordelCopago.Text.Trim();

            //if (this.strValordeCopago.Equals(""))
            //{
            //strMsg = strMsg + "- Valor de copago \n";
            //}

            this.strTipodeEstructura = this.boxTipodeEstructura.Text.Trim();

            if (this.strTipodeEstructura.Equals(""))
            {
                strMsg = strMsg + "- Tipo de estructura \n";
            }

            //this.strReportedeDatos = this.txtReportedeDatos.Text.Trim();

            //if (this.strReportedeDatos.Equals(""))
            //{
            //strMsg = strMsg + "- Reporte de datos \n";
            //}

            if (!strMsg.Equals(""))
            {
                strMsg = "DEBE DILIGENCIAR LOS SIGUIENTES CAMPOS: \n ********************************************* \n\n" + strMsg;
                MessageBox.Show(strMsg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                this.strValordeCopago = (calcularValordelCopago()).ToString();
                this.txtValordelCopago.Text = int.Parse(strValordeCopago).ToString("C");
                this.strFechadeAcceso = this.dtFechadeAcceso.Value.ToString();
                return true;

            }
        }

        public int calcularValordelCopago()
        {
            int intValordeCopago;
            intValordeCopago = 0;

            if (this.strTipodeAtencion.Equals("Medicina general"))
            {
                switch (this.strEstratoSocioeconomico)
                {
                    case "1":
                        intValordeCopago = 0; break;
                    case "2":
                        intValordeCopago = 0; break;
                    case "3":
                        intValordeCopago = 10000; break;
                    case "4":
                        intValordeCopago = 15000; break;
                    case "5":
                        intValordeCopago = 20000; break;
                    case "6":
                        intValordeCopago = 30000; break;
                }
            }

            if (this.strTipodeAtencion.Equals("Examen de laboratorio"))
            {
                switch (this.strEstratoSocioeconomico)
                {
                    case "1":
                        intValordeCopago = 0; break;
                    case "2":
                        intValordeCopago = 0; break;
                    case "3":
                        intValordeCopago = 0; break;
                    case "4":
                        intValordeCopago = 5000; break;
                    case "5":
                        intValordeCopago = 10000; break;
                    case "6":
                        intValordeCopago = 20000; break;
                }
            }

            return intValordeCopago;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdExamendeLaboratorio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir de la aplicación", "confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                EstructurasDatosUsuarios miEstructura = new EstructurasDatosUsuarios();
                miEstructura.strTipodeIdentificacion = this.strTipodeIdentificacion;
                miEstructura.strNrodeIdentificacion = this.strNrodeIdentificacion;
                miEstructura.strNombreCompleto = this.strNombreCompleto;
                miEstructura.strEdad = this.strEdad;
                miEstructura.strEstratoSocioeconomico = this.strEstratoSocioeconomico;
                miEstructura.strTipodeAtencion = this.strTipodeAtencion;
                miEstructura.intValordeCopago = int.Parse(this.strValordeCopago);
                miEstructura.strFechadeAcceso = this.strFechadeAcceso;

                if (this.strTipodeEstructura.Equals("Pila"))
                {
                    this.intEstructurasDatosPila = this.intEstructurasDatosPila + int.Parse(this.strValordeCopago);

                    this.pilaUsuarios.Push(miEstructura);
                    dgPila.DataSource = null;
                    dgPila.DataSource = this.pilaUsuarios.ToArray();
                    this.tabEstructuras.SelectedIndex = 0;
                    MessageBox.Show("El registro fue agragado correctamente a la pila!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReportePila.Enabled = true;
                    this.btnEliminarPila.Enabled = true;
                }

                if (this.strTipodeEstructura.Equals("Cola"))
                {
                    this.intEstructurasDatosCola = this.intEstructurasDatosCola + 1;

                    this.colaUsuarios.Enqueue(miEstructura);
                    dgCola.DataSource = null;
                    dgCola.DataSource = this.colaUsuarios.ToArray();
                    this.tabEstructuras.SelectedIndex = 1;
                    MessageBox.Show("El registro fue agragado correctamente a la cola!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReporteCola.Enabled = true;
                    this.btnEliminarCola.Enabled = true;
                }

                if (this.strTipodeEstructura.Equals("Lista"))
                {
                    this.intSumaEdadesListas += int.Parse(this.strEdad);
                    this.intEstructurasDatosLista++;


                    this.listaUsuarios.Add(miEstructura);
                    dgLista.DataSource = null;
                    dgLista.DataSource = this.listaUsuarios.ToArray();
                    this.tabEstructuras.SelectedIndex = 2;
                    MessageBox.Show("El registro fue agragado correctamente a la lista!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReporteLista.Enabled = true;
                    this.btnEliminarLista.Enabled = true;
                }


            }
        }

        private void txtNrodeIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números en Nro. de identificación", "Valación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números en Edad", "Valación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarElementosIniciales();
        }

        private void btnReportePila_Click(object sender, EventArgs e)
        {
            txtReportedeDatos.Text = this.intEstructurasDatosPila.ToString("C");
        }

        private void btnReporteCola_Click(object sender, EventArgs e)
        {
            txtReportedeDatos.Text = this.intEstructurasDatosCola.ToString();
        }

        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            if (intEstructurasDatosLista > 0)
            {
                double promedio = (double)intSumaEdadesListas / intEstructurasDatosLista;
                txtReportedeDatos.Text = $"{promedio:F2} años";
            }
            else
            {
                txtReportedeDatos.Text = "No hay registros en la lista";
            }
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (this.pilaUsuarios.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el último registro de la pila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructurasDatosUsuarios miEstructura = new EstructurasDatosUsuarios();
                    miEstructura = this.pilaUsuarios.Pop();
                    this.intEstructurasDatosPila = this.intEstructurasDatosPila - miEstructura.intValordeCopago;
                    dgPila.DataSource = null;
                    dgPila.DataSource = this.pilaUsuarios.ToArray();


                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay registro en la pila para eliminar!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReportePila.Enabled = false;
                this.btnEliminarPila.Enabled = false;
            }
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {

            if (this.colaUsuarios.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el primer registro de la cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructurasDatosUsuarios miEstructura = new EstructurasDatosUsuarios();
                    miEstructura = this.colaUsuarios.Dequeue();
                    this.intEstructurasDatosCola = this.intEstructurasDatosCola - 1;
                    dgCola.DataSource = null;
                    dgCola.DataSource = this.pilaUsuarios.ToArray();


                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay registro en la cola para eliminar!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReporteCola.Enabled = false;
                this.btnEliminarCola.Enabled = false;
            }
        }

        private EstructurasDatosUsuarios obtenerUsuario(string strNrodeIdentificacion)
        {
            foreach(EstructurasDatosUsuarios miEstructura in this.listaUsuarios)
            {
                if(miEstructura.strNrodeIdentificacion.Equals(strNrodeIdentificacion)) 
                {
                    return miEstructura; 
                }
            }
            return null;
        }
        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if(this.listaUsuarios.Count > 0)
            {
                string strNrodeIdentificacion = this.txtNrodeIdentificacion.Text.Trim();

                if (strNrodeIdentificacion.Equals(""))
                {
                    MessageBox.Show("El Nro. de identificación del usuario no puede estar vacía para la eliminación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNrodeIdentificacion.Focus();
                }
                else
                {
                    EstructurasDatosUsuarios miEstructura = obtenerUsuario(strNrodeIdentificacion);

                    if(miEstructura != null)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registro de lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (miEstructura.strNrodeIdentificacion.Equals(""))
                            {
                                this.intEstructurasDatosLista = this.intEstructurasDatosLista - 1;
                            }

                            this.listaUsuarios.Remove(miEstructura);
                            dgLista.DataSource = null;
                            dgLista.DataSource = this.listaUsuarios.ToArray();
                            MessageBox.Show("El registro fue eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El usuario con Nro. de identificación" + strNrodeIdentificacion + "no existe en la lista", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtNrodeIdentificacion.Focus();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Actualmente no hay registro en la lista para eliminar!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReporteCola.Enabled = false;
                this.btnEliminarCola.Enabled = false;
            }
        }
    }
}