using System;

namespace MyDictionaryDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            MyDictionary<int> points = new MyDictionary<int>();
            names.Add("Tuğba");
            names.Add("Elif");
            names.Add("Ada");
            names.Add("Ebru");
            names.Add("Gamze");
            names.Add("Sema");
            names.Add("Ayşe");
            points.Add(80);
            points.Add(68);
            points.Add(45);
            points.Add(95);
            points.Add(75);
            points.Add(100);
            points.Add(55);


            

            
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.WriteLine(names.Items[0] + ":" + points.Items[0] + " puan aldınız.");
                    }
                    else if (i == 1 && j == 1)
                    {
                        Console.WriteLine(names.Items[1] + ":" + points.Items[1] + " puan aldınız.");
                    }
                    else if (i == 2 && j == 2)
                    {
                        Console.WriteLine(names.Items[2] + ":" + points.Items[2] + " puan aldınız.");
                    }
                    else if (i == 3 && j == 3)
                    {
                        Console.WriteLine(names.Items[3] + ":" + points.Items[3] + " puan aldınız.");
                    }
                    else if (i == 4 && j == 4)
                    {
                        Console.WriteLine(names.Items[4] + ":" + points.Items[4] + " puan aldınız.");
                    }
                    else if (i == 5 && j == 5)
                    {
                        Console.WriteLine(names.Items[5] + ":" + points.Items[5] + " puan aldınız.");
                    }
                    else if(i==6 && j==6)
                    {
                        Console.WriteLine(names.Items[6] + ":" + points.Items[6] + " puan aldınız.");
                    }

                }
            }
                
                    
                    
                       
                    
         
            
        }
    }
}
