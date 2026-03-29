namespace ClinicBookingAPI.Models
{
	public class Booking
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int DoctorId { get; set; }
		public DateTime Date { get; set; }
	}
}
