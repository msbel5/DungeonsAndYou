using AutoMapper;
using DungeonsAndYou.Data.Models;
using DungeonsAndYou.Services.DTOs;

namespace DungeonsAndYou.Services.Configurations
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<CharacterSheet, CharacterSheetDTO>();
            CreateMap<CharacterSheetDTO, CharacterSheet>().ForMember(x=>x.Id, opt => opt.Ignore());
        }
    }
}
