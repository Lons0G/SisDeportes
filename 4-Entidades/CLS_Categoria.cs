namespace _3_Entidades
{
    public class CLS_Categoria
    {
        private int _idCategoria;
        private int _idDeporte;
        private string _nombre;
        private string _error;
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public int IdDeporte { get => _idDeporte; set => _idDeporte = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
