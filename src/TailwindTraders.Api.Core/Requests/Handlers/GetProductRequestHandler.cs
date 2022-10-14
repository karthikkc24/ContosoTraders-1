﻿using MediatR.Pipeline;

namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class GetProductRequestHandler : IRequestPreProcessor<GetProductRequest>, IRequestHandler<GetProductRequest, IActionResult>
{
    private readonly IProductService _productService;

    private readonly IStockService _stockService;

    public GetProductRequestHandler(IProductService productService, IStockService stockService)
    {
        _productService = productService;
        _stockService = stockService;
    }

    public async Task<IActionResult> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _productService.GetProductAsync(request.ProductId, cancellationToken);

        try
        {
            var stock = await _stockService.GetStockAsync(request.ProductId, cancellationToken);
        }
        catch (StockNotFoundException stockNotFoundException)
        {
        }

        return new OkObjectResult(product);
    }

    public async Task Process(GetProductRequest request, CancellationToken cancellationToken)
    {
        var validator = new GetProductRequestValidator();

        await validator.ValidateAndThrowAsync(request, cancellationToken);
    }
}