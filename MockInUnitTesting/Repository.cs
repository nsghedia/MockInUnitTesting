namespace MockInUnitTesting
{
    public class Repository
    {
        public int addition(int n1, int n2)
        {
            return n1 + n2;
        }
        public virtual int substraction(int n1, int n2)
        {
            throw new NotImplementedException();
        }
        public virtual int ABC()
        {
            throw new NotImplementedException();
        }
        //from database
        public virtual List<Band> GetBands()
        {
            var ListOfBands = new List<Band>()
            {
                new Band
                {
                    Name = "Neha",
                    Mobile = "9488865833",
                    Email = "nsg@gmail.com",
                    Address="B-104"
                },
                 new Band
                {
                    Name = "Mohit",
                    Mobile = "9488874433",
                    Email = "Mohit@gmail.com",
                    Address="C-107"
                },
                 new Band
                {
                    Name = "Mital",
                    Mobile = "9487468833",
                    Email = "Mital@gmail.com",
                    Address="A-196"
                }
            };
            return ListOfBands;
        }
    }
}