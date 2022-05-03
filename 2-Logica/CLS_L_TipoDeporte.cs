using _3_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Logica
{
    public class CLS_L_TipoDeporte
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Angel); }
        
        public bool Insertar_Deporte(ref CLS_TipoDeporte obj_tipo_deporte) {
            try {
                Conexion();
                //AGREGAR EL PROCEDIMIENTO ALMACENADO DE INSERTAR TIPO DERPOTE EN SQL
                SqlCommand comando = new SqlCommand("SP_INSERTAR_TIPO_DEPORTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@Nombre", obj_tipo_deporte.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_tipo_deporte.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        public bool Obtener_TipoDeportes(ref List<CLS_TipoDeporte> lista_deportes) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_TIPO_DEPORTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0) {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read()) { lista_deportes.Add(ConvertirTipoDeporte(reader)); }
                }
                return true;
            }
            catch (Exception error) {
                CLS_TipoDeporte obj_tipo_deporte = new CLS_TipoDeporte();
                obj_tipo_deporte.Error = error.Message;
                lista_deportes.Add(obj_tipo_deporte);
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }

        private CLS_TipoDeporte ConvertirTipoDeporte(IDataReader reader) {
            CLS_TipoDeporte obj_tipo_deporte = new CLS_TipoDeporte();
            obj_tipo_deporte.IdTipoDeporte = Convert.ToInt32(reader["IdTipoDeporte"].ToString());
            obj_tipo_deporte.Nombre = reader["Nombre"].ToString();

            return obj_tipo_deporte;
        }
    }
}
