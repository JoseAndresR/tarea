using System;

namespace Tarea
{
    //Clase principal / Clase Padre
    public class Cliente
    {
        private int numCliente { get; set; }
        private double costo { get; set; }
        private String nombre { get; set; }
        private String pedido { get; set; }
        private char formaPago { get; set; }

        public Cliente()
            {
                this.numCliente = 0;
                this.nombre = "";
                this.pedido = "";
                this.costo = 0;
                this.formaPago = 'f';

            }

        public Cliente(int numCliente, String nombre, String pedido, double costo, char formaPago) {
            this.numCliente = numCliente;
            this.nombre = nombre;
            this.pedido = pedido;
            this.costo = costo;
            this.formaPago = formaPago;

        }

        //aqui se hace el calculo de cuanto pagara el cliente
        public double monto () {
            return costo - descuento();
       
        }

        //se aplica el 20 porciento de descuento
        public double descuento() {
            return (costo * 0.20);
        }

        //Operaciones para ver el cambio
        public String cambio(int pago)
        {
            String x="";
            if (pago >= monto())
            {
                x = "Cambio: " + (pago - monto());
            }
            else
            {
                x = "No se puede realizar esta compra, pago insuficiente.";
            }
            return x;
        }

        //esto solo es para observar los datos del cliente
        public void imprimir() {
            Console.WriteLine("\nInforme del pedido: ");
            Console.WriteLine("Numero de cliente: " + numCliente);
            Console.WriteLine("Pedido: " + pedido);
            Console.WriteLine("Nombre del cliente: " + nombre);
            Console.WriteLine("Costo Original:" + costo);
            Console.WriteLine("Descuento aplicado: " + descuento());
            Console.WriteLine("Total a Pagar: " + monto());
        }

    }
}
