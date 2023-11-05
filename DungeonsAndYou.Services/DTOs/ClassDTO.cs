﻿using System.ComponentModel.DataAnnotations;
using DungeonsAndYou.Services.DTOs.Enums;

namespace DungeonsAndYou.Services.DTOs
{
    public class ClassDTO
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _hitDie;
        private readonly int[] _primaryAbilities;
        private readonly int[] _savingProficiencies;
        private readonly int[] _proficientSkills;

        [Key]
        public int Id { get => _id; }

        public string Name { get => _name; }

        public int HitDie { get => _hitDie; }

        public int[] PrimaryAbilities { get => _primaryAbilities; }

        public int[] SavingProficiencies { get => _savingProficiencies; }

        public int[] ProficientSkills { get => _proficientSkills; }


        public ClassDTO(string name, int hitDie, EAbilitiesDTO[] primaryAbilities, EAbilitiesDTO[] savingProficiencies, ESkillsDTO[] proficientSkills)
        {
            _name = name;
            _id = Guid.NewGuid().GetHashCode();
            _hitDie = hitDie;
            int[] primaryAbilitiesInt = Array.ConvertAll(primaryAbilities, value => (int)value);
            _primaryAbilities = primaryAbilitiesInt;
            int[] savingProficienciesInt = Array.ConvertAll(savingProficiencies, value => (int)value);
            _savingProficiencies = savingProficienciesInt;
            int[] proficientSkillsInt = Array.ConvertAll(proficientSkills, value => (int)value);
            _proficientSkills = proficientSkillsInt;
        }

        //private Class() { }

    }
}