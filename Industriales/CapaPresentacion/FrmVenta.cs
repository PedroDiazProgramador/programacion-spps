using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace CapaPresentacion
{//inicio capa
    public partial class FrmVenta : Form
    {//inicio clase
        public FrmVenta()
        {
            InitializeComponent();
        }

        private List<DDetalle> lst = new List<DDetalle>();

        private void Buscar()
        {//inicio metodo Buscar
            try
            {
                if (this.txtBuscarApellido.Text != string.Empty)
                {
                    this.dataCliente.DataSource = NCliente.Buscar(this.txtBuscarApellido.Text);
                    BuscarClienteInhabilitado(Convert.ToBoolean(this.dataCliente.CurrentRow.Cells[8].Value.ToString()));
                    this.lblCliente.Text= Convert.ToString(this.dataCliente.CurrentRow.Cells["apellido"].Value) + " " + Convert.ToString(this.dataCliente.CurrentRow.Cells["nombre"].Value);
                    this.txtIdentificador.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["id_cliente"].Value);
                    this.dataCliente.Columns[0].Visible = false;
                    this.dataCliente.Columns[1].Visible = false;
                    this.dataCliente.Columns[2].Visible = false;
                    this.dataCliente.Columns[5].Visible = false;
                    this.dataCliente.Columns[6].Visible = true;
                    this.dataCliente.Columns[7].Visible = false;
                    this.dataCliente.Columns[8].Visible = false;
                    this.dataCliente.Columns[9].Visible = false;
                    this.dataCliente.Columns[10].Visible = false;
                    this.dataCliente.Columns[11].Visible = false;
                    this.dataCliente.Columns[12].Visible = false;
                    this.dataCliente.Columns[13].Visible = false;
                    this.dataCliente.Columns[14].Visible = false;
                    this.dataCliente.Columns[15].Visible = false;
                    this.dataCliente.Columns[16].Visible = false;
                }
                else
                {
                    //MessageBox.Show("No ha ingresado un texto para efectuar la búsqueda");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("El apellido del cliente no coincide con las letras ingresadas por teclado, vuelva a ingresar el apellido del cliente");
            }
        }//fin metodo Buscar

        private void BuscarDni()
        {//inicio metodo BuscarDni
            try
            {
                if (this.txtBuscarDni.Text != string.Empty)
                {//inicio if buscar dni 
                    this.dataCliente.DataSource = NCliente.BuscarDni(Convert.ToInt32(this.txtBuscarDni.Text));
                    BuscarClienteInhabilitado(Convert.ToBoolean(this.dataCliente.CurrentRow.Cells[8].Value.ToString()));
                    int legajo = Convert.ToInt32(this.dataCliente.CurrentRow.Cells[2].Value.ToString());
                    Boolean habilitado = Convert.ToBoolean(this.dataCliente.CurrentRow.Cells[8].Value.ToString());
                    this.lblCliente.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["apellido"].Value) + " " + Convert.ToString(this.dataCliente.CurrentRow.Cells["nombre"].Value);
                    this.txtIdentificador.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["id_cliente"].Value);
                    this.dataCliente.Columns[0].Visible = false;
                    this.dataCliente.Columns[1].Visible = false;
                    this.dataCliente.Columns[2].Visible = false;
                    this.dataCliente.Columns[5].Visible = false;
                    this.dataCliente.Columns[6].Visible = true;
                    this.dataCliente.Columns[7].Visible = false;
                    this.dataCliente.Columns[8].Visible = false;
                    this.dataCliente.Columns[9].Visible = false;
                    this.dataCliente.Columns[10].Visible = false;
                    this.dataCliente.Columns[11].Visible = false;
                    this.dataCliente.Columns[12].Visible = false;
                    this.dataCliente.Columns[13].Visible = false;
                    this.dataCliente.Columns[14].Visible = false;
                    this.dataCliente.Columns[15].Visible = false;
                    this.dataCliente.Columns[16].Visible = false;
                    

                    /*if (legajo == 1256)
                    {
                        MessageBox.Show("Cliente no apto para sacar credito");
                        BuscarClienteInhabilitado(Convert.ToInt32(this.dataCliente.CurrentRow.Cells[2].Value.ToString()));
                        this.lblHabilitado.Text = "No apto para Cuenta Corrientre";
                    
                    }
                    else
                     {
                            MessageBox.Show("Cliente apto");
                    
                    }*/

              }//fin buscar dni

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("El número ingresado no coincide con ningun numero de la base de datos, vuelva a ingresar el documento del cliente");
            }
        }//fin metodo BuscarDni

        private void BuscarClienteInhabilitado(Boolean habilitado)
        {//inicio metodo buscare cliente no apto para cuentas corrientes
            if (habilitado == false)
            {
                MessageBox.Show("Cliente no apto para sacar credito");
                this.lblHabilitado.Visible = true;
                this.lblHabilitado.Text = "Cliente inhabilitado para Cta. Cte.";
                

            }
            //else
            //{
            //    MessageBox.Show("Cliente apto para cuentas corrientes......");
            //}
        }//fin metodo buscar cliente no apto para cuentas corrientes

        private void LimpiarClienteInhabilitado()
        {
            this.lblHabilitado.Text = "";
        }

        //inicio metodo BuscarProductoVentas
        private void BuscarProductoVentas()
        {
            try
            {
                this.dataListadoProductos.DataSource = NProducto.Buscar(this.txtBuscarProductos.Text);
                this.lblStock.Text = "Stock: " + Convert.ToString(this.dataListadoProductos.CurrentRow.Cells["stock"].Value);
                this.dataListadoProductos.Columns[0].Visible = false;
                this.dataListadoProductos.Columns[1].Visible = false;
                this.dataListadoProductos.Columns[6].Visible = false;
                this.dataListadoProductos.Columns[8].Visible = false;
                this.dataListadoProductos.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los productos no coinciden con las letras ingresadas, vuelva a ingresar el nombre del producto o agreguelo desde el boton nuevo producto");
            }
        }//fin metodo BuscarProductoVentas

        //inicio metodo cargar datagrid Ventas
        private void CargarVentas()
        {//inicio metdo cargar ventas
         //CAPTURAMOS VALOR DE LA FILA SELECCIONADA DG FORM2
            DFactura V = new DFactura();
            DDetalle Detalle = new DDetalle();
            decimal Subtotal = 0;
            //dataVentas.Rows.Add(A, B, C, D, E);
            //foreach (DataGridViewRow fila in this.dataListadoProductos.Rows)
            //{
            //dataVentas.Rows.Add(fila.Cells[0].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value);
            //dataVentas.Rows.Add(A, B);
            //}
            //Int32 A = Convert.ToInt32(this.dataListadoProductos.CurrentRow.Cells[0].Value.ToString());
            //Int32 A = Convert.ToInt32(this.lblNumeroFactura.Text);
            //decimal P = Convert.ToDecimal(this.dataListadoProductos.CurrentRow.Cells[3].Value.ToString());
            //string B = this.txtCantidadProducto.Text;
            //string C = this.dataListadoProductos.CurrentRow.Cells[2].Value.ToString();
            //string D = this.dataListadoProductos.CurrentRow.Cells[3].Value.ToString();
            //Int32 E = dataListadoProductos.RowCount;
            //dataVentas.Rows.Add(A, B, D, E);

            //V.Fecha_venta = Convert.ToDateTime(this.dtpFechaVenta.Text);
            //V.Id_cliente = Convert.ToInt32(this.dataListadoProductos.CurrentRow.Cells[0].Value.ToString());
            //V.Id_cliente = Convert.ToInt32(this.txtIdentificador.Text);
            //V.Id_factura = Convert.ToInt32(this.txtCantidadProducto.Text);
            //V.Numero_factura = Convert.ToInt32(this.lblNumeroFactura.Text);
            //V.Comprobante_exposicion = Convert.ToInt32(this.dataListadoProductos.CurrentRow.Cells[0].Value.ToString());
            //V.Fecha_venta = Convert.ToDateTime(this.dtpFechaVenta.Value);

            //Detalle.Id_producto = Convert.ToInt32(this.dataListadoProductos.CurrentRow.Cells[5].Value.ToString());
            Detalle.Precio_producto = Convert.ToDecimal(this.dataListadoProductos.CurrentRow.Cells[4].Value.ToString());
            Detalle.Descripcion_producto = Convert.ToString(this.dataListadoProductos.CurrentRow.Cells[2].Value.ToString());
            Detalle.Cantidad_producto = Convert.ToInt32(this.txtCantidadProducto.Text);
            Detalle.Id_producto = Convert.ToInt32(this.lblNumeroFactura.Text);
            lst.Add(Detalle);
            LlenarGrilla();

            //Detalle.Id_producto = Convert.ToInt32(A);
            //Detalle.Precio_producto = Convert.ToDecimal(P);
            //Detalle.Cantidad_producto = Convert.ToInt32(this.txtCantidadProducto.Text);
            //lst.Add(Detalle);
            //LlenarGrilla();


            //foreach (DataGridViewRow row in dataListadoProductos.Rows)
            //{

            //int n = dataVentas.Rows.Add();
            //foreach (DataGridViewColumn col in dataListadoProductos.Columns)
            //    {
            //        dataVentas.Rows[n].Cells[col.Index].Value = dataListadoProductos.Rows[row.Index].Cells[col.Index].Value.ToString();
            //        //MessageBox.Show("numero de filas" + n);
            //    }
               

            //}

            

        }//fin metodo datagrid Ventas

        //Inicio metodo LlenarGrilla
        private void LlenarGrilla()
        {//inicio metodo llenar grilla

            Decimal SumaSubTotal = 0; Decimal SumaIva = 0; Decimal SumaTotal = 0; decimal Subtotal = 0;
            dataVentas.Rows.Clear();
            //contador = lst.Count;
            for (int i = 0; i < lst.Count; i++)
                //while (i <= lst.Count)
            {
                dataVentas.Rows.Add();
                //dataVentas.Rows[i].Cells[0].Value = lst[i].Id_cliente;
                //dataVentas.Rows[i].Cells[1].Value = lst[i].Id_factura;
                //dataVentas.Rows[i].Cells[2].Value = lst[i].Numero_factura;
                //dataVentas.Rows[i].Cells[3].Value = lst[i].Comprobante_exposicion;
                //dataVentas.Rows[i].Cells[4].Value = lst[i].Id_factura;
                //dataVentas.Rows[i].Cells[5].Value = lst[i].Id_cliente;
                //dataVentas.Rows[i].Cells[6].Value = lst[i].Fecha_venta;
                //dataVentas.Rows[i].Cells[0].Value = lst[i].Id_producto;
                dataVentas.Rows[i].Cells[1].Value = lst[i].Cantidad_producto;
                //SumaIgv = Convert.ToDecimal(dataVentas1.Rows[i].Cells[1].Value);
                dataVentas.Rows[i].Cells[2].Value = lst[i].Descripcion_producto;
                dataVentas.Rows[i].Cells[3].Value = lst[i].Precio_producto;
                Subtotal = Convert.ToDecimal(dataVentas.Rows[i].Cells[3].Value = lst[i].Precio_producto) * Convert.ToInt32(lst[i].Cantidad_producto);
                dataVentas.Rows[i].Cells[4].Value = Subtotal;
                


                //dataVentas1.Rows.Add();
                //MessageBox.Show("el indice es:" + i);
                //MessageBox.Show("La cantidad de elementos de la lista:" + contador);
                //MessageBox.Show("el PrecioProducto es" + SumaIgv);
                SumaSubTotal += Convert.ToDecimal(dataVentas.Rows[i].Cells[4].Value);
                MessageBox.Show("El Subtotal es: " + SumaSubTotal);
                //SumaTotal += Convert.ToDecimal(dataVentas.Rows[i].Cells[4].Value);
                //SumaIva += Convert.ToDecimal(dataVentas.Rows[i].Cells[3].Value);
                //Console.ReadKey();
            }
            dataVentas.Rows.Add();
            dataVentas.Rows.Add();
            dataVentas.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
            dataVentas.Rows.Add();
            dataVentas.Rows[lst.Count + 2].Cells[3].Value = "      I.V.A.        %";
            //dataVentas.Rows[lst.Count + 2].Cells[4].Value = "SumaIva";
            //dataVentas.Rows[lst.Count + 2].Cells[4].Value = SumaIva;
            dataVentas.Rows.Add();
            dataVentas.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
            //dataVentas += SumaSubTotal + SumaIgv;
            SumaTotal += SumaSubTotal;
            dataVentas.Rows[lst.Count + 1].Cells[4].Value = SumaTotal;
            dataVentas.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
            this.lblTotal.Text = "Total:" + "$" + Convert.ToString(SumaTotal);
            //dataVentas.Rows[lst.Count + 3].Cells[4].Value = "SumaTotal";
            dataVentas.ClearSelection();

            //dataGridView1.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;





        }//fin metodo llenar grilla

        private void DesabilitarCliente()
        {
            this.lblCliente.Text = "";
            this.lblHabilitado.Text = "";
        }
        
        //Metodo actualizar radio bootons
        
        private void ActualizarRadioBootons()
        {
            this.rbnContado.Enabled = true;
        }        

        private void txtBuscarApellido_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
            LimpiarClienteInhabilitado();
        }

        private void dataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Mostrar cliente");
            BuscarClienteInhabilitado(Convert.ToBoolean(this.dataCliente.CurrentRow.Cells[8].Value.ToString()));
            this.lblCliente.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["apellido"].Value) + " " + Convert.ToString(this.dataCliente.CurrentRow.Cells["nombre"].Value);
            this.txtIdentificador.Text = Convert.ToString(this.dataCliente.CurrentRow.Cells["id_cliente"].Value);
        }

        private void btnBusarCliente_Click(object sender, EventArgs e)
        {
            this.BuscarDni();
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            this.BuscarProductoVentas();
        }

        private void dataListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Mostrar stock de producto seleccionado");
            this.lblStock.Text = "Stock: " + Convert.ToString(this.dataListadoProductos.CurrentRow.Cells["stock"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CargarVentas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProductos_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.Yellow;
        }

        private void txtBuscarProductos_MouseEnter(object sender, EventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.Yellow;
        }

        private void txtBuscarProductos_MouseLeave(object sender, EventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.White;
        }

        private void txtBuscarProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.Yellow;
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto C = new FrmProducto();
            C.Show();
        }

        private void txtBuscarProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Presione la tecla tabulador");
            }
        }

        private void txtBuscarProductos_TextChanged_1(object sender, EventArgs e)
        {
            this.BuscarProductoVentas();
        }

        private void txtBuscarProductos_MouseDown_1(object sender, MouseEventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.Yellow;
        }

        private void txtBuscarProductos_MouseEnter_1(object sender, EventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.Yellow;
        }

        private void txtBuscarProductos_MouseLeave_1(object sender, EventArgs e)
        {
            this.txtBuscarProductos.BackColor = Color.White;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.CargarVentas();
        }

        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            LimpiarClienteInhabilitado();
        }

        private void btnProductoNuevo_Click_1(object sender, EventArgs e)
        {
            FrmProducto C = new FrmProducto();
            C.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCliente D = new FrmCliente();
            D.Show();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.ActualizarRadioBootons();
        }

        private void rbnCtaCte_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy haciendo click en el radio butons");
            if (this.rbnCtaCte.Enabled == true)
            {
                if (this.txtIdentificador.Text != string.Empty)
                {
                    MessageBox.Show("Debe seleccionar primero el cliente");
                    this.rbnContado.Enabled = true;
                }
            }
        }
    }//fin clase
}//fin capa
