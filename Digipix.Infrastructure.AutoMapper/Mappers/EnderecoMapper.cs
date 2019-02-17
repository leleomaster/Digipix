using AutoMapper;
using Digipix.Domain;
using Digipix.Model;

namespace Digipix.Infrastructure.AutoMapper.Mappers
{
    public static class EnderecoMapper
    {
        public static EnderecoModel DomainToModelView(EnderecoDomain enderecoDomain)
        {
            return Mapper.Map<EnderecoModel>(enderecoDomain);
        }

        public static EnderecoDomain ModelViewToDomain(EnderecoModel enderecoModel)
        {
            return Mapper.Map<EnderecoDomain>(enderecoModel);
        }
    }
}
