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
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Brandon); }

        //METODO PARA INSERTAR INTEGRANTE//
        public bool Insertar_Integrante(ref CLS_Integrantes obj_integrante) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_INTEGRANTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdEquipo", obj_integrante.IdEquipo);
                comando.Parameters.AddWithValue("@IdUsuario", obj_integrante.IdUsuario);
                comando.Parameters.AddWithValue("@IdEntrenador", obj_integrante.IdEntrenador);
                comando.Parameters.AddWithValue("@Nombre", obj_integrante.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj_integrante.Apellido);
                comando.Parameters.AddWithValue("@Edad", obj_integrante.Edad);
                comando.Parameters.AddWithValue("@Nacionalidad", obj_integrante.Nacionalidad);
                comando.Parameters.AddWithValue("@Posicion", obj_integrante.Posicion);
                comando.Parameters.AddWithValue("@Dorsal", obj_integrante.Dorsal);
                comando.Parameters.AddWithValue("@Rol", obj_integrante.Rol);
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
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdIntegrante", obj_integrante.IdIntegrante);
                comando.Parameters.AddWithValue("@IdEquipo", obj_integrante.IdEquipo);
                comando.Parameters.AddWithValue("@IdUsuario", obj_integrante.IdUsuario);
                comando.Parameters.AddWithValue("@IdEntrenador", obj_integrante.IdEntrenador);
                comando.Parameters.AddWithValue("@Nombre", obj_integrante.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj_integrante.Apellido);
                comando.Parameters.AddWithValue("@Edad", obj_integrante.Edad);
                comando.Parameters.AddWithValue("@Nacionalidad", obj_integrante.Nacionalidad);
                comando.Parameters.AddWithValue("@Posicion", obj_integrante.Posicion);
                comando.Parameters.AddWithValue("@Dorsal", obj_integrante.Dorsal);
                comando.Parameters.AddWithValue("@Rol", obj_integrante.Rol);
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
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdIntegrante", obj_integrante.IdIntegrante);
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
        public bool ObtenerIntegrantes(ref List<CLS_Integrantes> lista_integrante, int id_equipo)
        {
            try
            {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_INTEGRANTE", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdEquipo", id_equipo);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0)
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        lista_integrante.Add(ConvertirIntegrante(reader));
                    }
                }
                return true;
            }
            catch (Exception error)
            {
                CLS_Integrantes obj_integrante = new CLS_Integrantes();
                obj_integrante.Error = error.Message;
                lista_integrante.Add(obj_integrante);
                return false;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA AGREGAR USUARIOS EN LA LISTA DE USUARIOS//
        private CLS_Integrantes ConvertirIntegrante(IDataReader reader)
        {
            CLS_Integrantes obj_integrante = new CLS_Integrantes();

            obj_integrante.IdIntegrante = Convert.ToInt32(reader["IdIntegrante"].ToString());
            obj_integrante.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
            obj_integrante.IdEquipo = Convert.ToInt32(reader["IdEquipo"].ToString());
            try { obj_integrante.IdEntrenador = Convert.ToInt32(reader["IdEntrenador"].ToString()); }
            catch (Exception error) { obj_integrante.IdEntrenador = 0; }
            obj_integrante.Nombre = reader["Nombre"].ToString();
            obj_integrante.Apellido = reader["Apellido"].ToString();
            obj_integrante.Edad = Convert.ToByte(reader["Edad"].ToString());
            obj_integrante.Nacionalidad = reader["Nacionalidad"].ToString();
            obj_integrante.Posicion = reader["Posicion"].ToString();
            obj_integrante.Dorsal = Convert.ToInt32(reader["Dorsal"].ToString());
            obj_integrante.Rol = reader["Rol"].ToString();

            return obj_integrante;
        }
    }
}
