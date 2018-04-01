using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Decod
    {
        public void Decoding(string codePath, string filePath)
        {
            StreamReader codeFile = new StreamReader(codePath);
            string stringCode = codeFile.ReadToEnd();

            string stringInterimCode = "";

            #region Промежуточная строка кода
            string[] midCode = stringCode.Split('-');

            string tmp;
            int ID;
            for (int j = 1; j < midCode.Length; j++)
            {
                if ((midCode[j].Length - 1) % 3 == 0)
                {
                    ID = Convert.ToInt32(midCode[j].Substring(0, 1));
                    tmp = midCode[j].Substring(1, midCode[j].Length - 1);
                    for (int i = 1; i <= ID; i++)
                    {
                        stringInterimCode += tmp;
                    }
                }

                if ((midCode[j].Length - 2) % 3 == 0)
                {
                    ID = Convert.ToInt32(midCode[j].Substring(0, 2));
                    tmp = midCode[j].Substring(2, midCode[j].Length - 2);
                    for (int i = 1; i <= ID; i++)
                    {
                        stringInterimCode += tmp;
                    }
                }
            }
            #endregion

            #region Создание массива байтов из промежуточной строки кода
            byte[] resultArrayBytes = new byte[(stringInterimCode.Length) / 3];
            int t = 0;
            for (int i = 0; i < stringInterimCode.Length / 3; i++)
            {
                resultArrayBytes[i] = Convert.ToByte(Convert.ToString(stringInterimCode[t])
                    + Convert.ToString(stringInterimCode[t + 1])
                    + Convert.ToString(stringInterimCode[t + 2]));
                t += 3;
            }
            #endregion

            File.WriteAllBytes(filePath, resultArrayBytes); //Создание файла из массива байтов
        }
    }
}
