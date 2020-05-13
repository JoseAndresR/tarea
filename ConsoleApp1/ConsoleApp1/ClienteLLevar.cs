using System;

namespace Tarea
{
    //Clase ClientLLevar que hereda de Cliente 
    public class ClienteLLevar : Cliente {

        private String telefono { get; set; }
        private String horaEntrega { get; set; }
        private String vehiculo { get; set; }

        public ClienteLLevar(int numCliente, String nombre, String pedido, double costo, char formaPago)
         : base(numCliente, nombre, pedido, costo, formaPago)
        {

            this.telefono = "";
            this.horaEntrega = "";
            this.vehiculo = "";

        }

        //aqui pasa todos los datos que se van a utilizar (en forma de variable)
        public ClienteLLevar(int numCliente, String nombre, String pedido, double costo, char formaPago, String telefono, String horaEntrega, String vehiculo) 
            : base (numCliente, nombre, pedido, costo, formaPago) {

            this.telefono = telefono;
            this.horaEntrega = horaEntrega;
            this.vehiculo = vehiculo;

        }
    }
}
