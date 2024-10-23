using DemoFastEndPoints.Modals;
using FastEndpoints;

namespace DemoFastEndPoints.Endpoints
{
    public class UpdateProductEndpoint : Endpoint<UpdateProductRequest, Product>
    {
        public override void Configure()
        {
            Verbs(Http.PUT);
            Routes("/products/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(UpdateProductRequest req, CancellationToken ct)
        {
            var productId = Route<Guid>("id");

            // Mock update logic (replace with actual DB logic)
            var updatedProduct = new Product
            {
                Id = productId,
                Name = req.Name,
                Description = req.Description,
                Price = req.Price,
                StockQuantity = req.StockQuantity
            };

            // Return the updated product as a response (replace with real database update operation)
            await SendAsync(updatedProduct);
        }
    }

    public class UpdateProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
