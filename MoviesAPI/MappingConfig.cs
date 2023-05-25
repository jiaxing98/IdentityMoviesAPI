using AutoMapper;
using MoviesAPI.Dtos;

namespace MoviesAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(ConfigurationBinder =>
            {
                //ConfigurationBinder.CreateMap<Movie, MovieDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
