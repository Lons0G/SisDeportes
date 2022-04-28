namespace _3_Entidades
{
    public class CLS_Integrantes
    {
        private int _IdIntegrante;
        private int _IdEquipo;
        private int _idEntrenador;
        private int _idUsuario;
        private string _nombre;
        private string _apellido;
        private byte _edad;
        private string _nacionalidad;
        private string _posicion;
        private int _dorsal;
        private string _rol;
        private string _error;
        public int IdIntegrante { get => _IdIntegrante; set => _IdIntegrante = value; }
        public int IdEquipo { get => _IdEquipo; set => _IdEquipo = value; }
        public int IdEntrenador { get => _idEntrenador; set => _idEntrenador = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public byte Edad { get => _edad; set => _edad = value; }
        public string Nacionalidad { get => _nacionalidad; set => _nacionalidad = value; }
        public string Posicion { get => _posicion; set => _posicion = value; }
        public int Dorsal { get => _dorsal; set => _dorsal = value; }
        public string Rol { get => _rol; set => _rol = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
