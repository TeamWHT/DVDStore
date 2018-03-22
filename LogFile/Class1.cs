using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace LogFile
{

     public class Class1
    {
        
        static FileStream RecordingEvents = new FileStream("Log.txt", FileMode.OpenOrCreate);
         StreamWriter sr = new StreamWriter(RecordingEvents);
       
       


    }
}
