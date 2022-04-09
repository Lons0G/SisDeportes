using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _1_Presentacion
{
    public partial class Creación_Actividades : Form
    {

        SqlConnection con = new SqlConnection("Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=DB_Deportes;Data Source=DESKTOP-43BVESG");
        
        public Creación_Actividades()
        {
            InitializeComponent();
            Cargar_Deporte();
        }

        private void Creación_Actividades_Load(object sender, EventArgs e)
        {

        }
        public void Cargar_Deporte()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idDeporte,Nombre FROM TBL_Deporte", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                DataRow fila = dt.NewRow();
                fila["Nombre"] = "-Selecciona un Deporte-";
                dt.Rows.InsertAt(fila, 0);

                cmbDeporte.ValueMember = "idDeporte";
                cmbDeporte.DisplayMember = "Nombre";
                cmbDeporte.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void Cargar_Categoria(string idDeporte)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idCategoria,Nombre FROM TBL_Categoria WHERE idDeporte = @idDeporte", con);
                cmd.Parameters.AddWithValue("idDeporte", idDeporte);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                DataRow dr = dt.NewRow();
                dr["Nombre"] = "-Selecciona una Categoria-";
                dt.Rows.InsertAt(dr, 0);

                cmbCategoria.ValueMember = "idCategoria";
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeporte.SelectedValue.ToString() != null)
            {
                string idDeporte = cmbDeporte.SelectedValue.ToString();
                Cargar_Categoria(idDeporte);
            }
        }

        public void Cargar_Contricante1()
        {
            try
            {
                //        con.Open();
                //        SqlCommand cmd = new SqlCommand("SELECT idDeporte,Nombre FROM TBL_Deporte", con);
                //        SqlDataAdapter da = new SqlDataAdapter(cmd);
                //        DataTable dt = new DataTable();
                //        da.Fill(dt);
                //        con.Close();

                //        DataRow fila = dt.NewRow();
                //        fila["Nombre"] = "-Selecciona un Deporte-";
                //        dt.Rows.InsertAt(fila, 0);

                //        cmbDeporte.ValueMember = "idDeporte";
                //        cmbDeporte.DisplayMember = "Nombre";
                //        cmbDeporte.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void Cargar_Contricante2(string idDeporte)
        {
            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand("SELECT idCategoria,Nombre FROM TBL_Categoria WHERE idDeporte = @idDeporte", con);
                //cmd.Parameters.AddWithValue("idDeporte", idDeporte);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //con.Close();

                //DataRow dr = dt.NewRow();
                //dr["Nombre"] = "-Selecciona una Categoria-";
                //dt.Rows.InsertAt(dr, 0);

                //cmbCategoria.ValueMember = "idCategoria";
                //cmbCategoria.DisplayMember = "Nombre";
                //cmbCategoria.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TBL_ACTIVIDAD (idDeporte,Nombre,idCategoria,Fecha,Hora,idContricante_1,idContricante_2) VALUES (@deporte,@nombre,@categoria,@fecha,@hora,@contri1,@contri2)";
            con.Open();
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@deporte", cmbDeporte.Text);
            comando.Parameters.AddWithValue("@nombre", txtActividad.Text);
            comando.Parameters.AddWithValue("@categoria", cmbCategoria.Text);
            comando.Parameters.AddWithValue("@fecha", dtpFecha.Value);
            comando.Parameters.AddWithValue("@hora", cmbHora.Text);
            comando.Parameters.AddWithValue("@contri1", cmbContri1.Text);
            comando.Parameters.AddWithValue("@contri2", cmbContri2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos han sido capturados correctamente");
        }
    }
}
