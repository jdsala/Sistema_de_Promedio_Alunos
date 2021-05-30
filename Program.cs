using System;

namespace Matriz
{
    class Program
    {
        struct Notas
        {
            public double nota_Um, nota_Dois, nota_Treis, nota_Quatro;
            public double promedio;
        }
        static void Main(string[] args)
        {
            promedio_Aluno();

            //Console.WriteLine("Hello World!");
        }
        static void promedio_Aluno()
        {
            Notas[] notas = new Notas[4];
            string aluno_Nome;


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Introducir o nome do Aluno: ");
                aluno_Nome = Console.ReadLine();

                Console.WriteLine("Introducir a nota 1: ");
                notas[i].nota_Um = int.Parse(Console.ReadLine());

                Console.WriteLine("Introducir a nota 2: ");
                notas[i].nota_Dois = int.Parse(Console.ReadLine());

                Console.WriteLine("Introducir a nota 3: ");
                notas[i].nota_Treis = int.Parse(Console.ReadLine());

                Console.WriteLine("Introducir a nota 4: ");
                notas[i].nota_Quatro = int.Parse(Console.ReadLine());

                //if ((notas[i].nota_Um >= 1 || notas[i].nota_Um <= 11) && (notas[i].nota_Dois >= 1 || notas[i].nota_Dois <= 10) && (notas[i].nota_Treis >= 1 || notas[i].nota_Treis <= 10) && (notas[i].nota_Quatro >= 1 || notas[i].nota_Quatro <= 10))
                //{
                //    notas[i].promedio = (notas[i].nota_Um + notas[i].nota_Dois + notas[i].nota_Treis + notas[i].nota_Quatro) / 4;
                //    Console.WriteLine("A nota promedio do Aluno {0} é : {1} ", aluno_Nome, notas[i].promedio);
                //}

                if (notas[i].nota_Um < 1 || notas[i].nota_Um > 10)
                {
                    notas[i].promedio = (notas[i].nota_Dois + notas[i].nota_Treis + notas[i].nota_Quatro) / 3;
                    Console.WriteLine("Nota incorreta! {0}", notas[i].nota_Um);
                    Console.WriteLine("A nota promedio do Aluno {0} é : {1} ", aluno_Nome, notas[i].promedio);


                }
                else if (notas[i].nota_Dois < 1 || notas[i].nota_Dois > 10)
                {
                    notas[i].promedio = (notas[i].nota_Um + notas[i].nota_Treis + notas[i].nota_Quatro) / 3;
                    Console.WriteLine("Nota incorreta! {0}", notas[i].nota_Dois);
                    Console.WriteLine("A nota promedio do Aluno {0} é : {1} ", aluno_Nome, notas[i].promedio);

                }

                else if (notas[i].nota_Treis < 1 || notas[i].nota_Treis > 10)
                {
                    notas[i].promedio = (notas[i].nota_Um + notas[i].nota_Dois + notas[i].nota_Quatro) / 3;
                    Console.WriteLine("Nota incorreta! {0}", notas[i].nota_Treis);
                    Console.WriteLine("A nota promedio do Aluno {0} é : {1} ", aluno_Nome, notas[i].promedio);
                }

                else if (notas[i].nota_Quatro < 1 || notas[i].nota_Quatro > 10)
                {
                    notas[i].promedio = (notas[i].nota_Um + notas[i].nota_Dois + notas[i].nota_Treis) / 3;
                    Console.WriteLine("Nota incorreta! {0}", notas[i].nota_Quatro);
                    Console.WriteLine("A nota promedio do Aluno {0} é : {1} ", aluno_Nome, notas[i].promedio);

                }
                else
                {
                    notas[i].promedio = (notas[i].nota_Um + notas[i].nota_Dois + notas[i].nota_Treis + notas[i].nota_Quatro) / 4;
                    Console.WriteLine("A nota promedio do Aluno {0} é : {1} ", aluno_Nome, notas[i].promedio);

                }


                /* //Declarando Arrays
                 int tamanho = 5;
                 int[] numeros = new int[]{tamanho};

                 for(int i =0; i < tamanho; i++)
                 {
                     for(int colun = 0; colun < tamanho; colun++)
                     {
                        Console.WriteLine(numeros[i]); 

                     }
                     //Console.WriteLine("Número impresso é {0} ", numeros[i]);
                 }
                 */
            }

        }
    }
}
