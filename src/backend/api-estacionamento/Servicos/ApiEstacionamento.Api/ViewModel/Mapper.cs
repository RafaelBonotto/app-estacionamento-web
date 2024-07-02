using AutoMapper;

namespace ApiEstacionamento.Api.ViewModel
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;
        }
    }
}
