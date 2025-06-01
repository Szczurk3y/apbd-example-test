using apbd_test.DTOs;
using apbd_test.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IDbService _dbService;

    public OrdersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        try
        {
            var order = await _dbService.GetOrderById(id);
            return Ok(order);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return NotFound();
        }
    }

    // [HttpPut("{orderId}/fulfill")]
    // public async Task<IActionResult> FulfillOrder(int orderId, FulfillOrderDto dto)
    // {
    //     return Ok();
    // }
}