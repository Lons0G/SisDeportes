using System;
using System.Data;
using System.Data.SqlClient;
using _3_Entidades;

namespace _2_Logica 
{
    public class CLS_L_Usuarios
    {
        SqlConnection _conexion;
        private void Conexion() { _conexion = new SqlConnection(Properties.Settings.Default.Conexion_Angel); }
        
        //METODO PARA INSERTAR USUARIO//
        public bool Insertar_Usuario(ref CLS_Usuario obj_usuario) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_USUARIOS", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@Nombre", obj_usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj_usuario.Apellido);
                comando.Parameters.AddWithValue("@Usuario", obj_usuario.Usuario);
                comando.Parameters.AddWithValue("@Contrasena", obj_usuario.Password);
                comando.Parameters.AddWithValue("@Telefono", obj_usuario.Telefono);
                comando.Parameters.AddWithValue("@Correo", obj_usuario.Correo);
                comando.Parameters.AddWithValue("@Sueldo", obj_usuario.Sueldo);
                comando.Parameters.AddWithValue("@IdRol", obj_usuario.Rol);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_usuario.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA EDITAR USUARIO//
        public bool Editar_Usuario(ref CLS_Usuario obj_usuario) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_EDITAR_USUARIOS", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdUsuario", obj_usuario.Id);
                comando.Parameters.AddWithValue("@Nombre", obj_usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj_usuario.Apellido);
                comando.Parameters.AddWithValue("@Usuario", obj_usuario.Usuario);
                comando.Parameters.AddWithValue("@Contrasena", obj_usuario.Password);
                comando.Parameters.AddWithValue("@Telefono", obj_usuario.Telefono);
                comando.Parameters.AddWithValue("@Correo", obj_usuario.Correo);
                comando.Parameters.AddWithValue("@Sueldo", obj_usuario.Sueldo);
                comando.Parameters.AddWithValue("@IdRol", obj_usuario.Rol);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_usuario.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA ELIMINAR USUARIO//
        public bool Eliminar_Usuario(ref CLS_Usuario obj_usuario) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_USUARIO", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdUsuario", obj_usuario.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception error) {
                obj_usuario.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        //METODO PARA BUSCAR UN USUARIO//
        public bool Buscar_Usuario(ref CLS_Usuario obj_usuario) {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_Login", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@IdUsuario", obj_usuario.Id);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0) {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read()) {
                        obj_usuario.Nombre = reader["Nombre"].ToString();
                        obj_usuario.Apellido = reader["Apellido"].ToString();
                        obj_usuario.Usuario = reader["Usuario"].ToString();
                        obj_usuario.Password = reader["Contrasena"].ToString();
                        obj_usuario.Telefono = reader["Telefono"].ToString();
                        obj_usuario.Correo = reader["Correo"].ToString();
                        obj_usuario.Sueldo = Convert.ToDecimal(reader["Sueldo"].ToString());
                        obj_usuario.Rol = Convert.ToInt32(reader["IdRol"].ToString());
                    }
                }
                else { obj_usuario.Id = 0; }
                return true;
            }
            catch (Exception error) {
                obj_usuario.Error = error.Message;
                return false;
            }
            finally {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
        public void Login(ref CLS_Usuario obj_usuario)
        {
            try {
                Conexion();
                SqlCommand comando = new SqlCommand("SP_Login", _conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@Usuario", obj_usuario.Usuario);
                comando.Parameters.AddWithValue("@Password", obj_usuario.Password);
                _conexion.Open();
                int fila = Convert.ToInt32(comando.ExecuteScalar());
                if (fila != 0) {
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        obj_usuario.Id = Convert.ToInt32(reader["IdUsuario"].ToString());
                        obj_usuario.Rol = Convert.ToInt32(reader["IdRol"].ToString());
                    }
                }
                else { obj_usuario.Id = 0; }
            }
            catch (Exception error) {
                obj_usuario.Error = error.Message;
            }
            finally
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }
    }
}
