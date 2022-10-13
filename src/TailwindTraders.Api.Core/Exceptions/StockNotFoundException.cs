﻿namespace TailwindTraders.Api.Core.Exceptions;

public class StockNotFoundException : TailwindTradersBaseException
{
    public StockNotFoundException(int productId)
        : base($"Stock not found for product id '{productId}'")
    {
    }

    public override IActionResult ToActionResult()
    {
        return new NotFoundObjectResult(Message);
    }
}