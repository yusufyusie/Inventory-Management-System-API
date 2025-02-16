﻿using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>();
              /*.ForMember(c => c.FullAddress,
                 opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));*/
            
            CreateMap<Employee, EmployeeDto>();

            CreateMap<CompanyForCreationDto, Company>();

            CreateMap<EmployeeForCreationDto, Employee>();

            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

            CreateMap<CompanyForUpdateDto, Company>();

            CreateMap<UserForRegistrationDto, User>();

            /**/
            CreateMap<StoreHeader, StoreHeaderDto>();

            CreateMap<StoreItem, StoreItemDto>();

            CreateMap<StoreHeaderForCreationDto, StoreHeader>();

            CreateMap<StoreItemForCreationDto, StoreItem>();

            CreateMap<StoreItemForUpdateDto, StoreItem>().ReverseMap();

            CreateMap<StoreHeaderForUpdateDto, StoreHeader>();
            /**/
            CreateMap<RequestHeader, RequestHeaderDto>();

            CreateMap<RequestItem, RequestItemDto>();

            CreateMap<RequestHeaderForCreationDto, RequestHeader>();

            CreateMap<RequestItemForCreationDto, RequestItem>();

            CreateMap<RequestItemForUpdateDto, RequestItem>().ReverseMap();

            CreateMap<RequestHeaderForUpdateDto, RequestHeader>();
            /**/
            CreateMap<User, UserDto>();

            CreateMap<UserForUpdate, User>();

            /**/
            CreateMap<RequestHeaderForBudgetCodeDto, RequestHeader>();

            CreateMap<RequestItemForApprovementDto, RequestItem>();

            CreateMap<RequestItemForDistributeDto, RequestItem>();
            /**/

            CreateMap<ReportForCreationDto, Report>();
            CreateMap<ReportForUpdateDto, Report>();
            CreateMap<Report, ReportDto>();
        }
    }
}
