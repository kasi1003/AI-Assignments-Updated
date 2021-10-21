﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionsWebApp.Models
{
    public class QualificationVM
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Institution { get; set; }
        public int YearObtained { get; set; }
        public int CertificateDocumentId { get; set; }
        public int NQFLevel { get; set; }
        public virtual DocumentVM CertificateDocument { get; set; }
    }
}
