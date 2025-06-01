using apbd_test.Data;
using apbd_test.DTOs;
using apbd_test.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace apbd_test.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<OrderDto> GetOrderById(int orderId)
    {
        var order = await _context.Orders
            .Select(e => new OrderDto
            {
                Id = e.Id,
                CreatedAt = e.CreatedAt,
                FulfilledAt = e.FulfilledAt,
                Status = e.Status.Name,
                Client = new ClientDto()
                {
                    FirstName = e.Client.FirstName,
                    LastName = e.Client.LastName,
                },
                Products = e.ProductOrders.Select(po => new ProductDto()
                {
                    Name = po.Product.Name,
                    Price = po.Product.Price,
                    Amount = po.Amount
                }).ToList()
            })
            .FirstOrDefaultAsync(e => e.Id == orderId);
        return order ?? throw new NotFoundException("Order not found");
    }
}