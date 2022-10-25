using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Vision.V1;

using System;

namespace CapstoneBackEndAPI.ViewModels
{
    public class GoogleVisionViewModel
    {
        public string path { get; set; }

        public void CallGoogleVision()
        {
            
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "./bin/key.json");
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromFile(path);
            var labels = client.DetectLabels(image);
            foreach (var label in labels)
            {
                System.Diagnostics.Debug.WriteLine(label);
            }
            

            
                        
        }
    }
}
