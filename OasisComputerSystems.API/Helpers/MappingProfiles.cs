using System.Linq;
using AutoMapper;
using OasisComputerSystems.API.Dtos;
using OasisComputerSystems.API.Dtos.Clients;
using OasisComputerSystems.API.Dtos.StaffProfile;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // //Model to DTo
            //Staff Profiles
            CreateMap<StaffProfile, StaffProfileForLoginDto>();
            CreateMap<StaffProfile, StaffProfileForRegisterDto>();
            CreateMap<StaffProfile, StaffProfileForListDto>()
                .ForMember(dest => dest.MaritalStatus, opt => opt.MapFrom(src => src.MaritalStatus.Name))
                .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality.Name))
                .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.Name))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.Name));

            //Clients
            CreateMap<Client, ClientForRegisterDto>();
            CreateMap<Client, ClientForUpdateDto>();

            CreateMap<Client, ClientForListDto>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy.FullNameEn))
                .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy.FullNameEn));

            CreateMap<Client, ClientForDetailsDto>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy.FullNameEn))
                .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy.FullNameEn));

            CreateMap<ClientContact, ClientContactForRegisterDto>();
            CreateMap<ClientContact, ClientContactForDetailsDto>();
            CreateMap<ClientContactSupport, ClientContactSupportForRegisterDto>();
            CreateMap<ClientContactSupport, ClientContactSupportForDetailsDto>();

            CreateMap<ClientsModules, ClientsModulesForRegisterDto>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Client.Id))
                .ForMember(dest => dest.SystemModuleId, opt => opt.MapFrom(src => src.SystemModule.Id));

            CreateMap<ClientsModules, ClientsModulesForDetailsDto>();


            //Key Value Pairs
            CreateMap<Country, KeyValuePairs>();
            CreateMap<Gender, KeyValuePairs>();
            CreateMap<MaritalStatus, KeyValuePairs>();
            CreateMap<Nationality, KeyValuePairs>();
            CreateMap<Priority, KeyValuePairs>();
            CreateMap<Religion, KeyValuePairs>();
            CreateMap<SystemModule, KeyValuePairs>();

            // //Dto to Model
            //Staff Profiles
            CreateMap<StaffProfileForLoginDto, StaffProfile>();
            CreateMap<StaffProfileForRegisterDto, StaffProfile>();
            CreateMap<StaffProfileForListDto, StaffProfile>();

            //Clients
            CreateMap<ClientForRegisterDto, Client>();
            CreateMap<ClientForUpdateDto, Client>();
            CreateMap<ClientForListDto, Client>();
            CreateMap<ClientForDetailsDto, Client>();
            CreateMap<ClientContactForRegisterDto, ClientContact>();
            CreateMap<ClientContactForDetailsDto, ClientContact>();
            CreateMap<ClientContactSupportForRegisterDto, ClientContactSupport>();
            CreateMap<ClientContactSupportForDetailsDto, ClientContactSupport>();
            CreateMap<ClientsModulesForRegisterDto, ClientsModules>();
            CreateMap<ClientsModulesForDetailsDto, ClientsModules>();


            //Key Value Pairs
            CreateMap<KeyValuePairs, Country>();
            CreateMap<KeyValuePairs, Gender>();
            CreateMap<KeyValuePairs, MaritalStatus>();
            CreateMap<KeyValuePairs, Nationality>();
            CreateMap<KeyValuePairs, Priority>();
            CreateMap<KeyValuePairs, Religion>();
            CreateMap<KeyValuePairs, SystemModule>();
        }


    }
}