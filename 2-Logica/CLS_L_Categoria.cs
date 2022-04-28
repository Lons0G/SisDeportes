using _3_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace _2_Logica
{
    public class CLS_L_Categoria
    {
        SqlConnection _conexion;
        //private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Brandon); }
        //METODO PARA INSERTAR CATEGORIA//
        public bool Insertar_Categoria(ref CLS_Categoria obj_categoria) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_CATEGORIA", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _conexion.Open();
                comando.Parameters.AddWithValue("@IdDeporte", obj_categoria.IdDeporte);
                comando.Parameters.AddWithValue("@Nombre", obj_categoria.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_categoria.Error = error.Message;
                return false;
            }
            finally{
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR CATEGORIA//
        public bool Editar_Categoria(ref CLS_Categoria obj_categoria) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_CATEGORIA", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdCategoria", obj_categoria.IdCategoria);
                comando.Parameters.AddWithValue("@IdDeporte", obj_categoria.IdDeporte);
                comando.Parameters.AddWithValue("@Nombre", obj_categoria.Nombre);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_categoria.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR CATEGORIA//
        public bool Eliminar_Categoria(ref CLS_Categoria obj_categoria) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_CATEGORIA", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdCategoria", obj_categoria.IdCategoria);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_categoria.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA OBTENER LAS CATEGORIAS SEGUN EL DEPORTE
        public bool Obtener_Categoria(List<CLS_Categoria> lista_categoria, int id_deporte) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_MOSTRAR_CATEGORIAS", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdDeporte", id_deporte);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0) {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read()) { lista_categoria.Add(ConvertirCategoria(reader)); }
                }
                return true;
            }
            catch (Exception error) {
                CLS_Categoria obj_categoria = new CLS_Categoria();
                obj_categoria.Error = error.Message;
                lista_categoria.Add(obj_categoria);
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }

        private CLS_Categoria ConvertirCategoria(IDataReader reader)
        {
            CLS_Categoria obj_categoria = new CLS_Categoria();
            
            obj_categoria.IdCategoria = Convert.ToInt32(reader["IdCategoria"].ToString());
            obj_categoria.Nombre = reader["Nombre"].ToString();

            return obj_categoria;
        }
    }
}
