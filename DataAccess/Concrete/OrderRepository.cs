using DataAccess.Abstract;
using Entities;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _pieContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext _pieContext, ShoppingCart _shoppingCart)
        {
            this._pieContext = _pieContext;
            this._shoppingCart = _shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _pieContext.Orders.Add(order);
            _pieContext.SaveChanges();
        }
    }
}