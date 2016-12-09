using System;
using System.IO;
using System.Text;

namespace _03_ReadFileContents
{
    class ReadFileCOntents
    {
        static void Main()
        {
            string fileName = Console.ReadLine();
            string path = Console.ReadLine();

            PrintContents(fileName, path);
        }

        private static void PrintContents(string fileName, string path)
        {
            string readText = string.Empty;
            int invalidChar = path.IndexOfAny(new char[] { ';', '@', '[', ']', '%', '{', '}', '*','"' });

            try
            {
                if (invalidChar >= 0)
                {
                    throw new ArgumentException();
                }
                if (path == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                
                string pathToFile = path.Contains(fileName) ? path : path + "\\" + fileName;

                readText = File.ReadAllText(pathToFile, Encoding.UTF8);

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You did not enter a path for the file.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("File path contains the invalid character: {0}", path[invalidChar]);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("File path is too long. Try to shorten it below 248 characters. You could give your file a shorter name or move your file to a folder closer to the root directory.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist at the specified location or the file name you entered is not correct.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (IOException)
            {
                Console.WriteLine("There was a problem opening the file. The file may be corrupt or you are not entering the file extension.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access to the file is denied. You might not have rights to view this file.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Entered path is in an invalid format.");
            }
            catch (Exception)
            {
                Console.WriteLine("Enter file name and path again");
                Main();
            }

            Console.WriteLine(readText);
        }
    }
}
