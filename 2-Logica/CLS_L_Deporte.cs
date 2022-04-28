using _3_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _2_Logica
{
    public class CLS_L_Deporte
    {
        SqlConnection _conexion;
        //private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Brandon); }

        //METODO PARA INSERTAR DEPORTE//
        public bool Insertar_Deporte(ref CLS_Deporte obj_deporte)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_DEPORTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdUsuario", obj_deporte.IdUsuario);
                comando.Parameters.AddWithValue("@Nombre", obj_deporte.Nombre);
                comando.Parameters.AddWithValue("@IdTipoDeporte", obj_deporte.IdTipoDeporte);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                obj_deporte.Error = error.Message;
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR USUARIO//
        public bool Eliminar_Deporte(ref CLS_Deporte obj_deporte)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_DEPORTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdDeporte", obj_deporte.IdDeporte);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                obj_deporte.Error = error.Message;
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        public bool Obtener_Deportes(List<CLS_Deporte> lista_deportes)
        {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_DEPORTES", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0) {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read()) { lista_deportes.Add(ConvertirDeporte(reader)); }
                }
                return true;
            }
            catch (Exception error) {
                CLS_Deporte obj_deporte = new CLS_Deporte();
                obj_deporte.Error = error.Message;
                lista_deportes.Add(obj_deporte);
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }

        private CLS_Deporte ConvertirDeporte(IDataReader reader) {
            CLS_Deporte obj_deporte = new CLS_Deporte();

            obj_deporte.IdDeporte = Convert.ToInt32(reader["IdDeporte"].ToString());
            obj_deporte.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
            obj_deporte.Nombre = reader["Nombre"].ToString();
            obj_deporte.IdTipoDeporte = Convert.ToInt32(reader["IdTipoDeporte"].ToString());

            return obj_deporte;
        }
    }
}
