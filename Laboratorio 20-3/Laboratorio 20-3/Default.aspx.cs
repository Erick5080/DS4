using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_3
{
    public partial class _Default : Page
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["ProductosDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["esNuevo"] = false;
                HabilitarControles(false);
            }
        }
        private void HabilitarControles(bool habilitarEdicion)
        {
            txtNombre.Enabled = habilitarEdicion;
            txtPrecio.Enabled = habilitarEdicion;
            txtStock.Enabled = habilitarEdicion;

            btnNuevo.Enabled = !habilitarEdicion;
            btnGuardar.Enabled = habilitarEdicion;
            btnCancelar.Enabled = habilitarEdicion;
            btnEliminar.Enabled = habilitarEdicion && !(bool)Session["esNuevo"]; // No se puede eliminar si es nuevo

            tstId.Enabled = !habilitarEdicion;
            btnBuscar.Enabled = !habilitarEdicion;

            if (!habilitarEdicion)
            {
                txtId.Text = string.Empty;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            tstId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            lblMensaje.Text = string.Empty;
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarControles(true);
            Session["esNuevo"] = true;
            txtNombre.Focus();
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tstId.Text))
            {
                lblMensaje.Text = "<p class='alert alert-warning'>Ingrese un ID para buscar.</p>";
                return;
            }

            string sql = "SELECT ID, Nombre, Precio, Stock FROM LAPTOPS WHERE ID=@ID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", tstId.Text);
                    con.Open();

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               txtId.Text = reader["ID"].ToString();
                                txtNombre.Text = reader["Nombre"].ToString();
                                txtPrecio.Text = reader["Precio"].ToString();
                                txtStock.Text = reader["Stock"].ToString();

                                Session["esNuevo"] = false;
                                HabilitarControles(true);
                                btnEliminar.Enabled = true; // Habilitar eliminación
                                lblMensaje.Text = "<p class='alert alert-success'>Registro encontrado.</p>";
                            }
                            else
                            {
                               LimpiarCampos();
                                lblMensaje.Text = "<p class='alert alert-info'>Ningún registro encontrado con el Id ingresado.</p>";
                                HabilitarControles(false); // Mantener en estado inicial
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = $"<p class='alert alert-danger'>Error al buscar: {ex.Message}</p>";
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql;
            bool esNuevo = (bool)Session["esNuevo"];
            string msg;
            bool success = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                lblMensaje.Text = "<p class='alert alert-danger'>Todos los campos son obligatorios.</p>";
                return;
            }
            if (esNuevo)
            {
                sql = "INSERT INTO LAPTOPS (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock)"; // <-- Falta SCOPE_IDENTITY()
            }
            else
            {
                sql = "UPDATE LAPTOPS SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock WHERE ID=@ID";
            }
        
        using (SqlConnection con = new SqlConnection(connectionString))
        {
          using (SqlCommand cmd = new SqlCommand(sql, con))
          {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));

                    if (!esNuevo)
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtId.Text));
                    }

                    con.Open();
                    try
                    {
                        if (esNuevo)
                        {
                            object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int newId = Convert.ToInt32(result);
                            msg = $"Registro creado exitosamente. ID generado: {newId}";
                            txtId.Text = newId.ToString(); // Mostrar el nuevo ID en el campo
                            success = true;
                        }
                        else
                        {
                            msg = "Error al crear el registro: El ID no pudo ser recuperado.";
                            success = false;
                        }
                    }
                        else
                        {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            {
                            msg = "Registro actualizado exitosamente.";
                            success = true;
                            }
                            else
                            {
                            msg = "No se realizaron cambios.";
                            success = true; 
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    msg = $"Error al guardar: {ex.Message}";
                    success = false;
                    }
                }
            lblMensaje.Text = $"<p class='alert alert-{(success ? "success" : "danger")}'>{msg}</p>";

            if (success)
            {
                if ((bool)Session["esNuevo"])
                {
                    txtNombre.Text = string.Empty;
                    txtPrecio.Text = string.Empty;
                    txtStock.Text = string.Empty;
                }
                else 
                {
                    LimpiarCampos();
                }

                HabilitarControles(false);
                Session["esNuevo"] = false;
            }
        }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                lblMensaje.Text = "<p class='alert alert-warning'>Debe haber un ID cargado para eliminar.</p>";
                return;
            }

            string sql = "DELETE FROM LAPTOPS WHERE ID=@ID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtId.Text));
                    con.Open();
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lblMensaje.Text = "<p class='alert alert-success'>Registro eliminado exitosamente.</p>";
                        }
                        else
                        {
                            lblMensaje.Text = "<p class='alert alert-warning'>El registro no pudo ser eliminado (tal vez ya no existe).</p>";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = $"<p class='alert alert-danger'>Error al eliminar: {ex.Message}</p>";
                        return;
                    }
                }
            }

            LimpiarCampos();
            HabilitarControles(false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
        LimpiarCampos();
        HabilitarControles(false);
        Session["esNuevo"] = false;
        }


        protected void btnSalir_Click(object sender, EventArgs e)
        {
        Response.Redirect("~/");
        }
    }
}