using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{//inicio capa de presentacion
    public partial class FrmCliente : Form
    {//inicio clase formulario

        private bool isNuevo = false;

        private bool isEditar = false;
        public FrmCliente()
        {
            InitializeComponent();

            //this.ttMensaje.SetToolTip(this.txtDni, "Ingrese el DNI del Cliente");

            //this.LlenarComboSexo();
            //this.LlenarComboTipoCliente();
            //this.LlenarComboHabilitados();
            //this.LlenarComboProvincia();
            //this.LlenarComboTipoPago();
            //this.LlenarComboDependencia();
            //this.LlenarComboEstadoCuota();
        }

        //mostrar mensaje de confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas Industriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas Industriales", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtDni.Text = string.Empty;
            this.txtLegajo.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCuenta_Bancaria.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.cmbTipoCliente.Text = string.Empty;
            this.cmbHabilitado.Text = string.Empty;
            this.txtFechaNacimiento.Text = string.Empty;
            this.cmbSexo. Text = string.Empty;
            this.cmbLocalidad.Text = string.Empty;
            this.txtMontoAlcance.Text = string.Empty;
        }

        //hobilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtDni.ReadOnly = !valor;
            this.txtLegajo.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtCuenta_Bancaria.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.cmbTipoCliente.Enabled = valor;
            this.cmbHabilitado.Enabled = valor;
            this.txtFechaNacimiento.ReadOnly = !valor;
            this.cmbSexo.Enabled = valor;
            this.cmbLocalidad.Enabled = valor;
            this.txtMontoAlcance.ReadOnly = !valor;
        }

        //habilitar los botones
        private void Botones()
        {
            if (this.isNuevo || this.isEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataClientes.Columns[0].Visible = false;
            this.dataClientes.Columns[1].Visible = false;
        }


        //metodo mostrar
        private void Mostrar()
        {

            this.dataClientes.DataSource = NCliente.Mostrar();
            //this.OcultarColumnas();
            lblTotal.Text = "Total Clientes: " + Convert.ToString(dataClientes.Rows.Count);
        }

        //metodo Buscar Clientes
        private void BuscarClientes()
        {
            this.dataClientes.DataSource = NCliente.Buscar(this.txtBuscar.Text);

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {//inicio formulario load
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }//fin formulario load

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.isNuevo = true;
            this.isEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtDni.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//inicio boton guardar de clientes
            try
            {//inicio try
                string rpta = "";
                if (this.txtDni.Text != string.Empty)
                {//inicio if 
                    //MensajeError("Falta ingresar algunos datos, serán recargados");
                    //errorIcono.SetError(txtDescripcion, "Ingrese la denoinacion del producto");
                }//fin if
                else
                {//inicio else
                    decimal valor_Decimal = 0;

                    if (this.isNuevo)
                    {//inicio if
                        MessageBox.Show("Estoy entrando por el metodo INSERTAR");
                        //rpta = NProducto.Insertar(5001, 2005, "Producto de prueba", 15, 2,
                        //  150, 5, "18/10/2005", 1, 1);
                        MessageBox.Show("Estoy entrando por el metodo INSERTAR");
                        //rpta = NProducto.Insertar(5000, Convert.ToInt32(this.txtCodigoBarra.Text), this.txtDescripcion.Text.Trim().ToUpper(), Convert.ToDecimal(this.txtPrecioKilo.Text), Convert.ToDecimal(this.txtPrecioUnidad.Text),
                        //  Convert.ToInt32(this.txtStock.Text), Convert.ToInt32(this.txtStockMinimo.Text), this.txtFechaVencimiento.Text, Convert.ToInt32(this.cmbTaller.SelectedValue), Convert.ToInt32(this.txtMateriaPrrima.Text));

                        rpta = NCliente.Insertar(5000, Convert.ToInt32(this.txtDni.Text), Convert.ToInt32(this.txtLegajo.Text), this.txtApellido.Text.Trim().ToUpper(), this.txtNombre.Text.Trim().ToUpper(), this.txtTelefono.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.txtEmail.Text.Trim().ToUpper(),
                          Convert.ToInt32(this.cmbHabilitado.Text),this.txtFechaNacimiento.Text, 6, Convert.ToInt32(this.txtMontoAlcance.Text), Convert.ToInt32(this.txtCuenta_Bancaria.Text),null, 1, 1, "12/10/2008", 200);

                    }//fin if
                    else
                    {//inicio else
                        MessageBox.Show("Estoy entrando por el metodo EDITAR");
                        rpta = NCliente.Editar(5000, Convert.ToInt32(this.txtDni.Text), Convert.ToInt32(this.txtLegajo.Text), this.txtApellido.Text.Trim().ToUpper(), this.txtNombre.Text.Trim().ToUpper(), this.txtTelefono.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.txtEmail.Text.Trim().ToUpper(),
                          Convert.ToInt32(this.cmbHabilitado.Text), this.txtFechaNacimiento.Text, 6, Convert.ToInt32(this.txtMontoAlcance.Text), Convert.ToInt32(this.txtCuenta_Bancaria.Text), null, 1, 1, "12/10/2008", 200);

                    }//fin else

                    if (rpta.Equals("OK"))
                    {//inicio if rpta
                        if (this.isNuevo)
                        {//inicio if IsNuevo
                            this.MensajeOk("Se insertó correctamnte el Registro");
                        }//fin if IsNuevo

                        else
                        {//inicio else IsNuevo
                            this.MensajeOk("Se actualizó correctamnte el Registro");
                        }//Fin else IsNuevo
                    }//fin rpta
                    else
                    {//inicio else rpta
                        this.MensajeError("Se introdujo un número de dni o legajo duplicado a continuación se muestra el número duplicado: " + rpta);
                    }//fin else rpta

                    this.isNuevo = false;
                    this.isEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }//fin else

            }//fin try
            catch (Exception ex)
            {//inicio catch
                MessageBox.Show(ex.Message, ex.StackTrace);
                MessageBox.Show("El error esta por esta salida");
            }//fin catch

        }//fin boton guardar clientes
    }//fin clase formulario
}//fin capa de presentacion
