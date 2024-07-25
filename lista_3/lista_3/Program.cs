using ConsoleApp2;
using exercicioPara;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opt = 0;
            int lista;


            //menu principal


            Console.WriteLine("Entre com a opção desejada:");

            Console.WriteLine("1 - lista 1");
            Console.WriteLine("2 - lista 2 exerc");
            Console.WriteLine("3 - lista 3");
            Console.WriteLine("4 - lista 4 Para");
            Console.WriteLine("5 - listaExeVetor");

            lista = int.Parse(Console.ReadLine());

            if (lista == 1)
            {

                Console.WriteLine("1 - Exercício 1 ");
                Console.WriteLine("2 - Exercício 2 ");
                Console.WriteLine("3 - Exercício 3 ");
                Console.WriteLine("4 - Exercício 4 ");
                Console.WriteLine("5 - Exercício 5 ");
                Console.WriteLine("6 - Exercício 6 ");
                Console.WriteLine("7 - Exercício 7 ");
                Console.WriteLine("8 - Exercício 8 ");
                Console.WriteLine("9 - Exercício 9 ");
                Console.WriteLine("10 - Exercício 10 ");


                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");


                Console.Clear();


                Lista_1 executa = new Lista_1();


                switch (opt)
                {
                    case 1:

                        executa.exe1();

                        break;


                    case 2:

                        executa.exe2();

                        break;


                    case 3:

                        executa.exe3();

                        break;


                    case 4:

                        executa.exe4();

                        break;


                    case 5:

                        executa.exe5();

                        break;


                    case 6:

                        executa.exe6();

                        break;


                    case 7:

                        executa.exe7();

                        break;


                    case 8:

                        executa.exe8();

                        break;


                    case 9:

                        executa.exe9();

                        break;


                    case 10:

                        executa.exe10();

                        break;


                    default:
                        Console.WriteLine("Digite um número válido");
                        break;
                }



            }
            else if (lista == 2)
            {

                Console.WriteLine("1 - Exercício 1 ");
                Console.WriteLine("2 - Exercício 2 ");
                Console.WriteLine("3 - Exercício 3 ");
                Console.WriteLine("4 - Exercício 4 ");
                Console.WriteLine("5 - Exercício 5 ");
                Console.WriteLine("6 - Exercício 6 ");
                Console.WriteLine("7 - Exercício 7 ");
                Console.WriteLine("8 - Exercício 8 ");
                Console.WriteLine("9 - Exercício 9 ");
                Console.WriteLine("10 - Exercício 10 ");
                Console.WriteLine("11 - Exercício 11 ");


                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");


                Console.Clear();


                exerc2 executa = new exerc2();


                switch (opt)
                {
                    case 1:

                        executa.Exe1();

                        break;


                    case 2:

                        executa.Exe2();

                        break;


                    case 3:

                        executa.Exe3();

                        break;


                    case 4:

                        executa.Exe4();

                        break;


                    case 5:

                        executa.Exe5();

                        break;


                    case 6:

                        executa.Exe6();

                        break;


                    case 7:

                        executa.Exe7();

                        break;


                    case 8:

                        executa.Exe8();

                        break;


                    case 9:

                        executa.Exe9();

                        break;


                    case 10:

                        executa.Exe10();

                        break;


                    case 11:

                        executa.Exe11();

                        break;


                    default:
                        Console.WriteLine("Digite um número válido");
                        break;



                }
            }
            else if (lista == 3)
            {

                Console.WriteLine("1 - Exercício 1 ");
                Console.WriteLine("2 - Exercício 2 ");
                Console.WriteLine("3 - Exercício 3 ");
                Console.WriteLine("4 - Exercício 4 ");
                Console.WriteLine("5 - Exercício 5 ");
                Console.WriteLine("6 - Exercício 6 ");


                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");


                Console.Clear();


                exercicios_lista_3 executa = new exercicios_lista_3();


                switch (opt)
                {
                    case 1:

                        executa.Exe1();

                        break;


                    case 2:

                        executa.Exe2();

                        break;


                    case 3:

                        executa.Exe3();

                        break;


                    case 4:

                        executa.Exe4();

                        break;


                    case 5:

                        executa.Exe5();

                        break;


                    case 6:

                        executa.Exe6();

                        break;



                    default:
                        Console.WriteLine("Digite um número válido");
                        break;
                }
            }

            else if (lista == 4)
            {
                Console.WriteLine("1 - Exercício 1 ");
                Console.WriteLine("2 - Exercício 2 ");
                Console.WriteLine("3 - Exercício 3 ");
                Console.WriteLine("4 - Exercício 4 ");
                Console.WriteLine("5 - Exercício 5 ");
                Console.WriteLine("6 - Exercício 6 ");
                Console.WriteLine("7 - Exercício 7 ");
                Console.WriteLine("8 - Exercício 8 ");
                Console.WriteLine("9 - Exercício 9 ");
                Console.WriteLine("10 - Exercício 10 ");

                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");


                Console.Clear();


                exercicioPara_4 executa = new exercicioPara_4();


                switch (opt)
                {
                    case 1:

                        executa.exercicioPara1();

                        break;


                    case 2:

                        executa.exercicioPara2();

                        break;


                    case 3:

                        executa.exercicioPara3();

                        break;


                    case 4:

                        executa.exercicioPara4();

                        break;


                    case 5:

                        executa.exercicioPara5();

                        break;


                    case 6:

                        executa.exercicioPara6();

                        break;


                    case 7:

                        executa.exercicioPara7();

                        break;

                        
                    case 8:

                        executa.exercicioPara8();

                        break;

                    
                    case 9:

                        executa.exercicioPara9();

                        break;

                    
                    case 10:

                        executa.exercicioPara10();

                        break;



                    default:
                        Console.WriteLine("Digite um número válido");
                        break;


                }
            }
            else if (lista == 5)
            {
                Console.WriteLine("1 - Exercício 1 ");
                Console.WriteLine("2 - Exercício 2 ");
                Console.WriteLine("3 - Exercício 3 ");
                Console.WriteLine("4 - Exercício 4 ");
                Console.WriteLine("5 - Exercício 5 ");
                Console.WriteLine("6 - Exercício 6 ");

                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");


                Console.Clear();


                listaExeVetor executa = new listaExeVetor();


                switch (opt)
                {
                    case 1:

                        executa.listaExeVetor1();

                        break;


                    case 2:

                        executa.listaExeVetor2();

                        break;


                    case 3:

                        executa.listaExeVetor3();

                        break;


                    case 4:

                        executa.listaExeVetor4();

                        break;


                    case 5:

                        executa.listaExeVetor5();

                        break;

                    
                    case 6:

                        executa.listaExeVetor6();

                        break;


                    default:
                        Console.WriteLine("Digite um número válido");
                        break;
                    
                }
            }
        }
    }
}
