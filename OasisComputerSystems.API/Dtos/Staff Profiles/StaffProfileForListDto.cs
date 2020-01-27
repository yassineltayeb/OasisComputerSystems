using System;

namespace OasisComputerSystems.API.Dtos.StaffProfiles
{
    public class StaffProfileForListDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string FullNameEn { get; set; }
        public string FullNameAr { get; set; }
        public int MaritalStatusId { get; set; }
        public string MaritalStatus { get; set; }
        public int NationalityId { get; set; }
        public string Nationality { get; set; }
        public int ReligionId { get; set; }
        public string Religion { get; set; }
        public int GenderId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime LastActive { get; set; }
    }
}