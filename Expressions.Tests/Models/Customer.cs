using System;

namespace Expressions.Tests.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;
            if (other == null) return false;
            return Name.Equals(other.Name) && ((Address == null && other.Address == null) || (Address?.Equals(other.Address) ?? false));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Address.GetHashCode();
                return hash;
            }
        }
    }
}
