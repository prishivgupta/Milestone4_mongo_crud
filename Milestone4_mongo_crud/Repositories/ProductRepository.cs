using crud_mongo.Models;
using Microsoft.Extensions.Options;
using Milestone4_mongo_crud.Interfaces;
using Milestone4_mongo_crud.NewFolder;
using MongoDB.Driver;

namespace Milestone4_mongo_crud.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly IMongoCollection<ProductModel> _productsCollection;

        public ProductRepository(IOptions<StoreSettings> storeSettings)
        {
            MongoClient client = new MongoClient(storeSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(storeSettings.Value.DatabaseName);
            _productsCollection = database.GetCollection<ProductModel>(storeSettings.Value.CollectionName);
        }

        public  ProductModel AddProduct(ProductModel product)
        {
            _productsCollection.InsertOne(product);
            return product;
        }

        public string DeleteProduct(string id)
        {
            _productsCollection.DeleteOne(x => x.id == id);
            return id;
        }

        public List<ProductModel> GetAllProducts()
        {
            return _productsCollection.Find(_ => true).ToList();
        }

        public ProductModel GetProductById(string id)
        {
            return  _productsCollection.Find(x => x.id == id).FirstOrDefault();
        }

        public ProductModel UpdateProduct(ProductModel product)
        {
            _productsCollection.ReplaceOne(x => x.id == product.id, product);
            return product;
        }
    }
}