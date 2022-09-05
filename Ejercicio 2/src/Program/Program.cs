using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient Steven = new Patient("Steven Johnson", "986782342", "5555-555-555", 16);
            
            Patient Ralf = new Patient("Ralf Manson", "", "5555-555-555", 9);

            Doctor Armand = new Doctor("Armand", "Pediatrics");

            
            string appointmentResult = AppointmentService.CreateAppointment(Steven, Armand, DateTime.Now, "Wall Street", "1234");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(Ralf, Armand, DateTime.Now, "Queen Street", "1235");
            Console.WriteLine(appointmentResult2);
        }
    }
}
