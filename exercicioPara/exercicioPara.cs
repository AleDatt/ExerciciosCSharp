using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPara
{
    internal class exercicioPara
    {
        public void exercicioPara1()
        {
            
            

            Console.Clear();
            Console.WriteLine("Crie um programa que imprima na tela a mensagem \"Bom dia\" 15 vezes, usando o laço para:\n ");

            int i;

            for (i = 1; i <= 15; i++)
            {
            Console.WriteLine($"{i} Bom dia!!!\n");
            }
            
        }
        public void exercicioPara2()
        {
            Console.Clear ();
            Console.WriteLine("Modifique o programa anterior para que ele pergunte o nome do usuário e então imprima a mensagem “Bom dia, NOME!” 20 vezes (o mesmo nome). ");

            string nome;
            Console.WriteLine("Por favor,informe o seu nome: ");
            nome = Console.ReadLine();

            for (int i = 1;i <= 20;i++)
            {
                Console.WriteLine($"Bom dia {nome}!!!");
            }

        }

        public void exercicioPara3() 
        {
            Console.Clear();
            Console.WriteLine("Crie um algoritmo que imprima na tela a sequência descendente de números entre 100 e 10.");

            int i;

            for (i = 100; i >= 10; i--) 
            
            {
                Console.WriteLine(i + " \n");
            }

        }

        public void exercicioPara4()
        {
            Console.Clear();
            Console.WriteLine("Crie um algoritmo que mostre a sequência de números entre 0 e um número qualquer digitado pelo usuário\n (pedir para o usuário digitar um número maior que zero, mas sem realizar validação). \n ");

            int num;

            Console.WriteLine("Por favor, digite um número que seja maior que zero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++) 
            {
                Console.WriteLine($"{i}\n");
            }
        }

        public void exercicioPara5()
        { 
            Console.Clear();
            Console.WriteLine("Modifique o programa anterior para que exiba uma sequência de números entre 10 e um número qualquer digitado pelo\n usuário, que seja maior do que 10. O programa deve mostrar mensagem de erro caso o número escolhido seja igual ou menor a 10 \n ");

            int num;

            Console.WriteLine("Por favor, digite um número que seja maior que dez: \n");
            num = int.Parse(Console.ReadLine());

            if (num > 10)
            {

                for (int i = 10; i <= num; i++)
                {
                    Console.WriteLine($"{i}\n");
                }
            }
            else { Console.WriteLine("O número digitado é menor que 10, tente novamente!!!"); }
        }

        public void exercicioPara6() 
        {
        
            Console.Clear ();
            Console.WriteLine("Escreva um programa que mostre na tela a soma total da sequência de números 1 + 1/2 + 1/3 + … + 1/20. \nMostrar o resultado com quatro casas decimais.  ");

            double num = 0.0;
            
            for (int i = 1; i <= 20; i++)
            {
                num = num + 1.0 / i;
            }
            Console.WriteLine($"{Math.Round(num, 4)}\n");
        }

        public void exercicioPara7()
        {
            Console.Clear ();
            Console.WriteLine(" Escreva um programa que mostre na tela a tabuada de um número qualquer escolhido pelo usuário.\nA tabuada consiste nos resultados das multiplicações do número escolhido pelos números de 1 até 10. \r\nObs.: Caso o usuário entre com o valor 0 (zero) deve ser exibida uma mensagem de erro, em vez do cálculo da tabuada.\n ");

            int num, tab;

            Console.WriteLine("Por favor, informe qual tabuada que vc quer: ");
            num = int.Parse(Console.ReadLine());

            
            
            if (num == 0)
            {
                Console.WriteLine("Informe um número maior q zero!!!");
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    tab = num * i;
                    Console.WriteLine($"{i} x {num} = {tab}");
                }
            }
        }
    }
}
