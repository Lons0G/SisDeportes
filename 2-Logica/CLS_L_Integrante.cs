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
    public class CLS_L_Integrante
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }

        //METODO PARA INSERTAR INTEGRANTE//
        public bool Insertar_Integrante(ref CLS_Integrantes obj_integrante) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_INTEGRANTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdEquipo", obj_integrante.IdEquipo);
                comando.Parameters.AddWithValue("@IdUsuario", obj_integrante.IdUsuario);
                comando.Parameters.AddWithValue("@IdEntrenador", obj_integrante.IdEntrenador);
                comando.Parameters.AddWithValue("@Nombre", obj_integrante.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj_integrante.Apellido);
                comando.Parameters.AddWithValue("@Edad", obj_integrante.Edad);
                comando.Parameters.AddWithValue("@Nacionalidad", obj_integrante.Nacionalidad);
                comando.Parameters.AddWithValue("@Posicion", obj_integrante.Posicion);
                comando.Parameters.AddWithValue("@Dorsal", obj_integrante.Dorsal);
                comando.Parameters.AddWithValue("@@IdRol", obj_integrante.IdRol);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_integrante.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR INTEGRANTE//
        public bool Editar_Integrante(ref CLS_Integrantes obj_integrante) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_INTEGRANTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdIntegrante", obj_integrante);
                comando.Parameters.AddWithValue("@IdEquipo", obj_integrante.IdEquipo);
                comando.Parameters.AddWithValue("@IdUsuario", obj_integrante.IdUsuario);
                comando.Parameters.AddWithValue("@IdEntrenador", obj_integrante.IdEntrenador);
                comando.Parameters.AddWithValue("@Nombre", obj_integrante.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj_integrante.Apellido);
                comando.Parameters.AddWithValue("@Edad", obj_integrante.Edad);
                comando.Parameters.AddWithValue("@Nacionalidad", obj_integrante.Nacionalidad);
                comando.Parameters.AddWithValue("@Posicion", obj_integrante.Posicion);
                comando.Parameters.AddWithValue("@Dorsal", obj_integrante.Dorsal);
                comando.Parameters.AddWithValue("@@IdRol", obj_integrante.IdRol);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_integrante.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR INTEGRANTE//
        public bool Eliminar_Integrante(ref CLS_Integrantes obj_integrante) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_INTEGRANTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdIntegrante", obj_integrante.IdEquipo);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_integrante.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
    }
}
