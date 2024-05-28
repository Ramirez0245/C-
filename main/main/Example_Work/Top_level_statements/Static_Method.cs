// namespace Application
// {
//    using System;

//    class Program
//    {
//       static void Main(string[] args)
//       {
//          Console.WriteLine("Hello World!");
//       }
//       private static string GetText(string path, string filename)
//       {
//          var reader = File.OpenText($"{AppendPathSeparator(path)}{filename}");
//          var text = reader.ReadToEnd();
//          return text;

//          string AppendPathSeparator(string filepath)
//          {
//             return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
//          }
//       }
//    }
// }