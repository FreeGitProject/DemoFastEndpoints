using DemoFastEndPoints.Modals;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace DemoFastEndPoints.Endpoints
{
    //[HttpGet("/products/{id:guid}"), AllowAnonymous]
    public class GetProductEndpoint : EndpointWithoutRequest<Product>
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/products/{id}");
            AllowAnonymous();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public override async Task HandleAsync(CancellationToken ct)
        {
            var productId = Route<Guid>("id");
            var product = new Product
            {
                Id = productId,
                Name = "Sample Product",
                Description = "Sample Description",
                Price = 100,
                StockQuantity = 10
            };

            await SendAsync(product);
        }
    }
}
