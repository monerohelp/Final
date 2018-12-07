using System;
using System.Collections.Generic;
using System.Linq;

namespace Final
{
    class StudentRecordDatabase
    {
        private List<StudentInfo> _records;
        private bool validInput;

        public StudentRecordDatabase(List<StudentInfo> records )
        {
            _records = records;
        }
        
        public int StartMainMenu()
        {
            int mainMenuChoice = 0;
            validInput = false;

            while (validInput == false)
            {
                Console.Clear();
                Console.WriteLine("1. Add new record");
                Console.WriteLine("2. Lookup record");
                Console.WriteLine("3. Exit");
                Console.WriteLine("");
                Console.Write("Enter selection: ");
                validInput = int.TryParse(Console.ReadLine(), out mainMenuChoice);
            }

            switch (mainMenuChoice)
            {
                case 1:
                    Console.Clear();
                    AddNewRecord();
                    break;

                case 2:
                    Console.Clear();
                    Lookup();

                    break;

                case 3:
                    break;

            }

            return mainMenuChoice;
        }

        public void AddNewRecord()
        {
            string input;
            StudentInfo student = new StudentInfo();
            Console.Write("Enter student's first name: ");
            input = Console.ReadLine();
            student.StudentName.setFirst(input);
            Console.Write("Enter student's middle name: ");
            input = Console.ReadLine();
            student.StudentName.setMiddle(input);
            Console.Write("Enter student's last name: ");
            input = Console.ReadLine();
            student.StudentName.setLast(input);
            Console.WriteLine("");
            Console.Write("Enter student's street number: ");
            input = Console.ReadLine();
            student.StudentAddress.setStNumber(Convert.ToInt32(input));
            Console.Write("Enter student's street name: ");
            input = Console.ReadLine();
            student.StudentAddress.setName(input);
            Console.Write("Enter student's city: ");
            input = Console.ReadLine();
            student.StudentAddress.setCity(input);
            Console.Write("Enter student's state (two letters): ");
            input = Console.ReadLine();
            if (input.Length == 2)
            {
                student.StudentAddress.setState(input);
            }
            else
            {
                while (input.Length != 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correct format (two letters)");
                    Console.Write("Enter student's state (two letters): ");
                    input = Console.ReadLine();
                }
                student.StudentAddress.setState(input);

            }
            Console.Write("Enter student's zip code: ");
            input = Console.ReadLine();
            student.StudentAddress.setZip(Convert.ToInt32(input));
            Console.WriteLine("");
            Console.Write("Enter student's 7 digit ID: ");
            input = Console.ReadLine();
            if ((input.Length == 7) && (Convert.ToInt32(input) > 1000000))
            {
                student.setID(Convert.ToInt32(input));
            }
            else
            {
                while ((input.Length != 7) || (Convert.ToInt32(input) < 1000000))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correct format (7 digits)");
                    Console.Write("Enter student's 7 digit ID: ");
                    input = Console.ReadLine();
                }
                student.setID(Convert.ToInt32(input));

            }
            Console.Write("Enter student's phone number: ");
            input = Console.ReadLine();
            AddNewPhoneNumber(input, student);
            Console.WriteLine("");
            Console.Write("Would you like to enter course info for this student: Y or N? ");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                    AddNewCourse(student);
            }

