using ClinicBookingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicBookingAPI.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		
		public DbSet<User> Users { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Booking> Bookings { get; set; }

	}
	}

