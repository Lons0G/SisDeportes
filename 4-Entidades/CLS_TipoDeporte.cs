namespace _3_Entidades
{
    public class CLS_TipoDeporte
    {
        private int _idTipoDeporte;
        private string _nombre;
        private string _error;
        public int IdTipoDeporte { get => _idTipoDeporte; set => _idTipoDeporte = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
