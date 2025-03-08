using Ordering.Application.Orders.Queries.GetOrdersByCustomer;

namespace Ordering.API.Endpoints
{
    public record GetOrdersCustomerResponse(IEnumerable<OrderDto> Orders);

    //public record GetOrdersCustomerRequest(guid CustomerId);
    public class GetOrdersByCustomer : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/orders/customer/{customerId}", async (Guid customerId, ISender sender) =>
            {
                var result = await sender.Send(new GetOrdersByCustomerQuery(customerId));
                var response = result.Adapt<GetOrdersCustomerResponse>();
                return Results.Ok(response);
            }).WithName("GetOrderByCustomer")
            .Produces<GetOrdersCustomerResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("GetOrderByCustomer")
            .WithDescription("GetOrderByCustomer");
        }
    }
}
