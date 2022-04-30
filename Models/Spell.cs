using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

public class Spell
{
    public string Name { get; set; }
    public SpellLevel SpellLevel { get; set; }
    public SpellType School { get; set; }
    public bool Verbal { get; set; }
    public bool Somantic { get; set; }
    public bool Materilistic { get; set; }
    public string MaterialNeeded { get; set; }
    public string Description { get; set; }
    public string CastingTime { get; set; }
    public string Range { get; set; }
    public string Duration { get; set; }


}

public enum SpellType
{
    None,
    Abjuration,
    Conjuration,
    Divination,
    Enchantment,
    Evocation,
    Illusion,
    Necromancy,
    Transmutation
}
public enum SpellLevel
{
    [Description("Cantrip")]
    Cantrip= 0,
    [Description("1st-Level")]
    FirstLevel = 1,
    [Description("2nd-Level")]
    SecondLevel = 2,
    [Description("3rd-Level")]
    ThirdLevel = 3,
    [Description("4th-Level")]
    FourthLevel = 4,
    [Description("5th-Level")]
    FifthLevel = 5,
    [Description("6th-Level")]
    SixthLevel = 6,
    [Description("7th-Level")]
    SeventhLevel = 7,
    [Description("8th-Level")]
    EighthLevel = 8,
    [Description("9th-Level")]
    NinthLevel = 9
}

public static class MyEnumExtensions
{
    public static string ToDescriptionString(this SpellLevel val)
    {
        DescriptionAttribute[] attributes = (DescriptionAttribute[])val
          .GetType()
          .GetField(val.ToString())
          .GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }
}

