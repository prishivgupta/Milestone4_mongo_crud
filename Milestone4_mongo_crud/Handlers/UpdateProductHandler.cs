using crud_mongo.Models;
using MediatR;
using Milestone4_mongo_crud.Commands;
using Milestone4_mongo_crud.Interfaces;

namespace Milestone4_mongo_crud.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, ProductModel>
    {
        private readonly IProduct product;

        public UpdateProductHandler(IProduct product)
        {
            this.product = product;
        }

        public async Task<ProductModel> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(product.UpdateProduct(request.product));
        }
    }
}
