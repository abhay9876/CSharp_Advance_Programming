/*Testing File Handling Methods
Problem:
Create a class FileProcessor with the following methods:
● WriteToFile(string filename, string content): Writes content to a file.
● ReadFromFile(string filename): Reads content from a file.
Write unit tests to check if:
The content is written and read correctly.
The file exists after writing.
Handling of IOException when the file does not exist.*/


namespace Core
{
    public class FileProcessor
    {
        public bool WriteToFile(string filename, string content)
        {
            Thread.Sleep(3000);
            return true;
        }
    }
}