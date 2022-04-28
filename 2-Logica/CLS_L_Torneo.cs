using _3_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace _2_Logica
{
    public class CLS_L_Torneo
    {
        SqlConnection _conexion;
<<<<<<< HEAD
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Damian); }
=======
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }
>>>>>>> 8e0ea8566c24c1229b6e41a38848284d82c053f3
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
                _conexion.Open();
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
                _conexion.Open();
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
                _conexion.Open();
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
        public bool ObtenerTorneos(ref List<CLS_Torneo> lista_torneo)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_TORNEOS", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //COLOCAR EL ID DEPORTE DEL USUARIO//
                comando.Parameters.AddWithValue("@IdDeporte", 1);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0)
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        lista_torneo.Add(ConvertirTorneo(reader));
                    }
                }
                return true;
            }
            catch (Exception error)
            {
                CLS_Torneo obj_torneo = new CLS_Torneo();
                obj_torneo.Error = error.Message;
                lista_torneo.Add(obj_torneo);
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA AGREGAR USUARIOS EN LA LISTA DE USUARIOS//
        private CLS_Torneo ConvertirTorneo(IDataReader reader)
        {
            CLS_Torneo obj_torneo = new CLS_Torneo();

            obj_torneo.IdTorneo = Convert.ToInt32(reader["IdTorneo"].ToString());
            obj_torneo.Nombre = reader["Nombre"].ToString();
            obj_torneo.Fecha = Convert.ToDateTime(reader["Fecha"].ToString());
            obj_torneo.IdCategoria = Convert.ToInt32(reader["IdCategoria"].ToString());
            obj_torneo.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
            obj_torneo.IdTipo = Convert.ToInt32(reader["IdTipo"].ToString());
            obj_torneo.IdDeporte = Convert.ToInt32(reader["IdDeporte"].ToString());

            return obj_torneo;
        }
    }
}
