namespace Fase3WilsonCastro
{
    public partial class Inicio : Form
    {
        private const string STRCLAVE = "unad";
        public Inicio()


        {
            InitializeComponent();
            // Deshabilitamos el TextBox de contraseña al iniciar
            txtClave.Enabled = false;
            // Configuramos el TextBox para que muestre asteriscos
            txtClave.PasswordChar = '*';
            // Deshabilitamos el botón de Ingresar al iniciar
            btnIngresar.Enabled = false;
        }


        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificamos si la contraseña ingresada es correcta
            if (txtClave.Text == STRCLAVE)
            {
                MessageBox.Show("¡Bienvenido al Sistema!", "Acceso Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear y mostrar el nuevo formulario
                frmEstructurasDatos estructurasDatos = new frmEstructurasDatos();
                estructurasDatos.Show();
                this.Hide(); // Ocultar el formulario de login


            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Por favor, intente nuevamente.",
                  "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();

            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void itemIniciarSesion_Click(object sender, EventArgs e)
        {
            // Habilitamos el TextBox de contraseña cuando se hace clic en "Iniciar sesión"
            txtClave.Enabled = true;
            btnIngresar.Enabled = true;
            // Enfocamos el cursor en el campo de contraseña
            txtClave.Focus();
        }

        private void itemAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estructura de datos \nWilson Castro \nGrupo #124", "Acerca de");
        }
    }
}
