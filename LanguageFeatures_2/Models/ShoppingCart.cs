using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures_2.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public IEnumerable<Product> Products { get; set; }


        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}