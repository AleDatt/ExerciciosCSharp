using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPara
{
    internal class exercicioPara_4
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
            Console.Clear();
            Console.WriteLine("Modifique o programa anterior para que ele pergunte o nome do usuário e então imprima a mensagem “Bom dia, NOME!” 20 vezes (o mesmo nome). ");

            string nome;
            Console.WriteLine("Por favor,informe o seu nome: ");
            nome = Console.ReadLine();

            for (int i = 1; i <= 20; i++)
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

            Console.Clear();
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
            Console.Clear();
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


        public void exercicioPara8()
            //Escreva um programa para ler as coordenadas(X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.
            //para cada ponto escrever o quadrante a que ele pertence. o algoritmo será encerrado quando pelo menos uma de duas coordenadas for nula.
        {
            int x, y;

            Console.WriteLine("Entre com um valor para X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um valor para Y: ");
            y = int.Parse(Console.ReadLine());

            while
                (x > 0 || y > 0)
            {
                Console.WriteLine("Nulo");

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }

                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");

                }
                else if (y < 0 && x < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }
            }
        }
        public void exercicioPara9()
            //Posto de gasolina
        {
            int a = 0, g = 0, d = 0, combustivel;

            do
            { 
                Console.WriteLine("Digite tipo de combustível abastecido, sendo 1 para Álcool, 2 para Gasolina, 3 para Diesel e 4 par fim: ");
                combustivel = int.Parse(Console.ReadLine());

                if (combustivel == 1) { a++; }

                if (combustivel == 2) { g++; }

                if (combustivel == 3) { d++; }

            } while (combustivel != 4);

            Console.WriteLine("Muito Obrigado!!!");
            Console.WriteLine($"Álcool: {a}\n Gasolina: {g}\n Diesel: {d}");
        }
        public void exercicioPara10()
            //Leia um valor inteiro X que varie entre 1 e 1000. Em seguida mostre os ímpares de 1 até x, um valor por linha. 
        {
            int num;
           
            Console.WriteLine("Digite um valor para X: ");
            num = int.Parse(Console.ReadLine());

            if (num <= 1000)
            {
                Console.WriteLine("Números impares: ");

                for (int i = 0; i < num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($" {i} ");
                    }
                }
            }
        }
    }
}
