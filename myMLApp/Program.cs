using System;
using MyMLAppML.Model;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Leave a Comment,Please :");
             
            string Coment;
            Coment = Console.ReadLine();//Get a comment from the user.
            var input = new ModelInput();
            input.SentimentText = Coment;//Give the comment left as input

            // Load model and predict output from the comment left
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}\n");
        }
    }
}