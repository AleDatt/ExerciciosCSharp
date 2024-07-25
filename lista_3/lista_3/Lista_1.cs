using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lista_3
{
    internal class Lista_1
    {
        public void exe1()
           //Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
        {
            Console.WriteLine("Olá Mundo!!!");
        } 
        
        public void exe2()
            //Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas vindas para ela:
        {
            string nome;
            Console.WriteLine("Por favor, digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, seja bem vindo!!!");

        }

        public void exe3()
        //Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas vindas para ela:
        {
            string nome;
            double salario;

            Console.WriteLine("Digite o nome do(a) funcionário(a): ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário {nome} recebe um salário de: {salario}");
        }

        public void exe4()
            // Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
        {
            int num1, num2, soma;
            Console.WriteLine("Digite o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("A soma dos valores digitados é: " + soma);
        }
        public void exe5()
            //Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.
        {
            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media =(nota1 + nota2) / 2;

            Console.WriteLine("A média do aluno foi de: " +  media);
        }

        public void exe6()
            //Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.
        {
            int num, sucessor, antecessor;

            Console.WriteLine("Por favor, digite um número: ");
            num = int.Parse(Console.ReadLine());

            sucessor = num + 1;
            antecessor = num - 1;

            Console.WriteLine($"O número digitado foi: {num}, seu antecessor é: {antecessor} e o seu sucessor: {sucessor}");
        }

        public void exe7()
            //Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.
        {
            double num, dobro, terco;

            Console.WriteLine("Digite um numero: ");
            num = double.Parse(Console.ReadLine());

            dobro = num * 2;
            terco = num / 3;

            Console.WriteLine($"O número digita é: {num}, o dobro é: {dobro} e a terça parte: {terco}");
        }
        
        public void exe8()
            //Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.
                //Km, Hm, Dam, dm, cm, mm
        {
            double num, km, hm, dam, dm, cm, mm;

            Console.WriteLine("Informe a metragem que deseja converter: ");
            num = double.Parse(Console.ReadLine());

            km = num / 1000;
            hm = num / 100;
            dam = num / 10;
            dm = num * 10;
            cm = num * 100;
            mm = num * 1000;

            Console.WriteLine($"A distância convertida é:\n km : {km}\n hm : {hm}\n Dam: {dam}\n dm: {dm}\n cm: {cm}\n mm: {mm}");
        }
        
        public void exe9()
            //Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar.Considere US$1,00 = R$4,93.
        {
           double real,converter;

            Console.WriteLine("Qual valor você deseja converter em Dollar: ");
            real = double.Parse(Console.ReadLine());

            converter = real / 4.93;

            Console.WriteLine($"Os valores convertidos resultam no total de: {Math.Round(converter,2)} Dollares");

        }

        public void exe10()
            //Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,\n sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.
        {
            double largura, altura, area, quantidade;

            Console.WriteLine("Qual é a largura da parede a ser pintada: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a altura dessa parede: ");
            altura = double.Parse(Console.ReadLine());

            area = largura * altura;

            quantidade = area / 2;

            Console.WriteLine($"Será necessário {quantidade} litros de tinta para pintar essa parede.");
        }
    }
}
