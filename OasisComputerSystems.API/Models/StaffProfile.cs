using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OasisComputerSystems.API.Models
{
    public class StaffProfile : IdentityUser<int>
    {
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
        [Required]
        [StringLength(255)]
        public string FullNameEn { get; set; }
        [Required]
        [StringLength(255)]
        public string FullNameAr { get; set; }
        [Required]
        public int MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        [Required]
        public int NationalityId { get; set; }
        public Nationality Nationality  { get; set; }
        [Required]
        public int ReligionId { get; set; }
        public Religion Religion { get; set; }
        [Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(255)]
        public string MobileNumber { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime LastActive { get; set; }
        public ICollection<StaffProfileRole> StaffProfileRoles { get; set; }
    }
}