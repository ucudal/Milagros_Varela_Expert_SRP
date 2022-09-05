//Clase que crea doctores

namespace Library
{
    public class Doctor
    {
        public Doctor(string name, string specialty)
        {
            this.Name = name;
            this.Specialty = specialty;
        }

        public string Name { get; set; }

        public string Specialty { get; set; }
    }
}
