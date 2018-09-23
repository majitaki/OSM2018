using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OSM2018.Utility
{
    class OutputLog
    {
        static public string BaseLogFolderName = "OutputLog";

        static public void OutputLogCSV(DataTable dt, string filepath)
        {
            string sp = string.Empty;

            using (StreamWriter sw = new StreamWriter(filepath, false, Encoding.UTF8))
            {

                foreach (DataColumn col in dt.Columns)
                {
                    sw.Write(sp + col.ToString());
                    sp = ",";
                }
                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    sp = string.Empty;
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sw.Write(sp + row[i].ToString());
                        sp = ",";

                    }
                    sw.WriteLine();
                }
            }
        }

        static public string SafeCreateCSV(DirectoryInfo di, string tagName)
        {
            var max = di.GetFiles(tagName + "???.csv")                         // パターンに一致するファイルを取得する
                .Select(fi => Regex.Match(fi.Name, @"(?i)_(\d{3})\.csv$"))      // ファイルの中で数値のものを探す
                .Where(m => m.Success)                                          // 該当するファイルだけに絞り込む
                .Select(m => Int32.Parse(m.Groups[1].Value))                    // 数値を取得する
                .DefaultIfEmpty(0)                                              // １つも該当しなかった場合は 0 とする
                .Max();                                                         // 最大値を取得する
            var filepath = String.Format(di + "\\{0}_{1:d3}.csv", tagName, max + 1);
            return filepath;
        }

        static public string SafeCreateTXT(DirectoryInfo di, string tagName)
        {
            var max = di.GetFiles(tagName + "???.txt")                         // パターンに一致するファイルを取得する
                .Select(fi => Regex.Match(fi.Name, @"(?i)_(\d{3})\.txt$"))      // ファイルの中で数値のものを探す
                .Where(m => m.Success)                                          // 該当するファイルだけに絞り込む
                .Select(m => Int32.Parse(m.Groups[1].Value))                    // 数値を取得する
                .DefaultIfEmpty(0)                                              // １つも該当しなかった場合は 0 とする
                .Max();                                                         // 最大値を取得する
            var filepath = String.Format(di + "\\{0}_{1:d3}.txt", tagName, max + 1);
            return filepath;
        }

        static public void SafeCreateDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                return;
            }
            Directory.CreateDirectory(path);
        }
    }
}
