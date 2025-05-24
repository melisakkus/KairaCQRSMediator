using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;

namespace KairaCQRSMediator.Mappings
{
    public class ContactInfoMapping : Profile
    {
        public ContactInfoMapping() 
        {
            CreateMap<ContactInfo,GetContactInfosQueryResult>().ReverseMap();
            CreateMap<ContactInfo, GetContactInfoByIdQueryResult>().ReverseMap();
            CreateMap<ContactInfo, UpdateContactInfoCommand>().ReverseMap();
            CreateMap<ContactInfo, CreateContactInfoCommand>().ReverseMap();
        }
    }
}
