using System.Collections.Generic;

namespace Final
{
    internal class StudentInfo
    {
        public Name StudentName { get; set; }
        public Address StudentAddress { get; set; }
        public PhoneNumber StudentPhone { get; set; }
        public List<Course> StudentCourses { get; set; }
        public int studentID;
        private double GPA;
        private int creditHoursAttempted;
        private int creditHoursComplete; //only grades C- and higher count

        public StudentInfo()
        {
            StudentName = new Name();
            StudentAddress = new Address();
            StudentPhone = new PhoneNumber();
            StudentCourses = new List<Course>();
        }

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
}