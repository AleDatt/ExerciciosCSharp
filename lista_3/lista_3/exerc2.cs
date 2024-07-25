using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal class exerc2
    {
        public void Exe1() 
        {
            Console.WriteLine("                                 -- Exercício 1 --\nAlgoritmo que leia um número e o imprima caso ele seja maior que 20. ");
            Console.WriteLine("\n\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());
            
            if (num > 20)
            {
                Console.WriteLine("O número " + num + " é maior que 20!");
            }
            else
            {
                Console.WriteLine("O número digitado é menor que 20!");
            }
        }
        public void Exe2()
        {
            Console.Clear();
            Console.WriteLine("                                 -- Exercício 2 --\nLer um valor e escrever a mensagem “É MAIOR QUE 10!”  \r\n\r\nse o valor lido for maior que 10, caso contrário escrever “NÃO É MAIOR QUE 10!” ");
            Console.WriteLine("\n\nDigite um número: ");
            double num = double.Parse(Console.ReadLine());
            if (num == 10)
            {
                Console.WriteLine("O número é IGUAL a 10!");
            }
            else
            {
                if (num > 10)
                {
                    Console.WriteLine("O número é MAIOR que 10!");
                }
                else
                {
                    Console.WriteLine("O número é MENOR que 10!");
                }
            }
        }
        public void Exe3()
        {
            Console.Clear();
            Console.WriteLine("                                 -- Exercício 3 --\nAlgoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C");
            Console.WriteLine("\n\nDigite o valor de A: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double num3 = double.Parse(Console.ReadLine());

            if(num1 + num2 < num3) 
            {
                Console.WriteLine($"A soma de A={num1} + B={num2} é menor que C={num3}.");
            }
            else 
            {
                Console.WriteLine($"A soma de A={num1} + B={num2} não é menor que C={num3}.");
            }
        }
        public void Exe4()
        {
            Console.Clear();
            Console.WriteLine("                                 -- Exercício 4 --\nAlgoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo");
            Console.WriteLine("\n\nDigite o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            // Processamento
            int result = num1 + num2;

            if(result > 10)
            {
                Console.WriteLine("O resultado da adição é: " + result);
            }          
        }
        public void Exe5() 
        { 
            Console.Clear();
            Console.WriteLine("                                 -- Exercício 5 --\nAlgoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos). \r\n\r\n ");
            string nome, sexo, estadoCivil;
            int tempocasada;

            Console.WriteLine("\n\nDigite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Sexo fisiologico (M/F): ");
            sexo = Console.ReadLine();
            Console.WriteLine("Digite o Estado Civil: ");
            estadoCivil = Console.ReadLine();

            if(sexo.ToUpper() == "F" && estadoCivil.ToUpper() == "CASADA") 
            {
                Console.WriteLine("Digite o tempo de casada em ANOS: ");
                tempocasada = int.Parse(Console.ReadLine());
            }
        }
        public void Exe6() 
        { 
            Console.Clear();
            Console.WriteLine("                                 -- Exercício 6 --\nAlgoritmo para receber um número qualquer e informar na tela se é par ou ímpar.");
            Console.WriteLine("\n\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());

            // Processamento
            if (num % 2 == 0) 
            {
                Console.WriteLine($"O número {num} é PAR!");
            }
            else
            {
                Console.WriteLine($"O número {num} é ÍMPAR!");
            }

        }
        public void Exe7() 
        { 
            Console.Clear();
            Console.WriteLine("                                 -- Exercício 7 --\nAlgoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.");
            Console.WriteLine("\n\nDigite o valor de A: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o valor de B: ");
            int num2 = int.Parse(Console.ReadLine());

            int result;
            // Processamento
            if(num1 == num2) 
            {
                result = num2 - num1;
            }
            else 
            {
                result = num2*num1;
            }
            Console.WriteLine($"O resultado é: {result}");
        }
        public void Exe8() 
        {
            Console.Clear ();
            Console.WriteLine("                                -- Exercício 8 --\nEncontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.");
            Console.WriteLine("\n\nDigite um número: ");
            double num = double.Parse(Console.ReadLine());
            double result;
            if (num > 0) 
            {
                result = num*2;
            }
            else 
            {
                result = num * 3;
            }
            Console.WriteLine($"O resultado é: {result}");
        }
        public void Exe9() 
        {
            Console.Clear();
            Console.WriteLine("-- Exercício 9 --\n Algoritmo que leia 3 valores retorno do maior para o menor ordenados.");
            Console.WriteLine("Digite o primeiro valor: ");
            double num1 = double.Parse (Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro valor: ");
            double num3 = double.Parse(Console.ReadLine());

            // Ordenação dos valores
            if(num1 == num2 && num2 == num3) 
            {
                Console.WriteLine($"\nTodos os valores são iguais: {num1}, {num2}, {num3}.");
            }
            else 
            { 
                if(num1 > num2 && num1 > num3) 
                {
                    if(num2 >= num3) 
                    {
                        Console.WriteLine($"\nValores ordenados: {num1}, {num2}, {num3}.");
                    }
                    else 
                    {
                        Console.WriteLine($"\nValores ordenados: {num1}, {num3}, {num2}.");
                    }
                }
                if (num2 > num1 && num2 > num3)
                {
                    if (num1 >= num3)
                    {
                        Console.WriteLine($"\nValores ordenados: {num2}, {num1}, {num3}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nValores ordenados: {num2}, {num3}, {num1}.");
                    }
                }
                if (num3 > num1 && num3 > num2)
                {
                    if (num1 >= num2)
                    {
                        Console.WriteLine($"\nValores ordenados: {num3}, {num1}, {num3}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nValores ordenados: {num3}, {num2}, {num1}.");
                    }
                }
            }
        }
        public void Exe10() 
        {
            Console.Clear();
            Console.WriteLine("-- Exercicío 10 --\nAlgoritmo que leia 3 valores retorne do menor para o maior ordenado.");
            Console.WriteLine("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro valor: ");
            double num3 = double.Parse(Console.ReadLine());

            // Ordenação dos valores
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine($"Todos os valores são iguais: {num1}, {num2}, {num3}.");
            }
            else
            {
                if (num1 < num2 && num1 < num3)
                {
                    if (num2 <= num3)
                    {
                        Console.WriteLine($"\nValores ordenados: {num1}, {num2}, {num3}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nValores ordenados: {num1}, {num3}, {num2}.");
                    }
                }
                if (num2 < num1 && num2 < num3)
                {
                    if (num1 <= num3)
                    {
                        Console.WriteLine($"\nValores ordenados: {num2}, {num1}, {num3}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nValores ordenados: {num2}, {num3}, {num1}.");
                    }
                }
                if (num3 < num1 && num3 < num2)
                {
                    if (num1 <= num2)
                    {
                        Console.WriteLine($"\nValores ordenados: {num3}, {num1}, {num3}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nValores ordenados: {num3}, {num2}, {num1}.");
                    }
                }
            }
        }
        public void Exe11()
        { 
            Console.Clear();
            Console.WriteLine("-- Exercício 11 --\nLer a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte retornar quantas horas estão jogando e quantidade de horas restante ou quantidade de horas excedente. ");
            Console.WriteLine("\n\nInforme o dia inicial (Apenas o Dia): ");
            int di = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o dia final: ");
            int df = int.Parse(Console.ReadLine());
            int duracao, dias, exc, diasexc, horasexc;


            if (di>df) 
            {
                Console.WriteLine("\nPor favor, informe uma data final igual ou superior a data inicial!!\nMuito Obrigado!!");
            }
            else 
            {
                Console.WriteLine("\nInforme a hora inicial (Apenas a hora, desconsidere os minutos): ");
                int hi = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInforme a hora final (Apenas a hora, desconsidere os minutos): ");
                int hf = int.Parse(Console.ReadLine());

                // Saída de Dados
                if(di == df && hi> hf) 
                {
                    Console.WriteLine("\nPara jogos que começam e terminam no mesmo dia, por favor informe uma Hora Inicial maior do que a Hora Final!!!\nMuito Obrigrado!!");
                }
                else 
                {
                    //Processamento
                    duracao = (df - di) * 24 + hf - hi;
                    dias = (df - hi);
                    exc = duracao - 24;
                    diasexc = exc / 24;
                    horasexc = exc % 24;

                    // Se não passou das 24h
                    if (duracao <= 24) 
                    {
                        Console.Clear ();
                        Console.WriteLine($"\nDados do jogo:\n\nTempo total: {duracao} hora(s)\nHoras restantes para 24h: {24 - duracao}h\nObrigado por participar!!!");
                    }
                    //Se passou das 24h
                    else 
                    {
                        if (hf > hi) 
                        {
                            Console.Clear();
                            Console.WriteLine($"\nO JOGO EXCEDEU O LIMITE DE 24h!!!   (Segue os dados EXCEDENTES do jogo)\nDados do jogo:\n\nTempo total: {duracao} hora(s) ou {dias}d e {hf-hi} hora(s)\nHoras excedentes do periodo de 24h: {exc}h ou {diasexc}d e {horasexc}h\nObrigado por participar!!!");
                        }
                        else 
                        {
                            Console.WriteLine($"\nO JOGO EXCEDEU O LIMITE DE 24h!!!   (Segue os dados EXCEDENTES do jogo)\nDados do jogo:\n\nTempo total: {duracao} hora(s) ou {dias}d\nHoras excedentes do periodo de 24h: {exc}h ou {diasexc}d e {horasexc}h\nObrigado por participar!!!");
                        }

                    }
                }
            }
        }
        public void Exe12()
        {
            Console.Clear();
            Console.WriteLine("Os exercícios terminaram\n\nFIM.");
        }
    }
}
