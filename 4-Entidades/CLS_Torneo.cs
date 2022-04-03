using System;

namespace _3_Entidades
{
    public class CLS_Torneo
    {
        private int _idTorneo;
        private DateTime _fecha;
        private int _idCategoria;
        private int _idUsuario;
        private int _idTipo;
        private string _nombre;
        private string _error;
        public int IdTorneo { get => _idTorneo; set => _idTorneo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int IdTipo { get => _idTipo; set => _idTipo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
