using Google.Cloud.Vision.V1;
using System;
using System.Collections;
using System.Collections.Generic;

namespace VisionApiDemo
{
    class gVision
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "./key.json");
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromFile("fakereceipt.jpg");
            //var labels = client.DetectLabels(image);
            IReadOnlyList<EntityAnnotation> textAnnotations = client.DetectText(image);
            Console.Write(textAnnotations.ElementAt(0).ToString());
            /*foreach (EntityAnnotation text in textAnnotations)
            {
                Console.WriteLine($"Description: {text.Description}");
            }*/

            //Console.WriteLine("Labels (and confidence score):");
            //Console.WriteLine(new String('=', 30));

            /*foreach (var label in labels)
            {
                Console.WriteLine($"{label.Description} ({(int)(label.Score * 100)}%)");
            }*/

            /*foreach (var label in labels)
            {
                Console.WriteLine(label);
            }*/
            //Console.Write(labels);
            //var list = labels.ToList();
            //Console.Write(list);
            /*foreach (var l in list)
            {
                Console.WriteLine(l);
            }*/
        }
    }
}