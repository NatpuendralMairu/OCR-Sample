using System;
using Tesseract;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Title = "Trying Tesseract";

                const string tessDataDir = @"C:\Users\prajwal.nimmagadda\Desktop\Automation GitHub\tessdata";
                const string imageDir = @"C:\Users\prajwal.nimmagadda\Desktop\Automation GitHub\Test5.jpg";

                using (var engine = new TesseractEngine(tessDataDir, "eng", EngineMode.Default))
                using (var image = Pix.LoadFromFile(imageDir))
                using (var page = engine.Process(image))
                {
                    string text = page.GetText();
                    Console.WriteLine(text);
                    Console.ReadLine();
                }
        }
    }
}
