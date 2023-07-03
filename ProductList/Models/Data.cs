namespace ProductList.Models
{
    public class Data
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {

                new Product { 
                    Id = 1,
                    Name = "Product 1",
                    Price = (decimal)499.00
                },
                new Product {
                    Id = 2,
                    Name = "Product 2",
                    Price = (decimal)129.00
                },
                new Product {
                    Id = 3,
                    Name = "Product 3",
                    Price = (decimal)19.00
                },
                new Product {
                    Id = 4,
                    Name = "Product 4",
                    Price = (decimal)25.00
                },
                new Product {
                    Id = 5,
                    Name = "Product 5",
                    Price = (decimal)49.00
                },
                new Product {
                    Id = 6,
                    Name = "Product 6",
                    Price = (decimal)399.00
                },
                new Product {
                    Id = 7,
                    Name = "Product 7",
                    Price = (decimal)79.00
                },
                new Product {
                    Id = 8,
                    Name = "Product 8",
                    Price = (decimal)29.00
                },
                new Product {
                    Id = 9,
                    Name = "Product 9",
                    Price = (decimal)179.00
                },
                new Product {
                    Id = 10,
                    Name = "Product 10",
                    Price = (decimal)9.99
                },
                new Product {
                    Id = 11,
                    Name = "Product 11",
                    Price = (decimal)17.00
                },
                new Product {
                    Id = 12,
                    Name = "Product 12",
                    Price = (decimal)12.49
                },
                new Product {
                    Id = 13,
                    Name = "Product 13",
                    Price = (decimal)499.00
                },
                new Product {
                    Id = 14,
                    Name = "Product 14",
                    Price = (decimal)11.00
                },
                new Product {
                    Id = 15,
                    Name = "Product 15",
                    Price = (decimal)44.50
                },
                new Product {
                    Id = 16,
                    Name = "Product 16",
                    Price = (decimal)5.00
                },
                new Product {
                    Id = 17,
                    Name = "Product 17",
                    Price = (decimal)65.00
                },
                new Product {
                    Id = 18,
                    Name = "Product 18",
                    Price = (decimal)119.00
                },
                new Product {
                    Id = 19,
                    Name = "Product 19",
                    Price = (decimal)189.00
                },
                new Product {
                    Id = 20,
                    Name = "Product 20",
                    Price = (decimal)250.00
                },

            };

            return products;
        }
    }
}
