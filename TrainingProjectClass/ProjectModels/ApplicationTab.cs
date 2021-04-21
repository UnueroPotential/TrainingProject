using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingProjectClass.ProjectModels
{
    public class ApplicationTab
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string ApplicantName { get; set; }
        [MaxLength(15)]
        public string ApplicantPhoneNumber { get; set; }
        [MaxLength(15)]
        public string ApplicantEmail { get; set; }
        [MaxLength(100)]
        public string ApplicantAddress { get; set; }
        [MaxLength(100)]
        public string PositionApply { get; set; }
        public DateTime DateApplied { get; set; }
        public bool ApplicationStatus { get; set; }
    }
}
