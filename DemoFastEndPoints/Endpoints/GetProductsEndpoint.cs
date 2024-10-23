using DemoFastEndPoints.Modals;
using FastEndpoints;
namespace DemoFastEndPoints.Endpoints
{
    public class GetProductsEndpoint : EndpointWithoutRequest<List<Product>>
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/products");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Laptop", Price = 1200.99M },
            new Product { Id = Guid.NewGuid(), Name = "Smartphone", Price = 699.99M }
        };

            await SendAsync(products);
        }
    }
}
