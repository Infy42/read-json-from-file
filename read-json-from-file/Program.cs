using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace read_json_from_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "\\employees.json";
            string read = File.ReadAllText(path);
            JsonFile jsonFile = JsonSerializer.Deserialize<JsonFile>(read);

            jsonFile.DisplayInfo();

            Console.ReadKey();
        }
    }
}
