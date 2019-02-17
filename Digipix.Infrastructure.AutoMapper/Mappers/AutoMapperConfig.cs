using AutoMapper;
using Digipix.Domain;
using Digipix.Model;

namespace Digipix.Infrastructure.AutoMapper.Mappers
{
    public class AutoMapperConfig : Profile
    {
        public static void Run()
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<AutoMapperConfig>();
            });
        }

        public AutoMapperConfig()
        {
            CreateMap<UsuarioDomain, UsuarioModel>();
            CreateMap<UsuarioModel, UsuarioDomain>();
        }
    }
}
