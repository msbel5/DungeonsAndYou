using System.ComponentModel.DataAnnotations;

namespace DungeonsAndYou.Services.DTOs.Enums
{
    public enum ESkillsDTO
    {
        Athletics,
        Acrobatics,
        [Display(Name = "Sleight Of Hand")]
        sleightOfHand,
        Stealth,
        Arcana,
        History,
        Investigation,
        Nature,
        Religion,
        [Display(Name = "Animal Handling")]
        animalHandling,
        Insight,
        Medicine,
        Perception,
        Survival,
        Deception,
        Intimidation,
        Performance,
        Persuasion
    }
}
