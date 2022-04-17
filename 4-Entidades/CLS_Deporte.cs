namespace _3_Entidades
{
    public class CLS_Deporte
    {
        private int _idDeporte;
        private int _idUsuario;
        private string _nombre;
        private int _idTipoDeporte;
        private string _error;
        public int IdDeporte { get => _idDeporte; set => _idDeporte = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdTipoDeporte { get => _idTipoDeporte; set => _idTipoDeporte = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
