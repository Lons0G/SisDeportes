using _3_Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
namespace _2_Logica.Logica
{
    internal class CLS_L_Torneo
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion); }
        //METODO PARA INSERTAR TORNEO//
        public bool Insertar_Torneo(ref CLS_Torneo obj_torneo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_TORNEO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@Fecha", obj_torneo.Fecha);
                comando.Parameters.AddWithValue("@IdCategoria", obj_torneo.IdCategoria);
                comando.Parameters.AddWithValue("@IdUsuario", obj_torneo.IdUsuario);
                comando.Parameters.AddWithValue("@IdTipo", obj_torneo.IdTipo);
                comando.Parameters.AddWithValue("@Nombre", obj_torneo.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_torneo.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR TORNEO//
        public bool Editar_Torneo(ref CLS_Torneo obj_torneo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_TORNEO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdTorneo", obj_torneo.IdTorneo);
                comando.Parameters.AddWithValue("@Fecha", obj_torneo.Fecha);
                comando.Parameters.AddWithValue("@IdCategoria", obj_torneo.IdCategoria);
                comando.Parameters.AddWithValue("@IdUsuario", obj_torneo.IdUsuario);
                comando.Parameters.AddWithValue("@IdTipo", obj_torneo.IdTipo);
                comando.Parameters.AddWithValue("@Nombre", obj_torneo.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_torneo.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR TORNEO//
        public bool Eliminar_Torneo(ref CLS_Torneo obj_torneo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_TORNEO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdTorneo", obj_torneo.IdTorneo);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_torneo.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
    }
}
