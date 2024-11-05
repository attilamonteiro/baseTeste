using AutoMapper;

namespace MyCrudApi.MapperProfiles
{
    public class BaseProfile: Profile
    {
        public BaseProfile()
        {
            CreateMap<Request.BaseRequest, Models.Product>();
            CreateMap<Models.Product, Request.BaseRequest>();
        }
    }
}
