using System;
using System.Collections.Generic;

namespace Final
{

    class StudentRecordDatabase
    {
        private List<StudentInfo> Records;
        
        private bool validInput;
        
        public void StartMainMenu()
        {
            int input = 0;

            
            while (validInput == false)
            {
            
                Console.WriteLine("1. Add new record");
                Console.WriteLine("2. Update existing record");
                Console.WriteLine("3. Lookup record");
                Console.WriteLine("4. Exit");
                Console.WriteLine("");
                Console.Write("Enter selection: ");
                validInput = int.TryParse(Console.ReadLine(), out input);
            }

            switch (input)
            {
                    case 1:
                        break;
                    
                    case 2:
                        break;
                    
                    case 3:
                        break;
                    
                    case 4:
                        break;
                             
            }
            
            
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
            Console.Write("Enter student's state: ");
            input = Console.ReadLine();
            student.StudentAddress.setState(input);
            Console.Write("Enter student's zip code: ");
            input = Console.ReadLine();
            student.StudentAddress.setZip(Convert.ToInt32(input));
            Console.WriteLine("");
            


        }
    }
    
    class Name
    {
        public override string ToString()
        {
            return first + " " + middle + " " + last;
        }

        private string first;
        private string middle;
        private string last;

        public string getFirst()
        {
            return (first);
        }

        public void setFirst(string firstName)
        {
            first = firstName;
        }

        public string getMiddle()
        {
            return (middle);
        }

        public void setMiddle(string middleName)
        {
            middle = middleName;
        }

        public string getLast()
        {
            return (last);
        }

        public void setLast(string lastName)
        {
            last = lastName;
        }

       
    }

    class Address
    {
        private int streetNumber;
        private string streetName;
        private string city;
        private string state; //two characters
        private int zip;

        
        
        public override string ToString()
        {
            return streetNumber + " " + streetName + " " + "\n" + city + ", " + state + " " + zip;
        }
        
        
        public int getStNumber()
        {
            return (streetNumber);
        }

        public void setStNumber(int stNumber)
        {
            streetNumber = stNumber;
        }

        public string getName()
        {
            return (streetName);
        }

        public void setName(string name)
        {
            streetName = name;
        }

        public string getCity()
        {
            return (city);
        }

        public void setCity(string cityName)
        {
            city = cityName;
        }

        public string getState()
        {
            return (state);
        }

        public void setState(string stateName)
        {
            state = stateName;
        }

        public int getZip()
        {
            return (zip);
        }

        public void setZip(int zipCode)
        {
            zip = zipCode;
        }
        
    }

    class PhoneNumber
    {
        public override string ToString()
        {
            return areaCode + "-" + exchange + "-" + extension;
        }

        private int areaCode;
        private int exchange;
        private int extension;

        public int getAreaCode()
        {
            return (areaCode);
        }

        public void setAreaCode(int area)
        {
            areaCode = area;
        }

        public int getExchange()
        {
            return (exchange);
        }

        public void setExchange(int exchangeNumber)
        {
            exchange = exchangeNumber;
        }

        public int getExtension()
        {
            return (extension);
        }

        public void setExtension(int extensionNumber)
        {
            extension = extensionNumber;
        }
    }

    class Course
    {
        private string deptName; //three characters
        private int courseNumber;
        private string semester;
        private int year;
        private int creditHrs;
        private string grade;

        public string getDeptName()
        {
            return (deptName);
        }

        public void setDeptName(string name)
        {
            deptName = name;


        }

        public int getCourseNumber()
        {
            return (courseNumber);
        }

        public void setCourseNumber(int crsNum)
        {
            courseNumber = crsNum;
        }

        public string getSemester()
        {
            return (semester);
        }

        public void setSemester(string semstr)
        {
            semester = semstr;
        }

        public int getYear()
        {
            return (year);
        }

        public void setYear(int yr)
        {
            year = yr;
        }

        public int getCreditHrs()
        {
            return (creditHrs);
        }

        public void setCreditHrs(int credits)
        {
            creditHrs = credits;
        }

        public char getGrade()
        {
            return (grade);
        }

        public void setGrade(string grd)
        {
            grade = grd;
        }

    }

    

    class StudentInfo
    {
        
        public Name StudentName { get; set; }
        public Address StudentAddress { get; set; }
        public PhoneNumber StudentPhone { get; set; }
        public List<Course> StudentCourses { get; set; }
        private int studentID;
        private double GPA;
        private int creditHoursAttempted;
        private int creditHoursComplete; //only grades C- and higher count

        public int getID()
        {
            return (studentID);
        }

        public void setID(int id)
        {
            studentID = id;
        }
        
        public double getGPA()
        {
            return (GPA);
        }

        public void setGPA(int gpa)
        {
            GPA = gpa;
        }

        public int getHoursAttempted()
        {
            return (creditHoursAttempted);
        }

        public void setHoursAttempted(int hoursAttempted)
        {
            creditHoursAttempted = hoursAttempted;
        }

        public int getHoursComplete()
        {
            return (creditHoursComplete);
        }

        public void setHoursComplete(int hoursComplete)
        {
            creditHoursComplete = hoursComplete;
            //only count grades C- and higher
        }
        

    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            StudentRecordDatabase database = new StudentRecordDatabase();
            database.StartMainMenu();
            
        }
    }
}