﻿using System.IO;

namespace ReflectionTraining
{
    class File
    {
        public string filelocation { get; set; }
        static FileStream filestream;
        static StreamWriter streamwriter;
                
        public File(string filelocation)
        {
            this.filelocation = "C:/dlloutputs/" + filelocation + ".php";
        }

        public void SetFile()
        {
            filestream = new FileStream(filelocation, FileMode.OpenOrCreate, FileAccess.Write);
            streamwriter = new StreamWriter(filestream);
        }

        public static void WritetoLine(string writedata)
        {
            streamwriter.WriteLine(writedata);
        }

        public static void Write(string writedata)
        {
            streamwriter.Write(writedata);
        }

        public void PrintHeader()
        {
            WritetoLine("<?php");
            WritetoLine("");
        }

        public static void CloseConnection()
        {
            WritetoLine("?>");
            streamwriter.Close();
            filestream.Close();
        }
    }
}
