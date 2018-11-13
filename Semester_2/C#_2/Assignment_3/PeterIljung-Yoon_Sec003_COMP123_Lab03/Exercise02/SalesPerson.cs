using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    abstract class SalesPerson
    {
        private string firstName;
        private string lastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return firstName + " " + lastName;
        } 
        public SalesPerson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }//End constructors
    }
    interface ISellable
    {
        void SalesSpeech();
        void MakeSale(int value);
    }//End interface
}
