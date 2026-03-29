using Microsoft.AspNetCore.Mvc;
using ClinicBookingAPI.Data;
using ClinicBookingAPI.Models;

namespace ClinicBookingAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingsController : ControllerBase
	{
		private readonly AppDbContext _context;

		public BookingsController(AppDbContext context)
		{
			_context = context;
		}

		// GET all bookings
		[HttpGet]
		public IActionResult GetBookings()
		{
			return Ok(_context.Bookings.ToList());
		}

		// POST booking
		[HttpPost]
		public IActionResult AddBooking(Booking booking)
		{
			_context.Bookings.Add(booking);
			_context.SaveChanges();
			return Ok(booking);
		}

		// DELETE booking
		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var booking = _context.Bookings.Find(id);
			if (booking == null)
				return NotFound();

			_context.Bookings.Remove(booking);
			_context.SaveChanges();

			return Ok();
		}
	}
}