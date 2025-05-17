using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicAppointmentSystem.Models
{
    internal class Patient
    {
        public string Name { get; set; }
        
        public string NationalID { get; set; }

        public string PhoneNumber { get; set; }


        public Patient (string name, string nationalID, string phoneNumber)
        {
            Name = name;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
        }


        public void RegisterNewPatient()
        {
            Console.WriteLine($"Name: {Name}, National ID: {NationalID}, Phone Number: {PhoneNumber}");
        }





    }
}
