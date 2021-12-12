using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EburyPartners
{
    internal class Cuenta
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
        private List<Cliente> clientes;
        private List<Cliente> autorizados;

        public Cuenta(string iBAN)
        {
            IBAN = iBAN;
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
        internal List<Cliente> Clientes { get => clientes; set => clientes = value; }
        internal List<Cliente> Autorizados { get => autorizados; set => autorizados = value; }
    }
}
