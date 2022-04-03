namespace _3_Entidades
{
    public class CLS_Equipo
    {
        private int _idEquipo;
        private int _idDeporte;
        private int _idCategoria;
        private int _idUsuario;
        private int _idEntrenador;
        private bool _local;
        private string _nombre;
        private string _error;
        public int IdEquipo { get => _idEquipo; set => _idEquipo = value; }
        public int IdDeporte { get => _idDeporte; set => _idDeporte = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int IdEntrenador { get => _idEntrenador; set => _idEntrenador = value; }
        public bool Local { get => _local; set => _local = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
