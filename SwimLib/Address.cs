using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class Address
    {
        private string postalCode;
        public Address(string street, string city, string province, string postalCode)
        {
            Street = street;
            City = city;
            Province = province;
            PostalCode = postalCode;
        }     

        public Address() :this ("", "", "", "") { }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                if (!Regex.IsMatch(value, "[a-zA-Z][0-9][a-zA-Z][- ]?[0-9][a-zA-Z][0-9]") && value != "")
                {
                    throw new FormatException("Invalid postal code format.");
                }
                postalCode = value;
            }
        }
        public override string ToString()
        {
            return $"         {Street}\n" +
                   $"         {City}\n" +
                   $"         {Province}\n" +
                   $"         {PostalCode}";
        }
    }
}
