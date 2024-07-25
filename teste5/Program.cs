using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double x, y,z,delta,bhaskara, resultado;
        string vet = "0";

        

        while (vet == "0")
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Digite para a ação: \n1 - Adição\n2 - Subtração\n3 - Multiplacação\n4 - Divisão\n" +
                "5 - Potencia\n6 - Raiz Quadrada\n7 - Porcentagem\n8 - Bhaskara\n9 - Fatorial\n10 - Integral\n11 - Sair");
            vet = Console.ReadLine();

            //Adição
            if (vet == "1") {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor ");
                y = double.Parse(Console.ReadLine());
                z = x + y;
                Console.WriteLine("O valor da soma dos numeros é: "+ z+ "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }
            
            //Subtração
            else if (vet == "2") {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor ");
                y = double.Parse(Console.ReadLine());
                z = x - y;
                Console.WriteLine("O valor da subtração dos numeros é: " + z + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }
            
            //Multiplicação
            else if (vet == "3") {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor ");
                y = double.Parse(Console.ReadLine());
                z = x * y;
                Console.WriteLine("O valor da mutiplicação dos numeros é: " + z + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }

            //Divisão 
            else if (vet == "4"){
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor que será dividido");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o em quantas vezes irá dividi-lo");
                y = double.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine("O valor da divisão do numero é: " + z + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }

            //Potencia
            else if (vet == "5") {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de sua potencia ");
                y = double.Parse(Console.ReadLine());
                z = Math.Pow(x, y);                
                Console.WriteLine("O valor da base "+ x + " com o expoente " + y + " resulta na potência de: " + z + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }

            //Raiz Quadrada
            else if (vet == "6") {
                Console.Clear();
                Console.WriteLine("Digite o valor: ");
                x = double.Parse(Console.ReadLine());
                y = Math.Sqrt(x);
                Console.WriteLine("O valor da raiz quadrada do numero "+ x + " é: " + y + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }

            //Porcentagem
            else if (vet == "7"){
                Console.Clear();
                Console.WriteLine("Digite o numero inteiro: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a porcetagem que quer verificar dele: ");
                y = double.Parse(Console.ReadLine());
                z = x * (y/100);
                Console.WriteLine("A porcetagem é: " + z + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();
            }

            // Bhaskara
            else if (vet == "8")
            {
                Console.Clear();
                Console.WriteLine("Digite o calor A: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o calor B: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o calor C: ");
                z = double.Parse(Console.ReadLine());

                delta = (y * y) - 4 * x * z;

                if (delta < 0)
                {
                    Console.WriteLine("O valor de Delta é menor que zero, numeros menores que zero não contem raiz quadrada, teremos que usar a imaginação");
                    Console.WriteLine("O valor de Delta é: " + delta);
                    delta = -delta;
                    

                    //Console.WriteLine("Poderiamos transformar o Delta em um numero imaginario como no seu resultado: " + delta + "i ");
                    bhaskara = (-y) / (2 * x);
                    resultado = (Math.Sqrt(delta)) / (2 * x);

                    Console.WriteLine("Os valores de Bhaskara são:\n" + bhaskara+ "(+)"+resultado+"i\n"+ bhaskara + "(-)" + resultado + "i");


                }
               
                else if (delta >= 0)
                {
                    Console.WriteLine("O valor de Delta é: " + delta);
                    bhaskara = ((-y) + Math.Sqrt(delta)) / (2*x);
                    Console.WriteLine("O valor de bhaskara com o delta positivo é: " + bhaskara);


                    bhaskara = ((-y) - Math.Sqrt(delta)) / (2*x);
                    Console.WriteLine("O valor de bhaskara com o delta negativo é: " + bhaskara);
                }
                Console.WriteLine("\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();

            }
            
            //Fatorial
            else if (vet == "9")
            {
                Console.WriteLine("Digite o numero que será fatorado: ");
                x = double.Parse(Console.ReadLine());
                y = 1;
                for (int i = 1; i <= x; i++)
                {
                    y = y * i;
                }
                Console.WriteLine("O valor do calculo é: "+ y + "\n\n\nAperte qualquer tecla para continuar");
                Console.ReadKey();
                vet = "0";
                Console.Clear();

            }
            
            // Integral
            else if (vet =="10")
            {

            }

            // Sair
            else if (vet == "11"){
                vet = "1";
            }
            
            // Folgado
            else { 
                Console.Clear();
                Console.WriteLine("ESSE VALOR NÃO EXISTE!!!\n\n");
                vet = "0"; 
            }

        }




    }
}