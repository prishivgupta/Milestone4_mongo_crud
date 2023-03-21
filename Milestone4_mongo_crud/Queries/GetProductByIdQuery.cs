using Amazon.Runtime.Internal;
using crud_mongo.Models;
using MediatR;

namespace Milestone4_mongo_crud.Queries
{
    public record GetProductByIdQuery(string id): IRequest<ProductModel>
    {
    }
}
