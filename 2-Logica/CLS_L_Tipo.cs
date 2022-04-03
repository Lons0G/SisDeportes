using System;
using System.Data;
using System.Data.SqlClient;
using _3_Entidades;

namespace _2_Logica.Logica
{
    internal class CLS_L_Tipo
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Angel); }
        //METODO PARA INSERTAR TIPO ACTIVIDAD//
        public bool Insertar_Tipo(ref CLS_TipoActividad obj_tipoActividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_TIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@Descripcion", obj_tipoActividad.Descripcion);
                comando.Parameters.AddWithValue("@Nombre", obj_tipoActividad.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_tipoActividad.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR TIPO ACTIVIDAD//
        public bool Editar_Tipo(ref CLS_TipoActividad obj_tipoActividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_TIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdTipo", obj_tipoActividad.IdTipo);
                comando.Parameters.AddWithValue("@Descripcion", obj_tipoActividad.Descripcion);
                comando.Parameters.AddWithValue("@Nombre", obj_tipoActividad.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_tipoActividad.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR TIPO ACTIVIDAD//
        public bool Eliminar_Tipo(ref CLS_Torneo obj_torneo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_TIPO", _conexion)
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
