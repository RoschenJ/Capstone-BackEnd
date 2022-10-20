using Google.Cloud.Vision.V1;
using System;

namespace VisionApiDemo
{
    class gVision
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "./key.json");
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromFile("bedroom.jpg");
            var labels = client.DetectLabels(image);

            Console.WriteLine("Labels (and confidence score):");
            Console.WriteLine(new String('=', 30));

            /*foreach (var label in labels)
            {
                Console.WriteLine($"{label.Description} ({(int)(label.Score * 100)}%)");
            }*/

            foreach (var label in labels)
            {
                Console.WriteLine(label);
            }
            //Console.Write(labels);
        }
    }
}