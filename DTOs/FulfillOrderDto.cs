
namespace apbd_test.DTOs;

public class FulfillOrderDto
{
    public int OrderId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime FulfilledAt { get; set; }
    public string Status { get; set; }
    public ClientDto Client { get; set; }
    public List<ProductDto> Products { get; set; }
}

