using AutoMapper;

namespace ApteConsultancy.Utility
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
            });
            return mappingConfig;
        }
    }
}
