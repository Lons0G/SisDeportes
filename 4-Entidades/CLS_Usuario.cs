namespace _3_Entidades
{
    public class CLS_Usuario
    {
        //VARIABLES PRIVADAS DE LA ENTIDAD USUARIO
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _usuario;
        private string _password;
        private string _telefono;
        private string _correo;
        private decimal _sueldo;
        private int _rol;
        private int _deporte;
        private string _error;
        private int _estado;
      
        // CAMPOS PUBLICOS
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Password { get => _password; set => _password = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public decimal Sueldo { get => _sueldo; set => _sueldo = value; }
        public int Rol { get => _rol; set => _rol = value; }
        public string Error { get => _error; set => _error = value; }
        public int Deporte { get => _deporte; set => _deporte = value; }
        public int Estado { get => _estado; set => _estado = value; }
    }
}
