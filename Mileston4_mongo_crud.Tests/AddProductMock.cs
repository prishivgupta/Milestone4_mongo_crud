using crud_mongo.Models;

namespace Mileston4_mongo_crud.Tests
{
    public class AddProductMock
    {
        private readonly ProductModel _product;

        public AddProductMock()
        {
            _product = new ProductModel();

            _product = new ProductModel
            {
                id = "4",
                productName = "Phone",
                productDescription = "Sample",
                productPrice = 1000,
                category = "Category3"
            };

        }

        [Fact]

        public void CheckRecord()
        {
            //arrange
            var mock = MockProductRepository.ProductMock();

            //act

            var addedProduct = mock.Object.AddProduct(_product);

            //assert
            Assert.NotNull(addedProduct);
        }
    }
}