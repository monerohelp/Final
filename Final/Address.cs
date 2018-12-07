namespace Final
{
    internal class Address
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
}