using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private readonly List<Product> productList;

        public ShoppingCart()
        {
            this.productList = new List<Product>();
        }

        public List<Product> ProductList
        {
            get { return this.productList; }
        }

        public void AddProduct(Product product)
        {
            Guard.WhenArgument(productList, "Cart Product Add").IsNull().Throw();
            Guard.WhenArgument(product, "Cart Product Contains").IsNull().Throw();

            this.productList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Guard.WhenArgument(productList, "Cart Product Remove").IsNull().Throw();
            Guard.WhenArgument(product, "Cart Product Contains").IsNull().Throw();

            this.productList.Remove(product);
        }

        public bool ContainsProduct(Product product)
        {
            Guard.WhenArgument(productList, "Cart Product Contains").IsNull().Throw();
            Guard.WhenArgument(product, "Cart Product Contains").IsNull().Throw();

            if (this.productList.Contains(product))
            {
                return true;
            }

            return false;
        }

        public decimal TotalPrice()
        {
            Guard.WhenArgument(productList, "Cart Products Price").IsNull().Throw();

            return this.productList.Sum(x => x.Price);
        }
    }
}
