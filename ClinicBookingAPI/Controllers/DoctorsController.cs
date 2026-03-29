using Microsoft.AspNetCore.Mvc;
using ClinicBookingAPI.Data;
using ClinicBookingAPI.Models;

namespace ClinicBookingAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DoctorsController : ControllerBase
	{
		private readonly AppDbContext _context;

		public DoctorsController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/doctors
		[HttpGet]
		public IActionResult GetDoctors()
		{
			var doctors = _context.Doctors.ToList();
			return Ok(doctors);
		}

		// GET: api/doctors/1
		[HttpGet("{id}")]
		public IActionResult GetDoctor(int id)
		{
			var doctor = _context.Doctors.Find(id);
			if (doctor == null)
				return NotFound();

			return Ok(doctor);
		}

		// POST: api/doctors
		[HttpPost]
		public IActionResult AddDoctor(Doctor doctor)
		{
			_context.Doctors.Add(doctor);
			_context.SaveChanges();
			return Ok(doctor);
		}

		// PUT: api/doctors/1
		[HttpPut("{id}")]
		public IActionResult UpdateDoctor(int id, Doctor updatedDoctor)
		{
			var doctor = _context.Doctors.Find(id);
			if (doctor == null)
				return NotFound();

			doctor.Name = updatedDoctor.Name;
			doctor.Specialty = updatedDoctor.Specialty;

			_context.SaveChanges();
			return Ok(doctor);
		}

		// DELETE: api/doctors/1
		[HttpDelete("{id}")]
		public IActionResult DeleteDoctor(int id)
		{
			var doctor = _context.Doctors.Find(id);
			if (doctor == null)
				return NotFound();

			_context.Doctors.Remove(doctor);
			_context.SaveChanges();
			return Ok();
		}
	}
}