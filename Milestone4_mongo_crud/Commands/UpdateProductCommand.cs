using Amazon.Runtime.Internal;
using crud_mongo.Models;
using MediatR;

namespace Milestone4_mongo_crud.Commands
{
    public record UpdateProductCommand(ProductModel product): IRequest<ProductModel>
    {
    }
}
