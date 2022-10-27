using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Vision.V1;

using System;

namespace CapstoneBackEndAPI.ViewModels
{
    public class GoogleVisionViewModel
    {
        public string path { get; set; }
        public string type { get; set; }  

        public List<EntityAnnotation> CallGoogleVisionAPI()
        {
            
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "./bin/key.json");
            if (String.Equals(type,"tags")) {
                return CallGoogleVisionTags();
            }
            else
            {
                return CallGoogleVisionOCR();
            }
                        
        }
        public List<EntityAnnotation> CallGoogleVisionTags()
        {
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromFile(path);
            var labels = client.DetectLabels(image).ToList();
            foreach (var label in labels)
            {
                System.Diagnostics.Debug.WriteLine(label);
            }


            return labels;
        }

        public List<EntityAnnotation> CallGoogleVisionOCR()
        {
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromFile(path);
            var labels = client.DetectLabels(image).ToList();
            foreach (var label in labels)
            {
                System.Diagnostics.Debug.WriteLine(label);
            }


            return labels;
        }
    }
}