            _records.Add(student);
        }

        public void AddNewPhoneNumber(string input, StudentInfo student)
        {
            string[] phoneNumberParts = input.Split('-');
            student.StudentPhone.setAreaCode(Convert.ToInt32(phoneNumberParts[0]));
            student.StudentPhone.setExchange(Convert.ToInt32(phoneNumberParts[1]));
            student.StudentPhone.setExtension(Convert.ToInt32(phoneNumberParts[2]));

            //phoneNumberParts[0]
            //phoneNumberParts[1]
            //phoneNumberParts[2]
        }

        public void AddNewCourse(StudentInfo student)
        {
            string input;
            bool continueEnteringCourses = true;
            var newCourse = new Course();

            Console.Clear();
            Console.Write("Enter name of course: ");
            input = Console.ReadLine();
            newCourse.setCourseName(input);
            Console.Write("Enter course number: ");
            input = Console.ReadLine();
            newCourse.setCourseNumber(Convert.ToInt32(input));
            Console.Write("Enter three character department name: ");
            input = Console.ReadLine();
            if (input.Length == 3)
            {
                newCourse.setDeptName(input);
            }
            else
            {
                while (input.Length != 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correct format (three letters)");
                    Console.Write("Enter three character department name: ");
                    input = Console.ReadLine();
                }
                newCourse.setDeptName(input);

            }
            Console.Write("Enter semester: ");
            input = Console.ReadLine();
            newCourse.setSemester(input);
            Console.Write("Enter year: ");
            input = Console.ReadLine();
            newCourse.setYear(Convert.ToInt32(input));
            Console.Write("Enter number of credit hours: ");
            input = Console.ReadLine();
            newCourse.setCreditHrs(Convert.ToInt32(input));
            Console.Write("Enter grade received: ");
            input = Console.ReadLine();
            newCourse.setGrade(input);
            Console.Clear();
            Console.Write("Continue entering courses: Y or N? ");
            input = Console.ReadLine();

            if (input == "y" || input == "Y")
            {
                while (continueEnteringCourses)
                {
                    student.StudentCourses.Add(newCourse);
                    AddNewCourse(student);
                }
            }

            student.StudentCourses.Add(newCourse);
            ReturnToMenuPause();
        }

        public void Lookup()
        {
            int input = 0;
            validInput = false;

            while (validInput == false)
            {
                Console.WriteLine("1. Lookup student by ID");
                Console.WriteLine("2. Lookup student by name");
                Console.WriteLine("3. Lookup student by phone number");
                Console.WriteLine("");
                Console.Write("Enter your selection: ");
                validInput = int.TryParse(Console.ReadLine(), out input);
            }

            string returnToMainMenu = string.Empty;

            switch (input)
            {
                case 1:
                    Console.Clear();
                    LookupByID();
                    break;

                case 2:
                    Console.Clear();
                    LookupByName();
                    break;

                case 3:
                    Console.Clear();
                    LookupByPhone();
                    break;
            }
        }

        private void LookupByID()
        {
            string answer;
            int id;
            Console.Write("Enter student's ID: ");
            answer = Console.ReadLine();
            id = Convert.ToInt32(answer);
            StudentInfo lookupResult = _records.SingleOrDefault(student => student.studentID == id);
            RunStudentMenu(lookupResult);

        }

        private void LookupByName()
        {
            string name;
            Console.Write("Enter student's name (first middle last): ");
            name = Console.ReadLine();

            StudentInfo lookupResult = _records.SingleOrDefault(student => student.StudentName.ToString() == name);
            RunStudentMenu(lookupResult);

        }

        private void LookupByPhone()
        {
            string phoneNumber;
            Console.Write("Enter student's phone number: ");
            phoneNumber = Console.ReadLine();

            StudentInfo lookupResult = _records.SingleOrDefault(student => student.StudentPhone.ToString() == phoneNumber);
            RunStudentMenu(lookupResult);
           
        }

        private void RunStudentMenu(StudentInfo lookupResult)
        {
            int lookupSubMenuChoice = 0;
            string updatedInfo;

            Console.WriteLine(lookupResult.StudentName.ToString());
            Console.WriteLine("");
            Console.WriteLine("1. Display student info");
            Console.WriteLine("2. Display student course info");
            Console.WriteLine("3. Update student info");
            Console.WriteLine("4. Update student course info");
            //Console.WriteLine("5. Return to main menu");
            Console.WriteLine("");
            Console.Write("Enter your selection: ");
            lookupSubMenuChoice = Convert.ToInt32(Console.ReadLine());

            switch (lookupSubMenuChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(lookupResult.StudentAddress.ToString());
                    Console.WriteLine(lookupResult.StudentPhone);
                    Console.WriteLine(lookupResult.studentID);
                    Console.WriteLine("");
                    ReturnToMenuPause();

                    break;

                case 2:
                    Console.Clear();
                    foreach (var course in lookupResult.StudentCourses)
                    {
                        Console.WriteLine(course.getCourseName());
                        Console.WriteLine(course.getCourseNumber());
                        Console.WriteLine(course.getDeptName());
                        Console.WriteLine(course.getSemester());
                        Console.WriteLine(course.getYear());
                        Console.WriteLine(course.getCreditHrs());
                        Console.WriteLine(course.getGrade());
                        Console.WriteLine("");
                    }
                    ReturnToMenuPause();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("1. Name");
                    Console.WriteLine("2. Address");
                    Console.WriteLine("3. Phone number");
                    Console.WriteLine("4. Student ID");
                    Console.WriteLine("");
                    Console.WriteLine("Enter selection to update ");
                    lookupSubMenuChoice = Convert.ToInt32(Console.ReadLine());

                    switch (lookupSubMenuChoice)
                    {
                        case 1:
                            Console.Write("Enter new first name (press enter to skip): ");
                            updatedInfo = Console.ReadLine();
                            if (updatedInfo != "")
                            {
                                lookupResult.StudentName.setFirst(updatedInfo);
                            }
                            Console.WriteLine("");
                            Console.Write("Enter new middle name (press enter to skip): ");
                            updatedInfo = Console.ReadLine();
                            if (updatedInfo != "")
                            {
                                lookupResult.StudentName.setMiddle(updatedInfo);
                            }
                            Console.WriteLine("");
                            Console.Write("Enter new last name (press enter to skip): ");
                            updatedInfo = Console.ReadLine();
                            if (updatedInfo != "")
                            {
                                lookupResult.StudentName.setLast(updatedInfo);
                            }
                            break;

                        case 2:
                            

                            break;

                        case 3:
                            Console.Write("Enter new phone number: ");
                            updatedInfo = Console.ReadLine();
                            AddNewPhoneNumber(updatedInfo, lookupResult);
                            break;

                        case 4:
                            break;
                    }
                    break;

                case 4:
                    Console.Clear();
                    break;

                    //case 5:
                    //    Console.Clear();
                    //    break;
            }
        }

        private void ReturnToMenuPause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}