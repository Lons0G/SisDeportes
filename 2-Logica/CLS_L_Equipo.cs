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
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }

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
        public bool Editar_Usuario(ref CLS_Equipo obj_equipo) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_EQUIPO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
    }
}
