using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPara
{
    internal class menu
    {
        static void Main(string[] args) 
        {
            int opt = 0;



            //menu principal



            Console.WriteLine("Entre com a opção desejada:");




            Console.WriteLine("1 - Exercício 1 ");
            Console.WriteLine("2 - Exercício 2 ");
            Console.WriteLine("3 - Exercício 3 ");
            Console.WriteLine("4 - Exercício 4 ");
            Console.WriteLine("5 - Exercício 5 ");
            Console.WriteLine("6 - Exercício 6 ");
            Console.WriteLine("7 - Exercício 7 ");




            opt = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");



            Console.Clear();




           exercicioPara executa = new exercicioPara ();




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


                default:
                    Console.WriteLine("Digite um número válido");
                    break;




            }
        }
    }

}
