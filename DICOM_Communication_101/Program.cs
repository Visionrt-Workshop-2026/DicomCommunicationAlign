using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOM_Communication_101
{
    class Program
    {
        static void Main(string[] args)
        {
            string patID = "ALIGNRT_1"; 
            CEchoTutorial.Run();
            CFindTutorial.Run(patID);
            CMoveTutorial.Run(patID);
        }
    }
}
