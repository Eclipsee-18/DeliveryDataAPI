using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIPost.Data;
using WebAPIPost.Model;

namespace WebAPIPost.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerDataController : ControllerBase
	{
		private readonly ApplicationDbContext _context;

		public CustomerDataController(ApplicationDbContext context)
		{
			_context = context;
		}
		[HttpPost]
		public ActionResult<CustomerData> CreateItem([FromBody] CustomerData data)
		{
			// Add the item to the database
			_context.CustomersData.Add(data);
			_context.SaveChanges();

			// Return the newly created item
			return Ok();
		}
	}
}
