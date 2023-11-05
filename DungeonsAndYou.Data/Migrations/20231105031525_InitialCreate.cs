using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DungeonsAndYou.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Race = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Class = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Background = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alignment = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProficiencyBonus = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Initiative = table.Column<int>(type: "int", nullable: false),
                    PassiveWisdom = table.Column<int>(type: "int", nullable: false),
                    MaxHitPoints = table.Column<int>(type: "int", nullable: false),
                    HitDie = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    StrengthModifier = table.Column<int>(type: "int", nullable: false),
                    StrengthSave = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    DexterityModifier = table.Column<int>(type: "int", nullable: false),
                    DexteritySave = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    ConstitutionModifier = table.Column<int>(type: "int", nullable: false),
                    ConstitutionSave = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    IntelligenceModifier = table.Column<int>(type: "int", nullable: false),
                    IntelligenceSave = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    WisdomModifier = table.Column<int>(type: "int", nullable: false),
                    WisdomSave = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    CharismaModifier = table.Column<int>(type: "int", nullable: false),
                    CharismaSave = table.Column<int>(type: "int", nullable: false),
                    Acrobatics = table.Column<int>(type: "int", nullable: false),
                    AnimalHandling = table.Column<int>(type: "int", nullable: false),
                    Arcana = table.Column<int>(type: "int", nullable: false),
                    Athletics = table.Column<int>(type: "int", nullable: false),
                    Deception = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<int>(type: "int", nullable: false),
                    Insight = table.Column<int>(type: "int", nullable: false),
                    Intimidation = table.Column<int>(type: "int", nullable: false),
                    Investigation = table.Column<int>(type: "int", nullable: false),
                    Medicine = table.Column<int>(type: "int", nullable: false),
                    Nature = table.Column<int>(type: "int", nullable: false),
                    Perception = table.Column<int>(type: "int", nullable: false),
                    Performance = table.Column<int>(type: "int", nullable: false),
                    Persuasion = table.Column<int>(type: "int", nullable: false),
                    Religion = table.Column<int>(type: "int", nullable: false),
                    SleightOfHand = table.Column<int>(type: "int", nullable: false),
                    Stealth = table.Column<int>(type: "int", nullable: false),
                    Survival = table.Column<int>(type: "int", nullable: false),
                    RaceAbilityBonusses = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassPrimaryAbilities = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassSavingProficiencies = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassProficientSkills = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BackgroundProficientSkills = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSheets", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CharacterSheets",
                columns: new[] { "Id", "Acrobatics", "Alignment", "AnimalHandling", "Arcana", "Athletics", "Background", "BackgroundProficientSkills", "Charisma", "CharismaModifier", "CharismaSave", "Class", "ClassPrimaryAbilities", "ClassProficientSkills", "ClassSavingProficiencies", "Constitution", "ConstitutionModifier", "ConstitutionSave", "Deception", "Dexterity", "DexterityModifier", "DexteritySave", "History", "HitDie", "Initiative", "Insight", "Intelligence", "IntelligenceModifier", "IntelligenceSave", "Intimidation", "Investigation", "Level", "MaxHitPoints", "Medicine", "Name", "Nature", "PassiveWisdom", "Perception", "Performance", "Persuasion", "ProficiencyBonus", "Race", "RaceAbilityBonusses", "Religion", "Size", "SleightOfHand", "Speed", "Stealth", "Strength", "StrengthModifier", "StrengthSave", "Survival", "Wisdom", "WisdomModifier", "WisdomSave" },
                values: new object[,]
                {
                    { -636489837, 2, "neutralGood", 3, 6, 2, "Sage", "4,5", 17, 3, 5, "Bard", "5", "14,17,16", "1,5", 11, 0, 0, 5, 15, 2, 4, 6, 8, 2, 3, 18, 4, 4, 3, 4, 1, 8, 3, "Marvin", 4, 13, 3, 5, 5, 2, "Human", "0,1,2,3,4,5", 4, "m", 2, 30, 2, 15, 2, 2, 3, 16, 3, 3 },
                    { 1325962638, 2, "neutralGood", 3, 6, 2, "Sage", "4,5", 17, 3, 5, "Bard", "5", "14,17,16", "1,5", 11, 0, 0, 5, 15, 2, 4, 6, 8, 2, 3, 18, 4, 4, 3, 4, 1, 8, 3, "Marvin", 4, 13, 3, 5, 5, 2, "Human", "0,1,2,3,4,5", 4, "m", 2, 30, 2, 15, 2, 2, 3, 16, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSheets");
        }
    }
}
