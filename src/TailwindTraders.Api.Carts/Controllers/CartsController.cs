﻿namespace TailwindTraders.Api.Carts.Controllers;

[Route("v1/[controller]")]
public class CartsController : TailwindTradersControllerBase
{
    public CartsController(IMediator mediator) : base(mediator)
    {
    }

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCart([FromHeader(Name = "x-tt-email")] string userEmail)
    {
        var request = new GetCartRequest
        {
            Email = userEmail?.ToLowerInvariant()
        };

        return await ProcessHttpRequestAsync(request);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AddItemToCart([FromBody] CartDto cartDto)
    {
        var request = new AddItemToCartRequest
        {
            CartItem = cartDto
        };

        return await ProcessHttpRequestAsync(request);
    }

    [HttpPut("product")]
    [ProducesResponseType(StatusCodes.Status201Created)] // 201 to preserve compatibility with the original API.
    public async Task<IActionResult> UpdateCartItemQuantity([FromBody] CartDto cartDto)
    {
        var request = new UpdateCartItemQuantityRequest
        {
            CartItem = cartDto
        };

        return await ProcessHttpRequestAsync(request);
    }

    [HttpDelete("product")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> RemoveItemFromCart([FromBody] CartDto cartDto)
    {
        var request = new RemoveItemFromCartRequest
        {
            CartItem = cartDto
        };

        return await ProcessHttpRequestAsync(request);
    }
}