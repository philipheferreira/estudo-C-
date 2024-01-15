using System;
using System.Globalization;

namespace Treino{
    class Programa{
        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i< n; i++){
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++){
                sum += vetor[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }


    }
}