using crud_mongo.Models;

namespace Milestone4_mongo_crud.Interfaces
{
    public interface IProduct
    {
        public ProductModel AddProduct(ProductModel product);

        public ProductModel UpdateProduct(ProductModel product);

        public List<ProductModel> GetAllProducts();

        public string DeleteProduct(string id);

        public ProductModel GetProductById(string id);
    }
}
