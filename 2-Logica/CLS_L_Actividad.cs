using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using _3_Entidades;

namespace _2_Logica
{
    public class CLS_L_Actividad
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Angel); }

        //METODO PARA INSERTAR UNA ACTIVIDAD
        public bool Insertar_Actividad(ref CLS_Actividad obj_actividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_Actividad", _conexion)
                {
                    CommandType = CommandType.StoredProcedure 
                };
                _conexion.Open();
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
                _conexion.Open();
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
                _conexion.Open();
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
        public bool ObtenerActividades(ref List<CLS_Actividad> lista_actividad, int id_deporte)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_ACTIVIDAD", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdDeporte", id_deporte);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0)
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        lista_actividad.Add(ConvertirActividad(reader));
                    }
                }
                return true;
            }
            catch (Exception error)
            {
                CLS_Actividad obj_Actividad = new CLS_Actividad();
                obj_Actividad.Error = error.Message;
                lista_actividad.Add(obj_Actividad);
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA AGREGAR ACTIVIDADES EN LA LISTA DE USUARIOS//
        private CLS_Actividad ConvertirActividad(IDataReader reader)
        {
            CLS_Actividad obj_Actividad = new CLS_Actividad();

            obj_Actividad.IdActividad = Convert.ToInt32(reader["IDActividad"].ToString());
            obj_Actividad.Fecha = Convert.ToDateTime(reader["Fecha"].ToString());
            obj_Actividad.Hora = Convert.ToDateTime(reader["Hora"].ToString());
            obj_Actividad.IdContricante_1 = Convert.ToInt32(reader["IdContricante_1"].ToString());
            obj_Actividad.IdContricante_2 = Convert.ToInt32(reader["IdContricante_2"].ToString());
            obj_Actividad.IdCategoria = Convert.ToInt32(reader["IdCategoria"].ToString());
            obj_Actividad.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
            obj_Actividad.IdDeporte = Convert.ToInt32(reader["IdDeporte"].ToString());
            obj_Actividad.IdTipo = Convert.ToInt32(reader["IdTipo"].ToString());
            try { obj_Actividad.IdTorneo = Convert.ToInt32(reader["IdTorneo"].ToString()); }
            catch (Exception) { obj_Actividad.IdTorneo = 0; }
            obj_Actividad.Nombre = reader["Nombre"].ToString();

            return obj_Actividad;
        }

    }
}
