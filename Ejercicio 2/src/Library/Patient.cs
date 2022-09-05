//Clase que crea pacientes 

namespace Library
{
    public class Patient
    {
        public Patient(string name, string id, string phoneNumber, int age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }
    }
}