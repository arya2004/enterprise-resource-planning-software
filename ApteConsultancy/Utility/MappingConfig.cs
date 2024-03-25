using ApteConsultancy.Dto.AdminDto;
using ApteConsultancy.Dto.AuthDto;
using ApteConsultancy.Dto.DropdownDto;
using ApteConsultancy.Dto.EmployeeDto;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Model.Master;
using ApteConsultancy.Models;
using ApteConsultancy.Models.Master;
using AutoMapper;

namespace ApteConsultancy.Utility
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {

                config.CreateMap<ApplicationUser, EmployeeRegisterRequestDto>().ReverseMap();
                config.CreateMap<ApplicationUser, AssociateRegisterRequestDto>().ReverseMap();

                config.CreateMap<ProjectDto, Project>().ReverseMap();
                config.CreateMap<CreateProjectFeesDto, ProjectDto>().ReverseMap();
                config.CreateMap<CompanyDto, Company>().ReverseMap();
                config.CreateMap<CompanyDropdownDto, Company>().ReverseMap();
                config.CreateMap<ClientDto, Client>().ReverseMap();
                config.CreateMap<ArchitectDto, Architect>().ReverseMap();
                config.CreateMap<CreateGSTInvoiceDto, GSTInvoice>().ReverseMap();
                config.CreateMap<CreateProformaInvoiceDto, ProformaInvoice>().ReverseMap();
                config.CreateMap<CreateAttendanceDto, Employee_Attendance>().ReverseMap();
                config.CreateMap<CreateOwnCarLocalAndOutStationDto, OwnCarLocalAndOutStation>().ReverseMap();
                

            });
            return mappingConfig;
        }
    }
}