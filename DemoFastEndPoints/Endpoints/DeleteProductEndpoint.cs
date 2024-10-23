using FastEndpoints;

namespace DemoFastEndPoints.Endpoints
{
    public class DeleteProductEndpoint : EndpointWithoutRequest<string>
    {
        public override void Configure()
        {
            Verbs(Http.DELETE);
            Routes("/products/{id}");
            AllowAnonymous();
        }
        /// <summary>
        /// Deletes a product by its unique ID.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        /// <returns>A success message if the product is deleted.</returns>
        public override async Task HandleAsync(CancellationToken ct)
        {
            var productId = Route<Guid>("id");

            // Mock delete logic (replace with actual database delete logic)
            bool productDeleted = true; // Simulate product deletion

            if (productDeleted)
            {
                await SendAsync($"Product with ID {productId} was deleted.");
            }
            else
            {
                await SendNotFoundAsync();  // If product not found, return 404
            }
        }
    }
}
