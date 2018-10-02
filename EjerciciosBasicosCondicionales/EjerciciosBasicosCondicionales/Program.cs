using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicosCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir dos números y que te diga si son iguales o distintos
            Console.WriteLine("Dime un número");
            int num1, num2;//es mejor declarar las variables siempre arriba
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime otro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los números son iguales");
            }
            else
            {
                Console.WriteLine("Los números son distintos");
            }
            Console.ReadLine();

            //Pedir un número y que me diga si es par o impar
            Console.WriteLine("Dime un número");
            int num3;//se podría utilizar la variable num1 o num2, no hemos hecho operaciones con ellas
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
            Console.ReadLine();

            //Pedir un número del 1 al 7 y decir a qué día de la semana corresponde
            Console.WriteLine("Introduce un número del 1 al 7");
            int num4;
            num4 = Convert.ToInt32(Console.ReadLine());
            if (num4 == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (num4 == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (num4 == 3)
            {
                Console.WriteLine("Miércoles");
            }
            else if (num4 == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (num4 == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (num4 == 6)
            {
                Console.WriteLine("Sábado");
            }
            else if (num4 == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("El número introducido no es correcto");
            }
            Console.ReadLine();

            //Escribir un número de1 1 al 12 y que me diga que mes es
            Console.WriteLine("Introduce un número del 1 al 12");
            int num5;
            num5 = Convert.ToInt32(Console.ReadLine());
            switch (num5)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosyo");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Ese mes no existe, introduce un número del 1 al 12");
                    break;
            }

            Console.ReadLine();


            Console.WriteLine("Introduce una nota");
            double nota;
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 5 && nota < 6)
            {
                Console.WriteLine("Aprobado");
            }
            else if (nota < 5 && nota >= 0)
            {
                Console.WriteLine("Suspenso");
            }
            else if (nota >= 6 && nota < 7)
            {
                Console.WriteLine("Bien");
            }
            else if (nota >= 7 && nota < 9)
            {
                Console.WriteLine("Notable");
            }
            else if (nota >= 9 && nota < 10)
            {
                Console.WriteLine("Sobresaliente");
            }
            else if (nota == 10)
            {
                Console.WriteLine("Matrícula");
            }
        
            Console.ReadLine();






            //Pedir por teclado peso y altura e indicar según su imc cual es su clasificación según la OMS.
            //Se calcula dividiendo el peso de una persona en kilos por el cuadrado de su talla en metros (kg/m2).
            //            ÍNDICE MASA CORPORAL CLASIFICACIÓN
            //<16.00
            //16.00 - 16.99
            //17.00 - 18.49
            //18.50 - 24.99
            //25.00 - 29.99
            //30.00 - 34.99
            //35.00 - 40.00
            //> 40.00
            //Infrapeso: Delgadez Severa
            //Infrapeso: Delgadez moderada
            //Infrapeso: Delgadez aceptable
            //Peso Normal
            //Sobrepeso
            //Obeso: Tipo I
            //Obeso: Tipo II
            //Obeso: Tipo III
            Console.WriteLine("Introduce tu peso");
            double peso;
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce tu altura en metros");
            double altura;
            altura = Convert.ToDouble(Console.ReadLine());
            double imc;
            imc = peso / Math.Pow(altura, 2); //Para ver y hacer operaciones y seguir el debug: Depurar/Ventanas/Ventana Inmediato
            if (imc < 16) 
            {
                Console.WriteLine("Infrapeso: Delgadez Severa");
            }
            else if (imc >= 16 && imc <= 16.99)
            {
                Console.WriteLine("nfrapeso: Delgadez moderada");
            }
            else if (imc >= 17 && imc <= 18.49)
            {
                Console.WriteLine("Infrapeso: Delgadez aceptable");
            }
            else if (imc >= 18.50 && imc <= 24.99)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.99)
            {
                Console.WriteLine("Obeso: Tipo I");
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("Obeso: Tipo II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obeso: Tipo III");
            }

            Console.ReadLine();

            //Escribe un programa que pida dos números y que muestre la suma, la resta, la multiplicación, la media, el máximo y el mínimo.

            Console.WriteLine("Introduce un número");
            double num10, num11;
            num10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            num11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma es " + (num10 + num11));
            Console.WriteLine("La resta es "+(num10 - num11));
            Console.WriteLine("La multiplicación es "+ (num10 *num11));
            Console.WriteLine("La media es "+(num10 + num11)/2);
            if (num10>num11)
            {
                Console.WriteLine("El máximo es " + num10);
            }
            else
            {
                Console.WriteLine("El máximo es " + num11);
            }
            if (num10<num11)
            {
                Console.WriteLine("El mínimo es " + num10);
            }
            else
            {
                Console.WriteLine("El mínimo es " + num11);
            }
            Console.ReadLine();


            //Escribe un programa que pida al usuario 3 números. Si el resultado de la suma de los dos primeros es igual al tercer número,
            //mostrarlo en pantalla, sino mostrar que el tercero no es la suma de los dos anteriores.

            double num20, num21, num22;
            Console.WriteLine("Introduce un número");
            num20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            num21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            num22 = Convert.ToDouble(Console.ReadLine());
            if (num20 + num21 == num22)
            {
                Console.WriteLine("La suma de los dos primeros números es igual al tercero");
            }
            else
            {
                Console.WriteLine("La suma de los dos primeros números no es igual al tercero");
            }
            Console.ReadLine();

            //Escribe un programa que convierta los segundos a horas, minutos y segundos.

            int segundos;
            int horas;
            int minutos;
            int segundos2;
            Console.WriteLine("Introduce segundos");
            segundos = Convert.ToInt32(Console.ReadLine());
            horas = segundos / (60 * 60);
            minutos = segundos % 3600 / 60;
            segundos2 = segundos % 60;// los segundos2 son el resto de los segundos
            Console.WriteLine(segundos + " Segundos son: " + horas + " Horas " + minutos + " Minutos" + " y " + segundos2 + " Segundos");

            Console.ReadLine();

            // Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.

            double num30, num31, num32;
            Console.WriteLine("Introduce un número");
            num30 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            num31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            num32 = Convert.ToDouble(Console.ReadLine());
            if (num30 == num31 - 20)
            {
                Console.WriteLine(num30 + " es 20 menos que " + num31);
            }
             if (num30 == num32 - 20)
            {
                Console.WriteLine(num30 + " es 20 menos que " + num32);
            }
             if (num31 == num30 - 20)
            {
                Console.WriteLine(num31 + " es 20 menos que " + num30);
            }
             if (num31 == num32 - 20)
            {
                Console.WriteLine(num31 + " es 20 menos que " + num32);
            }
             if (num32 == num30 - 20)
            {
                Console.WriteLine(num32 + " es 20 menos que " + num30);
            }
             if (num32 == num31 - 20)
            {
                Console.WriteLine(num32 + " es 20 menos que " + num31);
            }
            else
            {
                Console.WriteLine("Ningún número es 20 menos que otro");
            }

            Console.ReadLine();

            // Escribe un programa que pida dos valores del usuario y
                // Si los dos valores son iguales muestre 0
                // Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
                // Si no que muestre el más grande de los dos


            double valor1, valor2;
            Console.WriteLine("Introduce un valor");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro valor");
            valor2 = Convert.ToDouble(Console.ReadLine());
            if (valor1 == valor2)
            {
                Console.WriteLine("0");
            }
            else if (valor1 % 6 == valor2 % 6)
            {
                Console.WriteLine(Math.Min(valor1, valor2));
            }
            else
            {
                Console.WriteLine(Math.Max(valor1, valor2));
            }

            Console.ReadLine();

            // Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.

            int valor3, valor4, dig1v3, dig2v3, dig1v4, dig2v4;
            Console.WriteLine("Introduce un valor entre 25 y 75");
            valor3 = Convert.ToInt32(Console.ReadLine());
            dig1v3 = valor3 / 10;
            dig2v3 = valor3 % 10;
            Console.WriteLine("Introduce otro valor entre 25 y 75");
            valor4 = Convert.ToInt32(Console.ReadLine());
            dig1v4 = valor4 / 10;
            dig2v4 = valor4 % 10;
            if (valor3 >= 25 && valor3 <= 75 && valor4 >= 25 && valor4 <= 75)
            {
                if (dig1v3 == dig1v4 || dig1v3 == dig2v4 || dig2v3 == dig1v4 || dig2v3 == dig2v4)
                {
                    Console.WriteLine("Hay un dígito en común entre los 2 números");
                }
                else
                {
                    Console.WriteLine("No hay ningún dígito en común entre los 2 números");
                }
            }

            Console.ReadLine();

            //Vamos a escribir varios programas que saludan al usuario al iniciar. 
            //El usuario tiene asociadas 3 variables, una que indica si ha pagado la entrada, una que indica si es cliente VIP 
            //y la otro el saldo que tiene(positivo para saldo de más, negativo para deuda).Haz un programa por cada punto:

            //Comprobar si se ha pagado la entrada.Si se ha pagado, mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".

            

            bool entrada;
            Console.WriteLine("Ha pagado la entrada?.Responde S o N");
            string respuesta = Console.ReadLine();
            if (respuesta == "S")
            {
                entrada = true; //si S entonces tiene entrada
            }
            else if (respuesta == "N")
            {
                entrada = false;// si N no tiene entrada
            }
            else
            {
                entrada = false;//si da cualquier otra respuesta que no sea S o N, no tiene entrada
            }

            if (entrada)//Es redundante poner entrada=true
            {
                Console.WriteLine("Bienvenido");
            }
            else    // Se podría poner !entrada, pero no hace falta porque en caso contrario sólo hay una posibilidad
            {
                Console.WriteLine("Tienes que pagar la entrada");
            }
            Console.ReadLine();


            //A todos se les dice "Bienvenido", pero si es cliente VIP después de "Bienvenido" también se le dice "Que pase un buen día"
            bool vip;
            Console.WriteLine("Eres VIP?.Responde S o N");
            string respuesta1 = Console.ReadLine(); ;

            if (respuesta1 == "S")
            {
                vip = true;
            }
            else if (respuesta1 == "N")
            {
                vip = false;
            }
            else
            {
                vip = false;
            }
            if (vip)
            {
                Console.WriteLine("Bienvenido. Que pase un buen día");
            }
            else
            {
                Console.WriteLine("Bienvenido");
            }
            Console.ReadLine();



            //Si no tiene deudas, le damos la bienvenida.En caso contrario no hacemos nada.

            bool deudas;
            Console.WriteLine("Tienes saldo negativo?.Escribe S o N");
            string respuesta2 = Console.ReadLine(); ;

            if (respuesta2 == "S")
            {
                deudas = true;
            }
            else if (respuesta2 == "N")
            {
                deudas = false;
            }
            else
            {
                deudas = true;
            }
            if (!deudas)
            {
                Console.WriteLine("Bienvenido");
            }
                       
            Console.ReadLine();
                          
            //Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0

            bool deudas;
            bool vip;
            Console.WriteLine("Eres VIP?.Responde S o N");
            string respuestav = Console.ReadLine(); ;
            Console.WriteLine("Tienes saldo negativo?.Escribe S o N");
            string respuestas = Console.ReadLine(); ;

            if (respuestav == "S")
            {
                vip = true;
            }
            else if (respuestav == "N")
            {
                vip = false;
            }
            else
            {
                vip = false;
            }
            if (respuestas == "N")
            {
                deudas = false;
            }
            else if (respuestas == "S")
            {
                deudas = true;
            }
            else
            {
                deudas = true;
            }
            if (vip && !deudas)
            {
                Console.WriteLine("Bienvenido");
            }
            else { } // si vamos a poner sólo un else hay que abrir y cerrar la llave


            Console.ReadLine();

            // Resultado de carrera.Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó.
            //Después:





            

            //Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".
            //Hazlo usando un if/else y usando switch


            //Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            int puesto;
            Console.WriteLine("¿En qué puesto acabaste?");
            int respuestap = Convert.ToInt32(Console.ReadLine());

            if (respuestap == 1)
            {
                Console.WriteLine("Ganaste!!");
            }
            else
            {
                Console.WriteLine("Lo importante es participar");
            }


            Console.ReadLine();

            //Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2,
            //mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            int puesto;
            Console.WriteLine("¿En qué puesto acabaste?");
            int respuestap1 = Convert.ToInt32(Console.ReadLine());

            if (respuestap1 == 1)
            {
                Console.WriteLine("Medalla de Oro");
            }
            else if (respuestap1 == 2)
            {
                Console.WriteLine("Medalla de Plata");
            }
            else if (respuestap1 == 3)
            {
                Console.WriteLine("Medalla de Bronce");
            }
            else
            {
                Console.WriteLine("Lo importante es participar");
            }



            Console.ReadLine();

            //Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, 
            //mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            int puesto;
            Console.WriteLine("¿En qué puesto acabaste?");
            int respuestap2 = Convert.ToInt32(Console.ReadLine());

            switch (respuestap2)
            {
                case 1:
                    Console.WriteLine("Medalla de Oro");
                    break;
                case 2:
                    Console.WriteLine("Medalla de Plata");
                    break;
                case 3:
                    Console.WriteLine("Medalla de Bronce");
                    break;
                default:
                    Console.WriteLine("Lo importante es participar");
                    break;
            }



            Console.ReadLine();

            //Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".
            //Hazlo usando un if/else y usando switch
            int puesto;
            Console.WriteLine("¿En qué puesto acabaste?");
            int respuestap3 = Convert.ToInt32(Console.ReadLine());

            switch (respuestap3)
            {
                case 1:
                    Console.WriteLine("Sube al podium");
                    break;
                case 2:
                    Console.WriteLine("Sube al podium");
                    break;
                case 3:
                    Console.WriteLine("Sube al podium");
                    break;
                default:
                    Console.WriteLine("Se acabó la carrera");
                    break;
            }
            Console.ReadLine();

            int puesto;
            Console.WriteLine("¿En qué puesto acabaste?");
            int respuestap4 = Convert.ToInt32(Console.ReadLine());

            if (respuestap4 == 1 )
            {
                Console.WriteLine("Sube al podium");
            }
            else if (respuestap4 == 2)
            {
                Console.WriteLine("Sube al podium");
            }
            else if (respuestap4 == 3)
            {
                Console.WriteLine("Sube al podium");
            }
            else
            {
                Console.WriteLine("Se acabó la carrera");
            }
            Console.ReadLine();


        }

    }
}
