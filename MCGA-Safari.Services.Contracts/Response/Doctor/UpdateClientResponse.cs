﻿using MCGA_Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MCGA_Safari.Services.Contracts.Response
{
    [DataContract]
    public class UpdateDoctorResponse
    {
        [DataMember]
        public Doctor Result { get; set; }
    }
}
