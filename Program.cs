using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_djalma_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escolha uma das 3 figuras:\n1 escaleno\n2 triângulo \n3 paralelogramo");
            double figura = Convert.ToInt64(Console.ReadLine());
            switch (figura)
            {

                case 1:

                    double lado1, lado2, lado3, resultado;
                    Console.Write("digite o valor do primeiro lado escaleno: ");
                    lado1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("digite o valor do segundo lado escaleno: ");
                    lado2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("digite o valor do terceiro lado do escaleno: ");
                    lado3 = Convert.ToDouble(Console.ReadLine());
                    resultado = lado1 + lado2 + lado3 / 2;
                    if (lado1 == lado2 && lado1 == lado3)
                    {
                        Console.Write(" os lados do escaleno nao podem ser iguais digite novamente");
                        
                    }
                    else if (lado2 == lado3 )
                    {
                        Console.Write("os lados dos escaleno nao podem ser iguais digite novamente");
                    }
                    else
                    Console.Write($"a area do escaleo e: {resultado}");
                   
                    break;
                case 2:
                    double altura, b, area;
                    Console.Write("informe altura do triangulo: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.Write("informe a base do triangulo: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    area = (b * altura) / 2;
                    Console.Write($" A area do triangulo e {area}  ");
                    
                    
                    break;
                case 3:
                    double ba, h, a;
                    Console.Write("me informe a base do paralelogramo ");
                    ba = Convert.ToDouble(Console.ReadLine());
                    Console.Write("informe a altura do paralelogramo ");
                    h = Convert.ToDouble(Console.ReadLine());
                    a = (ba * h);
                    Console.Write($"a area do paralelogramo e {a} ");
                    break;

            }
                Console.ReadKey();

              
            

           
        }
    }
}
