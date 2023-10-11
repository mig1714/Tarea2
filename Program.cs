using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*hacer un algoritmo de una tienda que vende camisas, si la persona se lleva una camisa se lo lleva a precio de costo, 

si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%

si la persona se lleva más de 5 el descuento es de 20%

El sistema debe solicitar la cantidad de camisas y el precio de las camisas*/
            
            double precio;
            int camisas;
            Console.WriteLine("Digite el precio de las  camisas");
            precio = Double.Parse(  Console.ReadLine());

            Console.WriteLine("Digite la cantidad de camisas a comprar");
            camisas = Int32.Parse(Console.ReadLine());

            if (2 >= camisas && camisas <= 5)
            {
                double totalcamisas = camisas * precio;
                double precioQuince = precio * 0.15;
                double total = totalcamisas -  (camisas * precioQuince);

                Console.WriteLine("Debe pagar por " + camisas + ": camisetas");
                Console.WriteLine("Total: " + total);
                Console.ReadLine();


            }
            else if (camisas > 5)
            {

                double totalcamisas = camisas * precio;
                double precioVeinte = precio * 0.2;
                double total = totalcamisas -  (camisas * precioVeinte);

                Console.WriteLine("Debe pagar por " + camisas + ": camisetas");
                Console.WriteLine("Total: " + total);
                Console.ReadLine();


            }
            else {

                
                double total = camisas * precio;

                Console.WriteLine("Debe pagar por " + camisas + ": camiseta");
                Console.WriteLine("Total: " + total);
                Console.ReadLine();


            }
            

            /*Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso 
             * de Programación 1. Deberá leer los siguientes datos para cada estudiante: carnet, 
             * nombre, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3.
             * El programa deberá calcular el porcentaje de quices (25%), porcentaje de tareas (30%), 
             * y el porcentaje de exámenes (45%). El algoritmo tiene que calcular el promedio final y 
             * reportar el carnet, nombre, porcentaje de quices, porcentaje de tareas, porcentaje de 
             * exámenes, promedio final y condición del estudiante. La condición del estudiante esta 
             * con base a: Si el promedio final es mayor o igual a 70 “Aprobado”. Si el promedio final
             * es mayor o igual a 50 y menor que 70 “Aplazado” y si el promedio final es menor que 50 
             * “Reprobado”. 9. */
            
            Console.WriteLine("Digite su carne: ");
            string carne = Console.ReadLine();

            Console.WriteLine("Digite su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del primer quiz");

            double quizUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo quiz");

            double quizDos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del tercer quiz");

            double quizTres = double.Parse(Console.ReadLine());
            //Calculo quices
            double totalQuices = (quizUno + quizDos + quizTres) / 3;

            double porcentajeQuices = 25 * totalQuices / 100;

            //Tareas


            Console.WriteLine("Ingrese la nota de la primera tarea");

            double tareaUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la segunda tarea");

            double tareaDos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la tercera tarea");

            double tareaTres = double.Parse(Console.ReadLine());
            //Calculo tareas
            double totalTareas = (tareaUno + tareaDos + tareaTres) / 3;

            double porcentajeTareas = 30 * totalTareas / 100;

            //Examenes

            Console.WriteLine("Ingrese la nota del primer examen");

            double examenUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo examen");

            double examenDos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del tercer examen");

            double examenTres = double.Parse(Console.ReadLine());
            
            //Calculo tareas
            double totalExamenes = (tareaUno + tareaDos + tareaTres) / 3;

            double porcentajeExamenes = 45 * totalTareas / 100;


            double totalNota = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            Console.WriteLine("Nota: "+totalNota.ToString("N4"));

            if (totalNota >= 70) {

                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Carne: " + carne);
                Console.WriteLine("Nota: " + totalNota.ToString("N4"));
                Console.WriteLine("Estatus: Aprobado");
                Console.ReadLine();



            }
            if(totalNota >= 50  && totalNota < 70){

                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Carne: "+carne);
                Console.WriteLine("Nota: " + totalNota.ToString("N4"));
                Console.WriteLine("Estatus: Aplazado");
                Console.ReadLine();





            }if (totalNota < 50) {

                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Carne: " + carne);
                Console.WriteLine("Nota: " + totalNota.ToString("N4"));
                Console.WriteLine("Estatus: Reprobado");
                Console.ReadLine();



            }

            /*Un vendedor ofrece su producto de la siguiente manera:
             * Si le compran 10 productos o menos, el precio por producto es de $20. 
             * Si le compran más de 10 artículos, el precio es de $15 por artículo. 
             * Realice un algoritmo y diagrama de flujo que con solo proporcionarle 
             * la cantidad de artículos dé como resultado el precio y el total.*/

            Console.WriteLine("Digite la cantidad de producto a comprar");
            int cantidadProducto = int.Parse(Console.ReadLine());

            if (cantidadProducto <= 10)
            {
                int precio = 20;
                int total = cantidadProducto * precio;
                Console.WriteLine("El precio de la venta es de : " + total);
                Console.ReadLine();

            }
            else if (cantidadProducto > 10) {

                int precio = 15;
                int total = cantidadProducto * precio;
                Console.WriteLine("El precio de la venta es de : " + total);
                Console.ReadLine();


            }
            












        }
    }
}
