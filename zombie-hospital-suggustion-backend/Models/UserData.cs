using System;
namespace zombie_hospital_suggustion_backend.Models
{

    public class PatientInfo
    {
        public UserData patientInfo { get; set; }
    }

    public class UserData
    {
        public string illness { get; set; }
        public string name { get; set; }
    }
}
