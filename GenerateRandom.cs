using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class GenerateRandom
    {
        private Int32 number;

        public Int32 Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }
        
        public GenerateRandom()
        {
            number = 0;
        }

        public Int32 Generate(Int32 range1, Int32 range2)
        {
            Random gen = new Random();

            return gen.Next(range1, range2);
        }

        public Int32[] GenerateArrayUnique(Int16 size, Int16 range1, Int16 range2)
        {
            Int32[] arr_Num = new Int32[size];

            for (int i = 0; i < arr_Num.Length; i++)
            {
                arr_Num[i] = Generate(range1, range2);
                for (int j = 0; j < i; j++)
                {
                    if (arr_Num[j] == arr_Num[i])
                    {
                        i--;
                    }
                }
            }
            return arr_Num;
        }

        public void SaveTofile(string type, Int32[] array)
        {
            // opening/creating file to write

            string dir = @".\files\";
            string path = dir + "Lotto.txt";
            DateTime date_now = DateTime.Now;

            if (!Directory.Exists(path))
            { Directory.CreateDirectory(dir); }

            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter new_line = new StreamWriter(file);
            
            new_line.Write(type + "; ");
            new_line.Write(date_now + "; ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                { new_line.WriteLine(" Bonus " + array[i]); }
                else if (i == array.Length - 2)
                { new_line.Write(array[i]); }
                else
                { new_line.Write(array[i] + ","); }
            }

            new_line.Close();
            file.Close();
        }
    }
}
