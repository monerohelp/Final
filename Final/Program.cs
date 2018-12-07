using System.Collections.Generic;

namespace Final
{
    internal class Program
    {

        private static bool goToMainMenu = true;

        public static void Main(string[] args)
        {
            List<StudentInfo> Records = ReadWriteData.LoadExistingData();// Read data from text file


            StudentRecordDatabase database = new StudentRecordDatabase(Records);

            int mainMenuChoice;

            do
            {
                mainMenuChoice = database.StartMainMenu();
            }
            while (mainMenuChoice != 3);

            ReadWriteData.SaveDataToTextFile(Records);

        }
    }
}