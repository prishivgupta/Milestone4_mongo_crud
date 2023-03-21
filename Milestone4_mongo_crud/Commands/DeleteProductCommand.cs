using MediatR;

namespace Milestone4_mongo_crud.Commands
{
    public record DeleteProductCommand(string id): IRequest<string>
    {
    }
}
