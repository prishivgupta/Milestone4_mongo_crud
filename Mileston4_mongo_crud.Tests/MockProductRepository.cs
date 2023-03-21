using crud_mongo.Models;
using Milestone4_mongo_crud.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mileston4_mongo_crud.Tests
{
    public static class MockProductRepository
    {
        public static Mock<IProduct> ProductMock()
        {
            // create dummy data
            var products = new List<ProductModel>
            {
                new ProductModel
                {
                    id = "1",
                    productName = "Laptop",
                    productDescription = "Sample",
                    productPrice = 1000,
                    category = "Category1"
                },
                new ProductModel
                {
                    id = "2",
                    productName = "Printer",
                    productDescription = "Sample",
                    productPrice = 2000,
                    category = "Category2"
                },
                new ProductModel
                {
                    id = "3",
                    productName = "Phone",
                    productDescription = "Sample",
                    productPrice = 3000,
                    category = "Category1"
                }
            };

            // mock the interface
            var mock = new Mock<IProduct>();

            //mock the instance through dummy data

            // mock for get 
            mock.Setup(m => m.GetAllProducts()).Returns(products);

            // mock for create
            mock.Setup(m => m.AddProduct(It.IsAny<ProductModel>())).Returns((ProductModel product) =>
            {
                products.Add(product);
                return product;
            });

            mock.Setup(m => m.Equals(products)).Returns(true);

            return mock;
        }
    }
}
