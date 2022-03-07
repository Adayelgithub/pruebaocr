using System;
using Tesseract;
using IronOcr;
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
             
                using (var engine = new TesseractEngine(@"C:\Users\Aday\source\repos\pruebaocr4\pruebaocr4\tessdata\", "spa", EngineMode.Default))
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
             
            IronOcr.Installation.LicenseKey = "IRONOCR.LOHITA3084.23287-FF189B9E05-D5VA3N-Z6FDJ36O6KTD-VUYEWIX75ZNN-4BVDEWX64GAB-KFFEAUS4LEPG-YNHPIIMNRAYY-7F2QOL-TSMRMGUIKJ2EUA-DEPLOYMENT.TRIAL-V3UGEI.TRIAL.EXPIRES.20.MAR.2022";
            
 
            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.Spanish;
            
            using (var Input = new OcrInput(@"C:\Users\Aday\source\repos\pruebaocr4\pruebaocr4\img\dni2.png"))
            {
                Input.Binarize();
                //Input.DeNoise(); // fixes digital noise and poor scanning
                Input.Deskew();  // fixes rotation and perspective
               

                var Result = Ocr.Read(Input);
                Console.WriteLine(Result.Text);
           
                Console.WriteLine(Result.Words[0]);
                //Result.SaveAsSearchablePdf("searchable.pdf");

                var apellido1 = Result.Words[0];
                var apellido2 = Result.Words[1];
                var nombre = Result.Words[3];

                var género = Result.Words[6];

                var nacionalidad = Result.Words[7];
                var fechanacimiento1 = Result.Words[11];
                var fechanacimiento2 = Result.Words[12];
                var fechanacimiento3 = Result.Words[13];
                var fechanacimiento = fechanacimiento1.ToString() + " " + fechanacimiento2.ToString() + " " + fechanacimiento3.ToString();

                var fechacaducidad1 = Result.Words[19];
                var fechacaducidad2 = Result.Words[20];
                var fechacaducidad3 = Result.Words[21];
                var fechacaducidad = fechacaducidad1.ToString() + " " + fechacaducidad2.ToString() + " " + fechacaducidad3.ToString();

                var dni1 = Result.Words[25];
                var dni2 = Result.Words[26];
                var dni = dni1.ToString() + dni2.ToString();

                Console.WriteLine("apellido 1: " + apellido1);
                Console.WriteLine("apellido 2: " + apellido2);

                Console.WriteLine("nombre :" + nombre);
                Console.WriteLine("género :" + género);

                Console.WriteLine("nacionalidad :" + nacionalidad);

                Console.WriteLine("fecha de nacimiento: " + fechanacimiento);
                Console.WriteLine("fecha de caducidad: " + fechacaducidad);
                Console.WriteLine("DNI: "  + dni);

            }

            var Ocr2 = new IronTesseract();
            Ocr2.Language = OcrLanguage.Spanish;

            using (var Input = new OcrInput())
            {
                var ContentArea = new System.Drawing.Rectangle() { X = 215, Y = 200, Height = 200, Width = 300 };
                Input.AddImage(@"C:\Users\Aday\source\repos\pruebaocr4\pruebaocr4\img\dni2.png", ContentArea);
                var Result = Ocr2.Read(Input);
                Console.WriteLine(Result.Text);


            }


        }

    

    }
}
