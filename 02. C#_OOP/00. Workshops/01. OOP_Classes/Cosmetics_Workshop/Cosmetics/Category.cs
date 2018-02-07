using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics
{
    public class Category
    {
        private readonly string name;
        private readonly List<Product> products;

        public Category(string name)
        {
            Guard.WhenArgument(name.Length, "Invalid Category Name Length").IsLessThan(2).IsGreaterThan(15).Throw();
            this.name = name;
            this.products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public virtual void AddProduct(Product product)
        {
            Guard.WhenArgument(product, "Product List").IsNull().Throw();
            this.products.Add(product);
        }

        public virtual void RemoveProduct(Product product)
        {
            Guard.WhenArgument(products, "Products List").IsNull().Throw();
            if (!this.products.Contains(product))
            {
                throw new ArgumentNullException();
            }
            this.products.Remove(product);
        }

        public string Print()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine($"#Category: {this.name}");

            if (this.products.Count == 0)
            {
                strBuilder.Append(" #No product in this category");

                return strBuilder.ToString();
            }

            foreach (var product in this.products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price))
            {
                strBuilder.Append(product.Print());
            }

            return strBuilder.ToString();
        }
    }
}
