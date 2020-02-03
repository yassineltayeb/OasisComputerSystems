using AutoMapper;
using OasisComputerSystems.API.Dtos;
using OasisComputerSystems.API.Dtos.Clients;
using OasisComputerSystems.API.Dtos.StaffProfiles;
using OasisComputerSystems.API.Dtos.Tickets;
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
                .ForMember(dest => dest.AccountManager, opt => opt.MapFrom(src => src.AccountManager.FullNameEn))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy.FullNameEn))
                .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy.FullNameEn));

            CreateMap<Client, ClientForDetailsDto>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.AccountManager, opt => opt.MapFrom(src => src.AccountManager.FullNameEn))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy.FullNameEn))
                .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy.FullNameEn));

            CreateMap<ClientContact, ClientContactForRegisterDto>();
            CreateMap<ClientContact, ClientContactForDetailsDto>();
            CreateMap<ClientContactSupport, ClientContactSupportForRegisterDto>();
            CreateMap<ClientContactSupport, ClientContactSupportForDetailsDto>();

            CreateMap<ClientModules, ClientsModulesForListDto>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Client.Id))
                .ForMember(dest => dest.SystemModuleId, opt => opt.MapFrom(src => src.SystemModule.Id))
                .ForMember(dest => dest.SystemModule, opt => opt.MapFrom(src => src.SystemModule.Name));

            CreateMap<ClientModules, ClientsModulesForRegisterDto>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Client.Id))
                .ForMember(dest => dest.SystemModuleId, opt => opt.MapFrom(src => src.SystemModule.Id));

            CreateMap<ClientModules, ClientsModulesForDetailsDto>();

            //Tickets
            CreateMap<Ticket, TicketForRegisterDto>();
            CreateMap<Ticket, TicketForUpdateDto>();

            CreateMap<Ticket, TicketForListDto>()
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority.Name))
                .ForMember(dest => dest.TicketType, opt => opt.MapFrom(src => src.TicketType.Name))
                .ForMember(dest => dest.AssignedTo, opt => opt.MapFrom(src => src.AssignedTo.FullNameEn))
                .ForMember(dest => dest.SystemModule, opt => opt.MapFrom(src => src.SystemModule.Name))
                .ForMember(dest => dest.SubmittedBy, opt => opt.MapFrom(src => src.SubmittedBy.FullNameEn))
                .ForMember(dest => dest.ClosedBy, opt => opt.MapFrom(src => src.ClosedBy.FullNameEn))
                .ForMember(dest => dest.ApprovedBy, opt => opt.MapFrom(src => src.ApprovedBy.FullNameEn));


            CreateMap<TicketNote, TicketNoteForRegisterDto>();

            CreateMap<TicketNote, TicketNoteForListDto>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy.FullNameEn));



            //Key Value Pairs
            CreateMap<Country, KeyValuePairs>();
            CreateMap<Gender, KeyValuePairs>();
            CreateMap<MaritalStatus, KeyValuePairs>();
            CreateMap<Nationality, KeyValuePairs>();
            CreateMap<Priority, KeyValuePairs>();
            CreateMap<Religion, KeyValuePairs>();
            CreateMap<SystemModule, KeyValuePairs>();
            CreateMap<TicketType, KeyValuePairs>();
            CreateMap<Client, KeyValuePairs>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NameEn));

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
            CreateMap<ClientContactForRegisterDto, ClientContact>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<ClientContactForDetailsDto, ClientContact>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<ClientContactSupportForRegisterDto, ClientContactSupport>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<ClientContactSupportForDetailsDto, ClientContactSupport>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<ClientsModulesForListDto, ClientModules>();
            CreateMap<ClientsModulesForRegisterDto, ClientModules>();
            CreateMap<ClientsModulesForDetailsDto, ClientModules>();

            //Tickets
            CreateMap<TicketForRegisterDto, Ticket>();

            CreateMap<TicketForUpdateDto, Ticket>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            CreateMap<TicketForListDto, Ticket>();
            CreateMap<TicketNoteForRegisterDto, TicketNote>();
            CreateMap<TicketNoteForListDto, TicketNote>();

            //Key Value Pairs
            CreateMap<KeyValuePairs, Country>();
            CreateMap<KeyValuePairs, Gender>();
            CreateMap<KeyValuePairs, MaritalStatus>();
            CreateMap<KeyValuePairs, Nationality>();
            CreateMap<KeyValuePairs, Priority>();
            CreateMap<KeyValuePairs, Religion>();
            CreateMap<KeyValuePairs, SystemModule>();
            CreateMap<KeyValuePairs, TicketType>();

        }


    }
}