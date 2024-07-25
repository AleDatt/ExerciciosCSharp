using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lista_3
{
    internal class exercicios_lista_3
    { 
   
        public void Exe1()
            //Faça um programa que receba 3 valores e retorne a soma deles.
        {
            int[] vetor = new int[3];

            Console.WriteLine("Entre com o primeiro valor: ");
            vetor[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            vetor[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro valor: ");
            vetor[2] = int.Parse(Console.ReadLine());


            Console.WriteLine(vetor[0] + vetor[1] + vetor[2]);

        }

        public void Exe2()
        //Faça um programa que receba quatro notas e retorne a média.
        {
            double[] vetor = new double[4];
            double result;

            Console.WriteLine("Informe a nota do primeiro bimestre: ");
            vetor[0] = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a nota do segundo bimestre: ");
            vetor[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do terceiro bimestre: ");
            vetor[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do quarto bimestre: ");
            vetor[3] = double.Parse(Console.ReadLine());

            result = (vetor[0] + vetor[1] + vetor[2] + vetor[3]) / 4;
            Console.WriteLine($"A média do aluno foi de: " + result);

            if (result >= 6) 
            {
                Console.WriteLine("Aluno aprovado!!!");
            }
            else { Console.WriteLine("Aluno Reprovado!!!");
            }
        }
        public void Exe3()
        //Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome.
        {
            string nome;

            do
            {
                Console.WriteLine("Por favor, digite um nome: ");
                nome = Console.ReadLine();

            }
            while (nome != "João" || nome!= "joão");

        }

        public void Exe4()
        //Faça um programa que retorne à quantidade de números pares existente entre 35 e 98111.
        {
            int i, contador;
            contador = 0;

            for (i = 35; i <= 98111; i++) 
            {
                if (i % 2 == 0) {  contador++; }
            }

            Console.WriteLine("A quantidade de números pares existentes entre 35 e 98111 é:" + contador);
        
        }
        public void Exe5()
        //Faça um programa que some todos os números ímpares de 1 até 5000.
        {
            int i, soma;
            soma = 0;
            
            for (i = 1; i <= 5000; ++i) 
            {
                if ((i % 2) != 0) { soma += i; }
            }

            Console.WriteLine("A soma dos números pares de 1 a 5000 é:" + soma);
        }

        public void Exe6()
        //Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.
        {
            int i, tab, num;

            Console.WriteLine("Por favor, informe qual tabuada você deseja: ");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i <=10; ++i)
            {
                tab = num * i;
                Console.WriteLine($"{i} x {num} = {tab}");
            }
               
            
        }
    }
}
