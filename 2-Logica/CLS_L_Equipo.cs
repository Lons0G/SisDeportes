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
    public class CLS_L_Equipo
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Angel); }

        //METODO PARA INSERTAR EQUIPO//
        public bool Insertar_Equipo(ref CLS_Equipo obj_equipo)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_EQUIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdUsuario", obj_equipo.IdUsuario);
                comando.Parameters.AddWithValue("@IdDeporte", obj_equipo.IdDeporte);
                comando.Parameters.AddWithValue("@IdCategoria", obj_equipo.IdCategoria);
                comando.Parameters.AddWithValue("@IdEntrenador", obj_equipo.IdEntrenador);
                comando.Parameters.AddWithValue("@Nombre", obj_equipo.Nombre);
                comando.Parameters.AddWithValue("@Visitante", obj_equipo.Visitante);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                obj_equipo.Error = error.Message;
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR EQUIPO
        public bool Editar_Equipo(ref CLS_Equipo obj_equipo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_EQUIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdEquipo", obj_equipo);
                comando.Parameters.AddWithValue("@IdUsuario", obj_equipo.IdUsuario);
                comando.Parameters.AddWithValue("@IdDeporte", obj_equipo.IdDeporte);
                comando.Parameters.AddWithValue("@IdCategoria", obj_equipo.IdCategoria);
                comando.Parameters.AddWithValue("@IdEntrenador", obj_equipo.IdEntrenador);
                comando.Parameters.AddWithValue("@Nombre", obj_equipo.Nombre);
                comando.Parameters.AddWithValue("@Visitante", obj_equipo.Visitante);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_equipo.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR EQUIPO//
        public bool Eliminar_Equipo(ref CLS_Equipo obj_equipo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_EQUIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdEquipo", obj_equipo.IdEquipo);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_equipo.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA MOSTRAR TODOS LOS EQUIPOS//
        public bool ObtenerEquipos(ref List<CLS_Equipo> lista_equipo, int IdUsuario) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_EQUIPOS", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdDeporte", IdUsuario);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0) {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read()) { lista_equipo.Add(ConvertirEquipo(reader)); }
                }
                return true;
            }
            catch (Exception error) {
                CLS_Equipo obj_equipo = new CLS_Equipo();
                obj_equipo.Error = error.Message;
                lista_equipo.Add(obj_equipo);
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA AGREGAR USUARIOS EN LA LISTA DE EQUIPOS//
        private CLS_Equipo ConvertirEquipo(IDataReader reader) {
            CLS_Equipo obj_equipo = new CLS_Equipo();

            obj_equipo.IdEquipo = Convert.ToInt32(reader["IdEquipo"].ToString());
            obj_equipo.IdDeporte = Convert.ToInt32(reader["IdDeporte"].ToString());
            obj_equipo.IdCategoria = Convert.ToInt32(reader["IdCategoria"].ToString());
            obj_equipo.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
            try {
                obj_equipo.IdEntrenador = Convert.ToInt32(reader["IdEntrenador"].ToString());
            }
            catch (Exception error) {
                obj_equipo.IdEntrenador = 0;
            }
            obj_equipo.Visitante = Convert.ToBoolean(reader["Visitante"].ToString());
            obj_equipo.Nombre = reader["Nombre"].ToString();

            return obj_equipo;
        }
    }
}
