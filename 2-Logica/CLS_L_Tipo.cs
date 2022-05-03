using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using _3_Entidades;

namespace _2_Logica
{
    public class CLS_L_Tipo
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Damian); }
        
        //METODO PARA INSERTAR TIPO ACTIVIDAD//
        public bool Insertar_Tipo(ref CLS_TipoActividad obj_tipoActividad) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_TIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
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
        //METODO PARA OBTENER LOS TIPOS DE ACTIVIDAD//
        public bool ObtenerTipos(ref List<CLS_TipoActividad> lista_tipo)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_TIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0)
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        lista_tipo.Add(ConvertirTipo(reader));
                    }
                }
                return true;
            }
            catch (Exception error)
            {
                CLS_TipoActividad obj_tipo = new CLS_TipoActividad();
                obj_tipo.Error = error.Message;
                lista_tipo.Add(obj_tipo);
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA AGREGAR LOS TIPOS DE ACTIVIDAD A LA LISTA TIPO ACTIVIDAD//
        private CLS_TipoActividad ConvertirTipo(IDataReader reader)
        {
            CLS_TipoActividad obj_tipo = new CLS_TipoActividad();

            obj_tipo.IdTipo = Convert.ToInt32(reader["IdTipo"].ToString());
            obj_tipo.Nombre = reader["Nombre"].ToString();
            obj_tipo.Descripcion = reader["Descripcion"].ToString();

            return obj_tipo;
        }
    }
}
