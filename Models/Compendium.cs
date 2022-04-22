using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

public class Compendium : SerializableObjectBase
{

    [System.Xml.Serialization.XmlElementAttribute("Players")]
    public List<Player> Players { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Monsters")]
    public List<Monster> Monsters { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Tables")]
    public List<Table> Tables { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("NPCs")]
    public List<NPC> NPCs { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Guilds")]
    public List<Guild> Guilds { get; set; }

}



[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public enum Prof
{
    Acrobatics = 1,
    Animal_Handling = 2,
    Arcana = 3,
    Athletics = 4,
    Deception = 5,
    History = 6,
    Insight = 7,
    Intimidation = 8,
    Investigation = 9,
    Medicine = 10,
    Nature = 11,
    Perception = 12,
    Performance = 13,
    Persuasion = 14,
    Religion = 15,
    Sleight_of_Hand = 16,
    Stealth = 17,
    Survival = 18,
}

[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public enum Save
{
    Strength = 1,
    Dexterity = 2,
    Constitution = 3,
    Intelligence = 4,
    Wisdom = 5,
    Charisma = 6
}










