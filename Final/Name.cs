namespace Final
{
    internal class Name
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
}