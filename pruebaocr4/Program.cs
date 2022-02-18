using System;
using Tesseract;

namespace pruebaocr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //location to testdata for eng.traineddata
            var path = @"C:\Users\Aday\source\repos\pruebaocr3\pruebaocr3\tessdata\";
            //your sample image location
            var sourceFilePath = @"C:\Users\Aday\source\repos\pruebaocr3\pruebaocr3\img\dni1.jpg";
            using (var engine = new TesseractEngine(path, "spa"))
            {
                engine.SetVariable("user_defined_dpi", "70"); //set dpi for supressing warning
                using (var img = Pix.LoadFromFile(sourceFilePath))
                {
                    using (var page = engine.Process(img))
                    {
                        var text = page.GetText();
                        Console.WriteLine();
                        Console.WriteLine("---Image Text---");
                        Console.WriteLine();
                        Console.WriteLine(text);
                    }
                }
            }
            */
             
                using (var engine = new TesseractEngine(@"C:\Users\Aday\source\repos\pruebaocr3\pruebaocr3\tessdata\", "spa", EngineMode.Default))
                {
                    var image = @"C:\Users\Aday\source\repos\pruebaocr4\pruebaocr4\img\dni2.png";
                    {
                        using (var pix = Pix.LoadFromFile(image))
                        {
                            using (var page = engine.Process(pix))
                            {
                            Console.WriteLine(page.GetText());
                            }
                        }
                    }
                }   
        }

    

    }
}
