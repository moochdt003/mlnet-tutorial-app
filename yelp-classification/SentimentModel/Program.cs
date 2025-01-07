
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace SentimentModel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            SentimentModel.ModelInput sampleData = new SentimentModel.ModelInput()
            {
                Col0 = @"Wow... Loved this place.",
            };


            Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");


            Console.WriteLine($"Col0: {@"Wow... Loved this place."}");
            Console.WriteLine($"Col1: {1F}");


            var sortedScoresWithLabel = SentimentModel.PredictAllLabels(sampleData);
            Console.WriteLine($"{"Class",-40}{"Score",-20}");
            Console.WriteLine($"{"-----",-40}{"-----",-20}");

            foreach (var score in sortedScoresWithLabel)
            {
                Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
            }
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
