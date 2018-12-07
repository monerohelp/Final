namespace Final
{
    internal class Course
    {
        private string deptName; //three characters
        private string courseName;
        private int courseNumber;
        private string semester;
        private int year;
        private int creditHrs;
        private string grade;

        public string getCourseName()
        {
            return (courseName);
        }

        public void setCourseName(string crsName)
        {
            courseName = crsName;
        }

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

        public string getGrade()
        {
            return (grade);
        }

        public void setGrade(string grd)
        {
            grade = grd;
        }
    }
}