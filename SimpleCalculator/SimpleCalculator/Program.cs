using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        //Nu even een test voor het pushen naar GitHub
        //Hoezo geen commits?

        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // TODO: start logging exceptions
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
