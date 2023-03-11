using System;

class Program
{
    static void Main(string[] args)
    {
        //Eduardo Hernández 1156823
        Console.WriteLine("Ejercicio 1");
        Console.Write("Número ENTERO: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("RESULTADO: El número es POSITIVO");
            }
            else if (num < 0)
            {
                Console.WriteLine("RESULTADO: El número es NEGATIVO");
            }
            else
            {
                Console.WriteLine("RESULTADO: El número es CERO");
            }
        }
        catch
        {
            Console.WriteLine("ERROR: Ingrese un número entero válido");




            Console.WriteLine("Ejercicio 2");

            Console.Write("Ingrese el número de día: ");
            try
            {
                int numDia = int.Parse(Console.ReadLine());
                if (numDia < 1 || numDia > 7)
                {
                    Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
                }
                else
                {
                    string dia = "";
                    if (numDia == 1)
                    {
                        dia = "lunes";
                    }
                    else if (numDia == 2)
                    {
                        dia = "martes";
                    }
                    else if (numDia == 3)
                    {
                        dia = "miércoles";
                    }
                    else if (numDia == 4)
                    {
                        dia = "jueves";
                    }
                    else if (numDia == 5)
                    {
                        dia = "viernes";
                    }
                    else if (numDia == 6)
                    {
                        dia = "sábado";
                    }
                    else if (numDia == 7)
                    {
                        dia = "domingo";
                    }
                    Console.WriteLine("DIA: " + dia);
                }
            }
            catch
            {
                Console.WriteLine("Error: Ingrese un número válido");
            }


            Console.WriteLine("Tarea");
            Console.Write("Ingrese una cantidad en quetzales: ");
            string input = Console.ReadLine();
            decimal amount;

            
            if (!decimal.TryParse(input, out amount))
            {
                Console.WriteLine("Error: debe ingresar una cantidad en números decimales.");
                return;
            }

            
            amount = decimal.Parse(input);

            
            if (amount < 0 || amount >= 1000)
            {
                Console.WriteLine("Error: la cantidad debe estar entre 0 y 999.99 quetzales.");
                return;
            }

            
            int cienQ = (int)amount / 100;
            int cincuentaQ = (int)(amount % 100) / 50;
            int veinteQ = (int)((amount % 100) % 50) / 20;
            int diezQ = (int)(((amount % 100) % 50) % 20) / 10;
            int cincoQ = (int)((((amount % 100) % 50) % 20) % 10) / 5;
            int unQ = (int)(((((amount % 100) % 50) % 20) % 10) % 5) / 1;
            int veinticincoC = (int)(((((((amount % 100) % 50) % 20) % 10) % 5) % 1) / 0.25M);
            int unC = (int)((((((((amount % 100) % 50) % 20) % 10) % 5) % 1) % 0.25M) / 0.01M);

            
            Console.WriteLine($"Billetes de Q100: {cienQ}");
            Console.WriteLine($"Billetes de Q50: {cincuentaQ}");
            Console.WriteLine($"Billetes de Q20: {veinteQ}");
            Console.WriteLine($"Billetes de Q10: {diezQ}");
            Console.WriteLine($"Billetes de Q5: {cincoQ}");
            Console.WriteLine($"Monedas de Q1: {unQ}");
            Console.WriteLine($"Monedas de Q0.25: {veinticincoC}");
            Console.WriteLine($"Monedas de Q0.01: {unC}");
        }
    }
}