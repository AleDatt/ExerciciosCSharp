﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3
{
    internal class listaExeVetor
    {
        public void listaExeVetor1()
        //Escreva um programa que recebe dois vetores de números inteiros do usuário, realiza a soma elemento por elemento e exibe o vetor resultante.
        {

            Console.WriteLine("informe o primeiro valor: ");
            int[] vetor1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("informe o segundo valor: ");
            int[] vetor2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] resultado = new int[vetor1.Length];

            for (int i = 0; i < vetor1.Length; i++) 
            {
                resultado [i] = vetor1[i] + vetor2[i];
            }

            Console.WriteLine("O resultado da soma dos vetores é: " +  resultado);
            Console.WriteLine(string.Join(" ", resultado));
        
        }


        public void listaExeVetor2() 
        //Escreva um programa que encontre o maior e o menor elemento em um vetor
        {
            Console.WriteLine("Digite os elementos do vetor separados por espaço: ");
            int[] vetor = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int maior = vetor[0];
            int menor = vetor[0];

            for (int i = 1; i < vetor.Length; i++) 
            {
                if (vetor[i] > maior)
                    maior = vetor[i];

                if (vetor[i] < menor)
                    menor = vetor[i];
            }
            Console.WriteLine($"Maior elemento: {maior}");
            Console.WriteLine($"Menor elemento: {menor}");
        
        }


        public void listaExeVetor3()
        //Escreva um programa que ordena um vetor de números inteiros em ordem crescente. 
        {
            Console.WriteLine("Digite os elementos do vetor separados por espaço: ");
            int[] vetor = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(vetor);

            Console.WriteLine("Vetor ordenado em ordem crescente: ");
            Console.WriteLine(string.Join(" ", vetor));

        }


        public void listaExeVetor4()
        //Escreva um programa que recebe um vetor de números inteiros do usuário e exibe a contagem de elementos pares e ímpares. 
        {
            Console.WriteLine("Digite os elementos do vetor separados por espaço: ");
            int[] vetor = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int pares = 0;
            int impares = 0;

            foreach(int numero in vetor)
            {
                if (numero % 2 == 0)
                    pares++;

                else
                    impares++;
            }

            Console.WriteLine($"Número de elementos pares:  {pares}");
            Console.WriteLine($"numero de elementos impares: {impares}");

        }


        public void listaExeVetor5()
        //Escreva um programa que substitui todas as ocorrências de um determinado elemento por outro em um vetor. 
        {
            Console.WriteLine("Digite os elementos do vetor separados por espaço: ");
            int[] vetor = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }
    }
}
