using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using zombie_hospital_suggustion_backend.Models;

namespace zombie_hospital_suggustion_backend.Controllers
{
    [ApiController]
    [Route("api/userdata")]
    public class ZombieHospitalUserDataController
    {
        [HttpPost]
       public ActionResult <PatientInfo> PostUserData(PatientInfo userData)
        {
            
            var usr = "getfnskfn";
            return null;
        }

        
    }
}
