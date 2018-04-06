using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Coding
    {
        public Coding(string filePath, string fileName, int userId)
        {
            DB db = new DB();

            byte[] arrayBytes = File.ReadAllBytes(filePath); //Создание массива байтов из файла
            string[] arrayStringBytes = new string[arrayBytes.Length];

            #region Запись чисел в 3 ячейки
            for (int i = 0; i < arrayBytes.Length; i++)
            {
                if (arrayBytes[i] < 100)
                {
                    if (arrayBytes[i] < 10) arrayStringBytes[i] = "00" + Convert.ToString(arrayBytes[i]);
                    else arrayStringBytes[i] = "0" + Convert.ToString(arrayBytes[i]);
                }
                else arrayStringBytes[i] = Convert.ToString(arrayBytes[i]);
            }
            #endregion

            //StreamWriter sre = new StreamWriter("Promegut.txt");
            //foreach (string tmp in arrayStringBytes)
            //    sre.Write(tmp);
            //sre.Close();

            #region Кодирование файла
            string codeFile = "";
            int j = 0, k = 0;
            for (int i = 0; i < arrayStringBytes.Length; i++)
            {
                if (i == arrayStringBytes.Length - 1)
                {
                    if (k <= 0)
                    {
                        if (k == 0)
                        {
                            codeFile += ("-1");
                            codeFile += (arrayStringBytes[i] + "\n");
                            k--;
                        }
                        else codeFile += (arrayStringBytes[i]);
                    }
                    else
                    {
                        codeFile += (-(j + 1) + arrayStringBytes[i] + "\n");
                        k = 0;
                        j = 0;
                    }
                    break;
                }

                if (arrayStringBytes[i + 1] == arrayStringBytes[i])
                {
                    j++;
                    k = 1;
                }
                else
                {
                    if (k <= 0)
                    {
                        if (k == 0)
                        {
                            codeFile += ("-1");
                            codeFile += (arrayStringBytes[i]);
                            k--;
                        }
                        else codeFile += (arrayStringBytes[i]);
                    }
                    else
                    {
                        codeFile += (-(j + 1) + arrayStringBytes[i]);
                        k = 0;
                        j = 0;
                    }
                }
            }
            //codeFile.Close();
            #endregion

            DbFile s = new DbFile();
            s.CodetFile = "19";
            s.UserId = userId;
            s.FileName = fileName;
            db.DbFile.Add(s);
            db.SaveChanges();
        }
    }
}
