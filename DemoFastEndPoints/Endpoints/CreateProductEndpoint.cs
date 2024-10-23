using DemoFastEndPoints.Modals;
using FastEndpoints;

namespace DemoFastEndPoints.Endpoints
{
    public class CreateProductEndpoint : Endpoint<CreateProductRequest, Product>
    {
        public override void Configure()
        {
            Verbs(Http.POST);
            Routes("/products");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateProductRequest req, CancellationToken ct)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = req.Name,
                Description = req.Description,
                Price = req.Price,
                StockQuantity = req.StockQuantity
            };

            await SendAsync(product);
        }
    }
}
