using System;

namespace Tarea
{
    //Clase ClientLLevar que hereda de Cliente
    public class ClienteDomicilio : Cliente
    {
        private String direccion { get; set; }
        private String comision { get; set; }
        private int tiempoMax { get; set; }
        private int tiempoReal { get; set; }


        public ClienteDomicilio(int numCliente, String nombre, String pedido, double costo, char formaPago)
         : base(numCliente, nombre, pedido, costo, formaPago)
        {

            this.direccion = "";
            this.comision = "";
            this.tiempoMax = 30;

        }

        //aqui pasa todos los datos que se van a utilizar (en forma de variable)
        public ClienteDomicilio(int numCliente, String nombre, String pedido, double costo, char formaPago, int tiempoMax, String direccion, String comision)
            : base(numCliente, nombre, pedido, costo, formaPago)
        {

            this.direccion = direccion;
            this.comision = comision;
            this.tiempoMax = tiempoMax;

        }

        public String complementos(String complemento)
        {
            String x = "";
            Console.WriteLine("¿Desea algun complemento?");
            if (complemento == "Si") {
                x = "Salsa y azucar como complemento.";
            }

            return x;
        }

        public bool gratis()
        {

            if (tiempoMax >= tiempoReal)
                return true;
            else
                return false;
        }
    }
}
