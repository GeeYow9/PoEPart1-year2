using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PoEPart1
{
    public class logo
    {  

        public logo() 
        {
            //get the ful path
            string image_project = AppDomain.CurrentDomain.BaseDirectory;

            //replace the bin\\Debug
            string new_image_project = image_project.Replace("bin\\Debug\\", "");

            //combine full path with thelogo image
            //format
            string full_image = Path.Combine(new_image_project,"OIP (4).jpg");  
            
            //start working on the logo
            //with the Ascii
            Bitmap picture = new Bitmap(full_image);
            picture = new Bitmap(picture, new Size(210, 200));



            //for loop, for inner and outer
            //nested
            for (int length = 0; length < picture.Height; length++)
            {
                //work on width
                for (int breadth = 0; breadth < picture.Width; breadth++)
                {
                //work on the asci design
                    Color pixelColor = picture.GetPixel(breadth, length);
                    int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;


                    //make use of char
                    char ascii_design = color > 200 ? '!' : color > 150 ? '*' : color > 100 ? '1' : color > 50 ? '$' : '&';
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(ascii_design);//output the design



                }//end of inner loop
                Console.WriteLine();//skip the line
            }//end of loop

        
        
        }

    }
}
