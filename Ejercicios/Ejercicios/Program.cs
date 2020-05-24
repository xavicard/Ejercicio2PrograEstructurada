using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema: Sumar dos números y determinar si la suma es positiva, negativa o cero
            String nn1, nn2;
            int n1, n2, suma;
            Console.WriteLine("Escribe el primer número");
            nn1 = Console.ReadLine();
            Console.WriteLine("Escribe el segundo número");
            nn2 = Console.ReadLine();
            n1 = int.Parse(nn1);
            n2 = int.Parse(nn2);
            suma = n1 + n2;
            if (suma > 0)
            {
                Console.WriteLine("La suma es un número positivo");
            }
            else
            {
                if (suma == 0)
                {
                    Console.WriteLine("La suma es igual a cero");
                }
                else
                {
                    Console.WriteLine("La suma es un número negativo");
                }
            }
            Console.WriteLine("El resultado es " + suma);
            //FIN PROBLEMA

            //Problema: Determinar si tres valores A, B y C forman un triángulo
            int lado_1, lado_2, lado_3;
            Console.WriteLine("Escribe el primer lado");
            lado_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo lado");
            lado_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el tercer lado");
            lado_3 = int.Parse(Console.ReadLine());
            if (lado_1 < (lado_2 + lado_3) && lado_1 > (lado_2 - lado_3))
            {
                Console.WriteLine("Los lados forman un triángulo");
            }
            else
            {
                Console.WriteLine("Los lados no forman un triángulo");
            }
            //FIN PROBLEMA

            //PROBLEMA: Dado un número, determinar el mes al que corresponde
            int mes;
            Console.WriteLine("Ingrese el numero del mes");
            mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1: { Console.WriteLine("Enero"); } break;
                case 2: { Console.WriteLine("Febrero"); } break;
                case 3: { Console.WriteLine("Marzo"); } break;
                case 4: { Console.WriteLine("Abril"); } break;
                case 5: { Console.WriteLine("Mayo"); } break;
                case 6: { Console.WriteLine("Junio"); } break;
                case 7: { Console.WriteLine("Julio"); } break;
                case 8: { Console.WriteLine("Agosto"); } break;
                case 9: { Console.WriteLine("Septiembre"); } break;
                case 10: { Console.WriteLine("Octubre"); } break;
                case 11: { Console.WriteLine("Noviembre"); } break;
                case 12: { Console.WriteLine("Diciembre"); } break;
                default: { Console.WriteLine("No es un mes"); } break;
            }
            //FIN PROBLEMA

            //Problema: Hacer un menú que permita elegir la operación a realizarse para dos números
            int menu, n1, n2, resultado;
            Console.WriteLine("Elija la operacion a realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. División");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        resultado = n1 + n2;
                        Console.WriteLine("La suma es " + resultado);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        resultado = n1 - n2;
                        Console.WriteLine("La resta es " + resultado);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        resultado = n1 * n2;
                        Console.WriteLine("El producto es " + resultado);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        resultado = n1 / n2;
                        Console.WriteLine("La división es " + resultado);
                    }
                    break;
                default: { Console.WriteLine("No es una opción válida"); } break;
            }
            //FIN PROBLEMA

            //Problema: Mostrar los números pares menores al límite definido
            int limite, par = 2, cantidad, i;
            Console.WriteLine("Ingrese el número límite");
            limite = int.Parse(Console.ReadLine());
            cantidad = (limite - par) / 2;
            //Resolución utilizando el ciclo for
            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine(par);
                par += 2;
            }
            //----Fin resolución
            //Resolución utilizando el ciclo do-while
            do
            {
                Console.WriteLine(par);
                par += 2;
            } while (par < limite);
            //----Fin resolución
            //Resolución utilizando el ciclo while
            while (par < limite)
            {
                Console.WriteLine(par);
                par += 2;
            }
            //----Fin resolución
            //FIN PROBLEMA

            //PROBLEMA: Mostrar los n numeros impares
            int n, impar = 1, cantidad = 0;
            Console.WriteLine("Ingrese el valor de n");
            n = int.Parse(Console.ReadLine());
            //Resolución con ciclo while
            /*while(cantidad<n)
            {
                Console.WriteLine(impar);
                impar += 2;
                cantidad++;
            }*/
            //Fin Resolución
            //Resoluciòn con ciclo do-while
            /*do
            {
                Console.WriteLine(impar);
                impar += 2;
                cantidad++;
            } while (cantidad < n);*/
            //Fin Resolución
            //Resoluciòn con ciclo for
            for (cantidad = 1; cantidad <= n; cantidad++)
            {
                Console.WriteLine(impar);
                impar += 2;
            }
            //Fin Resolución
            //FIN PROBLEMA
        }
    }
}
