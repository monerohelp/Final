namespace Final
{
    internal class PhoneNumber
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
}