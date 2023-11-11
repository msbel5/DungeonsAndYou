using System.ComponentModel.DataAnnotations;

namespace DungeonsAndYou.Data.Models.Enums
{
    public enum ESkills
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
