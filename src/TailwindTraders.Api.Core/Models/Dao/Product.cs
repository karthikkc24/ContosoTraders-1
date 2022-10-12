﻿namespace TailwindTraders.Api.Core.Models.Dao;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal? Price { get; set; }
    public string ImageName { get; set; }
    public int? BrandId { get; set; }
    public int? TypeId { get; set; }
    public int? TagId { get; set; }

    #region Hand-Modified Properties

    public Brand Brand { get; set; }

    public Type Type { get; set; }

    #endregion
}