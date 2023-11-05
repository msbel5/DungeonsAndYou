using System.ComponentModel.DataAnnotations;
using DungeonsAndYou.Services.DTOs.Enums;

namespace DungeonsAndYou.Services.DTOs
{
    public class BackgroundDTO
    {
        private readonly int _id;
        private string _name;
        private readonly int[] _proficientSkills;

        [Key]
        public int Id { get => _id; }

        public string Name { get => _name; set => _name = value; }


        public int[] ProficientSkills { get => _proficientSkills; }


        public BackgroundDTO(string name, ESkillsDTO[] proficientSkills)
        {
            _name = name;
            _id = Guid.NewGuid().GetHashCode();
            int[] proficientSkillsInt = Array.ConvertAll(proficientSkills, value => (int)value);
            _proficientSkills = proficientSkillsInt;
        }

        //private Background() { }

    }
}
