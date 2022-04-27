using System;
using System.Data;
using System.Data.SqlClient;
using _3_Entidades;

namespace _2_Logica
{
    public class CLS_L_Actividad
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }

        //METODO PARA INSERTAR UNA ACTIVIDAD
        public bool Insertar_Actividad(ref CLS_Actividad obj_actividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_Actividad", _conexion)
                {
                    CommandType = CommandType.StoredProcedure 
                };
                comando.Parameters.AddWithValue("@Fecha", obj_actividad.Fecha);
                comando.Parameters.AddWithValue("@Hora", obj_actividad.Hora);
                comando.Parameters.AddWithValue("@IdContricante_1", obj_actividad.IdContricante_1);
                comando.Parameters.AddWithValue("@IdContricante_2", obj_actividad.IdContricante_2);
                comando.Parameters.AddWithValue("@Categoria", obj_actividad.IdCategoria);
                comando.Parameters.AddWithValue("@IdUsuario", obj_actividad.IdUsuario);
                comando.Parameters.AddWithValue("@IdDeporte", obj_actividad.IdDeporte);
                comando.Parameters.AddWithValue("@IdTipo", obj_actividad.IdTipo);
                comando.Parameters.AddWithValue("@IdTorneo", obj_actividad.IdTorneo);
                comando.Parameters.AddWithValue("@Nombre", obj_actividad.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_actividad.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR ACTIVIDAD//
        public bool Editar_Actividad(ref CLS_Actividad obj_actividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_ACTIVIDAD", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdActividad", obj_actividad.IdActividad);
                comando.Parameters.AddWithValue("@Fecha", obj_actividad.Fecha);
                comando.Parameters.AddWithValue("@Hora", obj_actividad.Hora);
                comando.Parameters.AddWithValue("@IdContricante_1", obj_actividad.IdContricante_1);
                comando.Parameters.AddWithValue("@IdContricante_2", obj_actividad.IdContricante_2);
                comando.Parameters.AddWithValue("@IdCategoria", obj_actividad.IdCategoria);
                comando.Parameters.AddWithValue("@IdUsuario", obj_actividad.IdUsuario);
                comando.Parameters.AddWithValue("@IdDeporte", obj_actividad.IdDeporte);
                comando.Parameters.AddWithValue("@IdTipo", obj_actividad.IdTipo);
                comando.Parameters.AddWithValue("@IdTorneo", obj_actividad.IdTorneo);
                comando.Parameters.AddWithValue("@Nombre", obj_actividad.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_actividad.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR ACTIVIDAD//
        public bool Eliminar_Actividad(ref CLS_Actividad obj_actividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_ACTIVIDAD", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdActividad", obj_actividad.IdActividad);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_actividad.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }

    }
}
