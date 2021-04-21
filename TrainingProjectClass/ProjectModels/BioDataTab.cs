using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingProjectClass.ProjectModels
{
    public class BioDataTab
    {
        public int Id { get; set; }
        [MaxLength(1)]
        public string Title { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string OtherNames { get; set; }
        [MaxLength(1)]
        public string Nationality { get; set; }
        [MaxLength(1)]
        public string State { get; set; }
        [MaxLength(1)]
        public string LGA { get; set; }
        [MaxLength(1)]
        public string Gender { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
        [MaxLength(1)]
        public string MaritalStatus { get; set; }
        public DateTime DateofBirth { get; set; }
        [MaxLength(1)]
        public string Religion { get; set; }
    }
}
