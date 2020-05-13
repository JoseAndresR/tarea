using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{

    //Aqui se ejecuta el programa 10 veces para hacer la lista y sacar los datos que piden
    public class AppCliente
    {
        static void Main(string[] args)
        {

            double totalDomicilio = 0, totalLlevar = 0;
            int cantDomicilio = 0, cantLlevar = 0;

            for (int i = 1; i <= 10; i++)
            {
                String nombre, pedido;
                double costo;
                char formaPago;
                int tipo;

                Console.WriteLine("Bienvenido, ingrese los siguientes datos");
                Console.WriteLine("-Nombre del cliente: ");
                nombre = Console.ReadLine();
                Console.WriteLine("-Pedido: ");
                pedido = Console.ReadLine();
                Console.WriteLine("-Costo: ");
                costo = int.Parse(Console.ReadLine());
                Console.WriteLine("-Forma de Pago \n\t Elija: A) Efectivo \t B) Tarjeta ) ");
                formaPago = char.Parse(Console.ReadLine());
                Console.WriteLine("Elija opcion: \n\t 1) Para llevar \t 2) Pedido a domicilio");
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    String telefono, horaEntrega, vehiculo;
                    int pago;
                    Console.WriteLine("-Telefono del cliente: ");
                    telefono = Console.ReadLine();
                    Console.WriteLine("-Hora de entrega: ");
                    horaEntrega = Console.ReadLine();
                    Console.WriteLine("-Vehiculo: ");
                    vehiculo = Console.ReadLine();

                    ClienteLLevar cliente = new ClienteLLevar(i, nombre, pedido, costo, formaPago, telefono, horaEntrega, vehiculo);
                    cliente.imprimir();
                    Console.WriteLine("-Cantidad que se recibio (Pago): ");
                    pago = int.Parse(Console.ReadLine());
                    Console.WriteLine(cliente.cambio(pago));
                    if (pago >= cliente.monto()) { 
                         totalLlevar += cliente.monto();
                         cantLlevar++;
                    }
                    Console.WriteLine("Gracias por su compra. \n");
                    
                }
                else {

                    int tiempoMax, pago;
                    String direccion, comision;
                    Console.WriteLine("-Direccion del cliente: ");
                    direccion = Console.ReadLine();
                    Console.WriteLine("-Tiempo maximo de entrega: ");
                    tiempoMax = int.Parse(Console.ReadLine());
                    Console.WriteLine("-Comision por entrega: ");
                    comision = Console.ReadLine();

                    ClienteDomicilio cliente = new ClienteDomicilio(i, nombre, pedido, costo, formaPago, tiempoMax, direccion, comision);
                    cliente.imprimir();
                    Console.WriteLine("-Cantidad que se recibio (Pago): ");
                    pago = int.Parse(Console.ReadLine());
                    Console.WriteLine(cliente.cambio(pago));
                    if (pago >= cliente.monto()) { 
                        totalDomicilio += cliente.monto();
                        cantDomicilio++;
                    }
                    Console.WriteLine("Gracias por su compra. \n");

                }
            }

            Console.WriteLine("\n*Total de la suma de los montos de los pedidos a domicilio: " + totalDomicilio);
            Console.WriteLine("*Promedio de los montos que pagaran los clientes para llevar: " + (totalLlevar/cantLlevar));
            Console.WriteLine("*Porcentaje de pedidos a domicilio: " + cantDomicilio*10 + "%");
            Console.WriteLine("*Porcentaje de pedidos para llevar: " + cantLlevar*10 + "%");
            Console.WriteLine("Fin del programa");

        }
    }
}
