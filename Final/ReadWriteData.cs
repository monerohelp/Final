using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final
{
    internal static class ReadWriteData
    {
        private readonly static string _filePath = "C:\\Students.txt";

        // read data
        internal static List<StudentInfo> LoadExistingData()
        {
            var students = new List<StudentInfo>();

            try
            {
                string[] allLines = File.ReadAllLines(_filePath);

                foreach (var line in allLines)
                {
                    students.Add(ConvertTextToStudenInfoObject(line));
                }
            }
            catch
            {
                return students;
            }

            // read file (checking if file exists)
            // stream stuff
            // string[]
            // parse all that text

            // for every 'record' convert to a StudenInfo object
            // loop
            // for every thing call -> ConvertTextToStudenInfoObject()

            return students;
        }

        // write/save data
        internal static void SaveDataToTextFile(List<StudentInfo> studentRecords)
        {
            //Convert List to string[]
            string[] allRecordsAsString = new string[studentRecords.Count];

            for (int i = 0; i < allRecordsAsString.Length; i++)
            {
                allRecordsAsString[i] = ConvertStudentInfoObjectToString(studentRecords[i]);
            }

            File.WriteAllLines(_filePath, allRecordsAsString);

            // do stuff
        }

        // covert data to student object
        internal static StudentInfo ConvertTextToStudenInfoObject(string textLines)
        {
            var studentObj = new StudentInfo();

            string[] values = textLines.Split(new[] { "||" }, StringSplitOptions.None);

            studentObj.StudentName.setFirst(values[0]);
            studentObj.StudentName.setMiddle(values[1]);
            studentObj.StudentName.setLast(values[2]);

            return studentObj;
        }

        internal static string ConvertStudentInfoObjectToString(StudentInfo student)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(student.StudentName.getFirst());
            stringBuilder.Append("||");
            stringBuilder.Append(student.StudentName.getMiddle());
            stringBuilder.Append("||");
            stringBuilder.Append(student.StudentName.getLast());
            stringBuilder.Append("||");

            return stringBuilder.ToString();
        }
    }
}
