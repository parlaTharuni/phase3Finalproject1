﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;

namespace Phase3EndProject1.Models
{
    public class DeptMasterModel
    {
        public int DeptCode { get; set; }

        public string DeptName { get; set; }

        public virtual ICollection<EmpProfileModel> EmpProfiles { get; set; }

    }
}