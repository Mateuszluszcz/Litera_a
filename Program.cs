using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

class Litera
{

    static void Main()
    {
        //string path = @"c:\test\mateusz_luszczynski.txt";

        //if (!File.Exists(path))
        //{
        //    string readText = File.ReadAllText(path);
        //    Console.WriteLine(readText);
        //}
        string fullPath = @"c:\test\test_mateusz_luszczynski.txt";


        string fileName = Path.GetFileNameWithoutExtension(fullPath);



        if (fileName.Length > 15) ;

        else Console.WriteLine("GetFileNameWithoutExtension:('{0}') returns '{1}'", fileName);
        {
            string[] parts = fileName.Split('_');

            if (parts.Length >= 3)
            {

                string imie = parts[1];
                string nazwisko = parts[2];


                string imie3 = imie.Length >= 3 ? imie.Substring(0, 3) : imie;
                string nazwisko3 = nazwisko.Length >= 3 ? nazwisko.Substring(0, 3) : nazwisko;

                Console.WriteLine($"{imie3} {nazwisko3}");
            }
            string filePath = @"c:\test\test_mateusz_luszczynski.txt";

            string content = File.ReadAllText(filePath);

            int count = 0;
            foreach (char a in content)
            {
                if (char.ToLower(a) == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine($"wystapienia a: {count}");

        }
    }
}

        //string fileName = @"c:\test\test_mateusz_luszczynski.txt";
        //string path = @"c:\test\";
        //string result;

        //result = Path.GetFileNameWithoutExtension(fileName);
        //Console.WriteLine("GetFileNameWithoutExtension:('{0}') returns '{1}'", fileName, result);
        //string extracted = fileName.Substring(0, 3);

        //result = Path.GetFileName(path);
        //Console.WriteLine("GetFileName:('{0}') returns '{1}'", path, result);

//        try
//        {
//            using StreamReader reader = new StreamReader(@"c:\test\test_mateusz_luszczynski.txt");

//            string text = reader.ReadToEnd();
//            Console.WriteLine(text);
//        }
        
//        catch (IOException e)
//        {
//            Console.WriteLine("Nie ma");
//            Console.WriteLine(e.Message);
//        }
//    }
//}