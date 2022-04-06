using _3_Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
namespace _2_Logica.Logica
{
    internal class CLS_L_Categoria
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Juan); }
        //METODO PARA INSERTAR CATEGORIA//
        public bool Insertar_Categoria(ref CLS_Categoria obj_categoria) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_CATEGORIA", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
    }
}
