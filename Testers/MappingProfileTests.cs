using AutoMapper;
using Logic;

namespace Testers
{
    public class MappingProfileTests
    {
        [Fact]
        public void MappingProfile_IsValid()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            config.AssertConfigurationIsValid();
        }
    }
}