using apbd_test.DTOs;

namespace apbd_test.Services;

public interface IDbService
{
    public Task<OrderDto> GetOrderById(int orderId);
}