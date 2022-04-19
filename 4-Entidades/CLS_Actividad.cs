using System;
using System.Data;

namespace _3_Entidades //_3_Entidades
{
    public class CLS_Actividad
    {
        private int _idActividad;
        private DateTime _fecha;
        private DateTime _hora;
        private int _idContricante_1;
        private int _idContricante_2;
        private int _idCategoria;
        private int _idUsuario;
        private int _idDeporte;
        private int _idTipo;
        private int _idTorneo;
        private string _nombre;
        private string _error;

        public int IdActividad { get => _idActividad; set => _idActividad = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int IdContricante_1 { get => _idContricante_1; set => _idContricante_1 = value; }
        public int IdContricante_2 { get => _idContricante_2; set => _idContricante_2 = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int IdDeporte { get => _idDeporte; set => _idDeporte = value; }
        public int IdTipo { get => _idTipo; set => _idTipo = value; }
        public int IdTorneo { get => _idTorneo; set => _idTorneo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Error { get => _error; set => _error = value; }
        public DateTime Hora { get => _hora; set => _hora = value; }
    }
}
