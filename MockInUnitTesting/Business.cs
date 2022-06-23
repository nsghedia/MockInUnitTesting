using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInUnitTesting
{
    public class Business
    {
        private readonly Repository repository;
        public Business(Repository repository)
        {
            this.repository = repository;
        }
        public int addition(int n1, int n2)
        {
            return repository.addition(n1, n2);
        }
        public int substraction(int n1, int n2)
        {
            return repository.substraction(n1, n2);
        }
        public List<Band> GetBands()
        {
            return repository.GetBands();
        }

        public void MethodToTestBandsList()
        {
            var bands =  repository.GetBands();
            foreach (Band band in bands)
            {
                if (band.Name == "Neha")
                    Console.WriteLine("she is a ranker");
            }
        }
    }
}
