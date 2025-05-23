using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Features.CQRS.Results.TestimonialResults;

namespace KairaCQRSMediator.Mappings
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, GetTestimonialQueryResult>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdQueryResult>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommand>().ReverseMap();
        }
    }
}
