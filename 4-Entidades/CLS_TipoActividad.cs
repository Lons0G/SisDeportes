namespace _3_Entidades
{
    public class CLS_TipoActividad
    {
        private int _idTipo;
        private string _nombre;
        private string _descripcion;
        private string _error;
        public int IdTipo { get => _idTipo; set => _idTipo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
