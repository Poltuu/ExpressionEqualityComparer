using System.Collections.Generic;

namespace Expressions.Tests.Models
{
    public class Order
    {
        public int Number { get; set; }
        public Customer Customer { get; set; }

        public IEnumerable<OrderLineItem> LineItems { get; set; }
    }
}
