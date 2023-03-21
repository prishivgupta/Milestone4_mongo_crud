using MediatR;
using Milestone4_mongo_crud.Commands;
using Milestone4_mongo_crud.Interfaces;

namespace Milestone4_mongo_crud.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, string>
    {
        private readonly IProduct product;

        public DeleteProductHandler(IProduct product)
        {
            this.product = product;
        }

        public async Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(product.DeleteProduct(request.id));
        }
    }
}
