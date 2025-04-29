using AutoMapper;
using Yummy.WebApi.DTOS.FeatureDTO;
using Yummy.WebApi.DTOS.MessageDTO;
using Yummy.WebApi.Entity;

namespace Yummy.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDTO>().ReverseMap();
            CreateMap<Feature, CreateFeatureDTO>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDTO>().ReverseMap();
            CreateMap<Feature, GetByIDFeatureDTO>().ReverseMap();

            //------------------------------------------------------------//

            CreateMap<Message, CreateMessageDTO>().ReverseMap();
            CreateMap<Message, ResultMessageDTO>().ReverseMap();
            CreateMap<Message, GetByIDMessageDTO>().ReverseMap();
            CreateMap<Message, UpdateMessageDTO>().ReverseMap();


        }
    }
}
