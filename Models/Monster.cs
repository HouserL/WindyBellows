using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public class Monster : SerializableObjectBase
{

    public string Name { get; set; }
    public byte STR { get; set; }
    public byte DEX { get; set; }
    public byte CON { get; set; }
    public byte INT { get; set; }
    public byte WIS { get; set; }
    public byte CHR { get; set; }
    public string Size { get; set; }
    public string Type { get; set; }
    public string Alignment { get; set; }
    public string AC { get; set; }
    public string Speed { get; set; }
    public int HitDie { get; set; }
    public byte HitDieValue { get; set; }
    public string OldSkill { get; set; }
    public string OldSave { get; set; }
    public List<Save> Save { get; set; } = new();
    public List<Prof> Profs { get; set; } = new();
    public string CR { get; set; }
    public string Slots { get; set; }
    public byte ProfBonus { get; set; }
    public int PassivePerception()
    {
        if (Profs == null)
        {
            Profs = new List<Prof>();
        }
        if (Profs.Contains(Prof.Perception))
        {
            return (WIS / 2 - 5 + 10 + ProfBonus);
        }
        return (WIS / 2 - 5 + 10);

    }
    public string Senses { get; set; }
    public string Condition { get; set; }
    public string Immuneold { get; set; }
    public string Resist { get; set; }
    public string Enviroment { get; set; }
    public string Description { get; set; }
    public string Languages { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Trait")]
    public List<BaseItem> Trait { get; set; } = new();
    [System.Xml.Serialization.XmlElementAttribute("Action")]
    public List<BaseItem> Action { get; set; } = new();
    [System.Xml.Serialization.XmlElementAttribute("Reaction")]
    public List<BaseItem> Reaction { get; set; } = new();
    [System.Xml.Serialization.XmlElementAttribute("Legendary")]
    public List<BaseItem> Legendary { get; set; } = new();
    public int AverageHP()
    {
        return (HitDieValue * (HitDie + 1) / 2 + HitDie * (CON / 2 - 5));
    }
    public int RandomHP()
    {
        int Output = 0;
        for (int i = 0; i < HitDie; i++)
        {
            Output += Table.RandomNumberSeeded(HitDieValue) + (CON / 2 - 5);
        }
        return Output;
    }
    public string HPFormula()
    {
        switch (CON)
        {
            case < 10: return (HitDie + "d" + HitDieValue + "-" + CON).ToString();
            case 10 or 11: return (HitDie + "d" + HitDieValue).ToString();
            case > 11: return (HitDie + "d" + HitDieValue + "+" + CON).ToString();
            default:
        }
    }
}
