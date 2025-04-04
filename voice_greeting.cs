using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PoEPart1
{
    public class voice_greeting
    {
        public voice_greeting()
        {
            string voice_location = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine(voice_location);

            string new_path = voice_location.Replace("bin\\Debug\\", "");


            string full_path = Path.Combine(new_path, "Voice_Greeting.wav");
            play_wav(full_path);
        }
        //method to play aduio
        private void play_wav(string full_path)
        {
            try
            { 
                using (SoundPlayer player = new SoundPlayer(full_path))
                {
                    player.PlaySync();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
            



        }
    }

