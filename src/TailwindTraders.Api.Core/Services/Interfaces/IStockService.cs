﻿namespace TailwindTraders.Api.Core.Services.Interfaces;

internal interface IStockService
{
    /// <summary>
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="StockNotFoundException"></exception>
    Task<StockDto> GetStockAsync(int productId, CancellationToken cancellationToken = default);
}