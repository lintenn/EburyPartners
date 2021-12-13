using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EburyPartners
{
    internal class ConsultaFiltroCuenta
    {
        private string IBAN;
        private string caja_deposito;
        private DateTime fecha_apertura;
        private DateTime fecha_cierre;
        private double cantidad;
        private string moneda;
        private string pais;
        private string estado_cuenta;
        private string tipo_cuenta;
        private string DNI_NIF;
        private string estado_cliente;
        private string tipo_cliente;
        private string primer_nombre;
        private string segundo_nombre;
        private string ciudad;
        private string calle;
        private string num_edificio;
        private string codigo_postal;
        private string pais_cliente;

        public ConsultaFiltroCuenta(string iBAN, string caja_deposito, DateTime fecha_apertura, DateTime fecha_cierre, double cantidad, string moneda, string pais, string estado_cuenta, string tipo_cuenta, string dNI_NIF, string estado_cliente, string tipo_cliente, string primer_nombre, string segundo_nombre, string ciudad, string calle, string num_edificio, string codigo_postal, string pais_cliente)
        {
            IBAN = iBAN;
            this.Caja_deposito = caja_deposito;
            this.Fecha_apertura = fecha_apertura;
            this.Fecha_cierre = fecha_cierre;
            this.Cantidad = cantidad;
            this.Moneda = moneda;
            this.Pais = pais;
            this.Estado_cuenta = estado_cuenta;
            this.Tipo_cuenta = tipo_cuenta;
            DNI_NIF1 = dNI_NIF;
            this.Estado_cliente = estado_cliente;
            this.Tipo_cliente = tipo_cliente;
            this.Primer_nombre = primer_nombre;
            this.Segundo_nombre = segundo_nombre;
            this.Ciudad = ciudad;
            this.Calle = calle;
            this.Num_edificio = num_edificio;
            this.Codigo_postal = codigo_postal;
            this.Pais_cliente = pais_cliente;
        }

        public string IBAN1 { get => IBAN; set => IBAN = value; }
        public string Caja_deposito { get => caja_deposito; set => caja_deposito = value; }
        public DateTime Fecha_apertura { get => fecha_apertura; set => fecha_apertura = value; }
        public DateTime Fecha_cierre { get => fecha_cierre; set => fecha_cierre = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado_cuenta { get => estado_cuenta; set => estado_cuenta = value; }
        public string Tipo_cuenta { get => tipo_cuenta; set => tipo_cuenta = value; }
        public string DNI_NIF1 { get => DNI_NIF; set => DNI_NIF = value; }
        public string Estado_cliente { get => estado_cliente; set => estado_cliente = value; }
        public string Tipo_cliente { get => tipo_cliente; set => tipo_cliente = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Num_edificio { get => num_edificio; set => num_edificio = value; }
        public string Codigo_postal { get => codigo_postal; set => codigo_postal = value; }
        public string Pais_cliente { get => pais_cliente; set => pais_cliente = value; }
    }
}
