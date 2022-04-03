using _3_Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace _2_Logica.Logica
{
    internal class CLS_L_Deporte
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Angel); }

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
    }
}
