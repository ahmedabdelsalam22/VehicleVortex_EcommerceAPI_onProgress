﻿namespace VehicleVortex.Models.ShoppingCart
{
    public class CartDto
    {
        public CartHeaderDto? CartHeaderDto { get; set; }
        public IEnumerable<CartDetailsDto>? CartDetailsDtos { get; set; }
    }
}
