using System;
using System.IO;

class test
{
    static void Main(string[] args){
        Console.WriteLine("Test \n");
        Console.Read();
        string line = "";
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        int id = 0;
        // Append text to an existing file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
        {
            for(int y = 0; y < 26; y++){
                for(int i = 0; i < 24; i++){
                    line += "candyInstance["+ id +"]; ";
                    id++;
                }
                 outputFile.WriteLine(line);
                 line = "";
            }
            
        }
    }
}