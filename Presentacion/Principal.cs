using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class Principal : Form
    {
        NegProducto DatosProducto = new NegProducto();
        NegCategoria DatosCategoria = new NegCategoria();
        Producto NvoProducto;
        Producto OldProducto;


        public Principal()
        {
            InitializeComponent();
            CrearDGV();
            CargarDGV();
            LlenarCBX();
            tb_AgNombre.Focus();
        }

        //Crear el DataGridView
        private void CrearDGV()
        {
            dgv_Principal.Columns.Add("0", "id");
            dgv_Principal.Columns.Add("1", "Producto");
            dgv_Principal.Columns.Add("2", "Categoria");
            dgv_Principal.Columns.Add("3", "Categoria");
            dgv_Principal.Columns.Add("4", "Últ. Act.");
            dgv_Principal.Columns.Add("5", "Cant.");
            dgv_Principal.Columns.Add("6", "Descripción");

            dgv_Principal.Columns[0].Width = 10;
            dgv_Principal.Columns[1].Width = 140;
            dgv_Principal.Columns[2].Width = 10;
            dgv_Principal.Columns[3].Width = 100;
            dgv_Principal.Columns[4].Width = 80;
            dgv_Principal.Columns[5].Width = 40;
            dgv_Principal.Columns[6].Width = 10;

            dgv_Principal.Columns[0].Visible = false;
            dgv_Principal.Columns[2].Visible = false;
            dgv_Principal.Columns[6].Visible = false;
        }

        //Cargar el DataGridView
        private void CargarDGV()
        {
            dgv_Principal.Rows.Clear();

            DataSet ds = new DataSet();
            ds = DatosProducto.listaDeProd("Cargar");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Principal.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString(), dr[3], dr[4].ToString(), dr[5].ToString(), dr[6]);
                }
            }
            else
                MessageBox.Show("No hay datos cargados.");
        }

        //Cargar los ComboBox
        void LlenarCBX()
        {
            cb_AgCategoria.DataSource = DatosCategoria.ObtenerCat();
            cb_AgCategoria.DisplayMember = "p_CatProd";
            cb_AgCategoria.ValueMember = "p_idCat";

            cb_EdCategoria.DataSource = DatosCategoria.ObtenerCat();
            cb_EdCategoria.DisplayMember = "p_CatProd";
            cb_EdCategoria.ValueMember = "p_idCat";

            cb_BoCategoria.DataSource = DatosCategoria.ObtenerCat();
            cb_BoCategoria.DisplayMember = "p_CatProd";
            cb_BoCategoria.ValueMember = "p_idCat";
        }

        //Función del Buscador
        private void btn_BusqBuscar_Click(object sender, EventArgs e)
        {
            if (tb_Buscar.Text != "")
            {
                dgv_Principal.Rows.Clear();

                DataSet ds = new DataSet();
                ds = DatosProducto.buscaDeProd("Buscar", tb_Buscar.Text);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dgv_Principal.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString(), dr[3], dr[4].ToString(), dr[5].ToString(), dr[6]);
                    }
                }
                else
                {
                    lbl_Notificaciones.Text = "LA BÚSQUEDA NO ARROJA DATOS.";
                    Refresh();
                    LimpiarNotificaciones();
                }
            }
            else
            {
                lbl_Notificaciones.Text = "COMPLETA EL CUADRO DE BÚSQUEDA.";
                Refresh();
                LimpiarNotificaciones();
            }
        }
        private void btn_BusqBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormBuscar();
        }

        //Radio buttons
        private void rb_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            gb_Borrar.Enabled = false;
            gb_Borrar.Visible = false;
            gb_Editar.Enabled = false;
            gb_Editar.Visible = false;
            gb_Agregar.Enabled = true;
            gb_Agregar.Visible = true;

            LimpiarFormAgregar();
            LimpiarFormEditar();
            LimpiarFormBorrar();
        }
        private void rb_Editar_CheckedChanged(object sender, EventArgs e)
        {
            gb_Borrar.Enabled = false;
            gb_Borrar.Visible = false;
            gb_Editar.Enabled = true;
            gb_Editar.Visible = true;
            gb_Agregar.Enabled = false;
            gb_Agregar.Visible = false;

            LimpiarFormAgregar();
            LimpiarFormEditar();
            LimpiarFormBorrar();

        }
        private void rb_Borrar_CheckedChanged(object sender, EventArgs e)
        {
            gb_Borrar.Enabled = true;
            gb_Borrar.Visible = true;
            gb_Editar.Enabled = false;
            gb_Editar.Visible = false;
            gb_Agregar.Enabled = false;
            gb_Agregar.Visible = false;

            LimpiarFormAgregar();
            LimpiarFormEditar();
            LimpiarFormBorrar();

        }

        //Botón Cerrar
        private void lbl_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cuadro de notificaciones
        private void LimpiarNotificaciones()
        {
            Thread.Sleep(5000);
            lbl_Notificaciones.Text = "";
            Refresh();
        }

        //Limpiar Formularios
        private void LimpiarFormAgregar()
        {
            tb_AgNombre.Clear();
            cb_AgCategoria.SelectedIndex = 0;
            dtp_AgFecha.Text = DateTime.Now.ToString();
            nud_AdCant.Value = 0;
            tb_AgDescripcion.Clear();
            CargarDGV();
            tb_AgNombre.Focus();
        }
        private void LimpiarFormEditar()
        {
            tb_EdNombre.Clear();
            cb_EdCategoria.SelectedIndex = 0;
            dtp_EdFecha.Text = DateTime.Now.ToString();
            nud_EdCant.Value = 0;
            tb_EdDescripcion.Clear();
            btn_EdEditar.Enabled = false;
            CargarDGV();
        }
        private void LimpiarFormBorrar()
        {
            tb_BoNombre.Clear();
            cb_BoCategoria.Text = "";
            dtp_BoFecha.Text = DateTime.Now.ToString();
            nud_BoCant.TabIndex = 0;
            tb_BoDescripcion.Clear();
            btn_BoBorrar.Enabled = false;
            CargarDGV();
        }
        private void LimpiarFormBuscar()
        {
            CargarDGV();
            tb_Buscar.Clear();
            tb_Buscar.Focus();
        }

        //Seleccionar un producto en el DataGridView
        private void dgv_Principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OldProducto = new Producto(Convert.ToInt32(dgv_Principal.CurrentRow.Cells[0].Value), dgv_Principal.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dgv_Principal.CurrentRow.Cells[2].Value), DateTime.Parse(dgv_Principal.CurrentRow.Cells[4].Value.ToString()), Convert.ToInt32(dgv_Principal.CurrentRow.Cells[5].Value), dgv_Principal.CurrentRow.Cells[6].Value.ToString());

            DataSet ds = new DataSet();

            ds = DatosProducto.listaDeProd(OldProducto.p_idProd.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (rb_Editar.Checked)
                {
                    tb_EdNombre.Text = OldProducto.p_prod;
                    cb_EdCategoria.SelectedValue = OldProducto.p_idCat;
                    dtp_EdFecha.Value = OldProducto.p_fecha;
                    nud_EdCant.Value = OldProducto.p_cant;
                    tb_EdDescripcion.Text = OldProducto.p_desc;

                    btn_EdEditar.Enabled = true;

                    tb_EdNombre.Focus();
                }
                if (rb_Borrar.Checked)
                {
                    tb_BoNombre.Text = OldProducto.p_prod;
                    cb_BoCategoria.SelectedValue = OldProducto.p_idCat;
                    dtp_BoFecha.Value = OldProducto.p_fecha;
                    nud_BoCant.Value = OldProducto.p_cant;
                    tb_BoDescripcion.Text = OldProducto.p_desc;

                    btn_BoBorrar.Enabled = true;

                    btn_BoBorrar.Focus();
                }
            }
        }

        //Sección Agregar
        private void btn_AgAgregar_Click(object sender, EventArgs e)
        {
            if (tb_AgNombre.Text != "" && nud_AdCant.Text != "" && tb_AgDescripcion.Text != "")
            {
                int nGrabados = -1;


                NvoProducto = new Producto(tb_AgNombre.Text, Convert.ToInt32(cb_AgCategoria.SelectedValue), DateTime.Parse(dtp_AgFecha.Text), Convert.ToInt32(nud_AdCant.Text), tb_AgDescripcion.Text);

                nGrabados = DatosProducto.ABM_Producto("Agregar", NvoProducto);

                if (nGrabados == -1)
                {
                    lbl_Notificaciones.Text = "NO SE PUEDE GRABAR PRODUCTO.";
                    Refresh();
                    LimpiarNotificaciones();
                }
                else
                {
                    lbl_Notificaciones.Text = "PRODUCTO GRABADO CORRECTAMENTE.";
                    Refresh();
                    CargarDGV();
                    LimpiarFormAgregar();
                    LimpiarNotificaciones();
                }
            }
            else
            {
                lbl_Notificaciones.Text = "DEBES COMPLETAR TODOS LOS DATOS.";
                Refresh();
                LimpiarNotificaciones();
            }

            
        }
        private void btn_AgLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormAgregar();
        }

        //Sección Editar
        private void btn_EdEditar_Click(object sender, EventArgs e)
        {
            if (tb_EdNombre.Text != "" && nud_EdCant.Text != "" && tb_EdDescripcion.Text != "")
            {
                OldProducto.p_prod = tb_EdNombre.Text;
                OldProducto.p_idCat = Convert.ToInt32(cb_EdCategoria.SelectedValue);
                OldProducto.p_fecha = DateTime.Today;
                OldProducto.p_cant = Convert.ToInt32(nud_EdCant.Value);
                OldProducto.p_desc = tb_EdDescripcion.Text;

                int nResultado = -1;

                nResultado = DatosProducto.ABM_Producto("Editar", OldProducto);
                if (nResultado != -1)
                {
                    lbl_Notificaciones.Text = "PRODUCTO MODIFICADO EXITOSAMENTE.";
                    Refresh();
                    CargarDGV();
                    LimpiarFormEditar();
                    LimpiarNotificaciones();
                }
                else
                {
                    lbl_Notificaciones.Text = "NO SE PUEDE MODIFICAR EL PRODUCTO.";
                    Refresh();
                    LimpiarNotificaciones();
                }
            }
            else
            {
                lbl_Notificaciones.Text = "DEBES COMPLETAR TODOS LOS DATOS.";
                Refresh();
                LimpiarNotificaciones();
            }
        }
        private void btn_EdLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormEditar();
        }

        //Sección Borrar
        private void btn_BoBorrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quieres eliminar este Producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                int nResultado = -1;

                nResultado = DatosProducto.ABM_Producto("Borrar", OldProducto);
                if (nResultado != -1)
                {
                    lbl_Notificaciones.Text = "EL PRODUCTO HA SIDO ELIMINADO.";
                    Refresh();
                    CargarDGV();
                    LimpiarFormBorrar();
                    LimpiarNotificaciones();
                }
                else
                {
                    lbl_Notificaciones.Text = "NO SE PUEDE BORRAR EL PRODUCTO.";
                    Refresh();
                    LimpiarNotificaciones();
                }
            }
        }
        private void btn_BoLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormBorrar();
        }      
    }
}

