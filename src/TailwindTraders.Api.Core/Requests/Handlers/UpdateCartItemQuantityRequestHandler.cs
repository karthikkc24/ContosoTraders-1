﻿using MediatR.Pipeline;

namespace TailwindTraders.Api.Core.Requests.Handlers;

internal class UpdateCartItemQuantityRequestHandler : IRequestPreProcessor<UpdateCartItemQuantityRequest>, IRequestHandler<UpdateCartItemQuantityRequest, IActionResult>
{
    private readonly ICartService _cartService;

    public UpdateCartItemQuantityRequestHandler(ICartService cartService)
    {
        _cartService = cartService;
    }

    public async Task<IActionResult> Handle(UpdateCartItemQuantityRequest request, CancellationToken cancellationToken)
    {
        await _cartService.UpdateCartItemQuantityAsync(request.CartItem, cancellationToken);

        var responseMessage = $"Product quantity updated, id: {request.CartItem.ProductId}";

        return new OkObjectResult(responseMessage);
    }

    public async Task Process(UpdateCartItemQuantityRequest request, CancellationToken cancellationToken)
    {
        var validator = new UpdateCartItemQuantityRequestValidator();

        await validator.ValidateAndThrowAsync(request, cancellationToken);
    }
}