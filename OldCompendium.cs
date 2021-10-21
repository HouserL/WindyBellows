using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
//using System.Data.SQ

namespace WindyBellows
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("compendium")]
    public class OldCompendium : SerializableObjectBase
    {
        [XmlElement("race")]
        public List<CompendiumRace> RaceTypes { get; set; }

        [XmlElement("class")]
        public List<CompendiumClass> ClassTypes { get; set; }

        [XmlElement("background")]
        public List<CompendiumBackground> BackgroundTypes { get; set; }

        [XmlElement("item")]
        public List<CompendiumItem> ItemTypes { get; set; }

        [XmlElement("feat")]
        public List<CompendiumFeature> FeatureTypes { get; set; }

        [XmlElement("spell")]
        public List<CompendiumSpell> SpellTypes { get; set; }

        [XmlElement("monster")]
        public List<CompendiumMonster> MonsterTypes { get; set; }

        [XmlAttribute]
        public byte version { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumRace
    {
        [XmlElement("ability", typeof(string))]
        [XmlElement("name", typeof(string))]
        [XmlElement("proficiency", typeof(string))]
        [XmlElement("size", typeof(string))]
        [XmlElement("speed", typeof(byte))]
        [XmlElement("spellAbility", typeof(string))]
        [XmlElement("trait", typeof(CompendiumBaseItem))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

      
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        
        public ItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumBaseItem
    {
        [XmlElement("name", typeof(string))]
        public string Name { get; set; }
        [XmlElement("text", typeof(string))]
        public string Text { get; set; }
    }

    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        ability,
        name,
        proficiency,
        size,
        speed,
        spellAbility,
        trait
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumClass
    {
        public string name { get; set; }

        public byte hd { get; set; }

        public string proficiency { get; set; }

        public byte numSkills { get; set; }

        public string armor { get; set; }

        public string weapons { get; set; }

        public string tools { get; set; }

        public string wealth { get; set; }
        public string spellAbility { get; set; }

        public string slotsReset { get; set; }

        [XmlElement("autolevel")]
        public CompendiumClassAutoLevel[] autolevel { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumClassAutoLevel
    {
        [XmlElement("slots")]
        public compendiumClassAutolevelSlots slots { get; set; }

        [XmlElement("feature")]
        public compendiumClassAutolevelFeature[] feature { get; set; }

        [XmlElement("counter")]
        public compendiumClassAutolevelCounter[] counter { get; set; }

        [XmlAttribute]
        public byte level { get; set; }

        [XmlAttribute]
        public string scoreImprovement { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class compendiumClassAutolevelSlots
    {
        [XmlAttribute]
        public string optional { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class compendiumClassAutolevelFeature : CompendiumBaseItem
    {
        public string special { get; set; }
        [XmlAttribute]
        public string optional { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class compendiumClassAutolevelCounter
    {
        public string name { get; set; }

        public string reset { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumBackground
    {

        public string name { get; set; }

        public string proficiency { get; set; }

        /// <remarks/>
        [XmlElement("trait")]
        public List<CompendiumBaseItem> Traits { get; set; }

    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumItem
    {
        [XmlElement("ac", typeof(byte))]
        [XmlElement("detail", typeof(string))]
        [XmlElement("dmg1", typeof(string))]
        [XmlElement("dmg2", typeof(string))]
        [XmlElement("dmgType", typeof(string))]
        [XmlElement("magic", typeof(string))]
        [XmlElement("modifier", typeof(CompendiumBaseModifier))]
        [XmlElement("name", typeof(string))]
        [XmlElement("property", typeof(string))]
        [XmlElement("range", typeof(string))]
        [XmlElement("text", typeof(string))]
        [XmlElement("type", typeof(string))]
        [XmlElement("value", typeof(decimal))]
        [XmlElement("weight", typeof(decimal))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType1[] ItemsElementName { get; set; }

    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumBaseModifier
    {

        [XmlAttribute("category")]
        public string Category { get; set; }

        [XmlText]
        public string Value { get; set; }

    }

    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        ac,
        detail,
        dmg1,
        dmg2,
        dmgType,
        magic,
        modifier,
        name,
        property,
        range,
        text,
        type,
        value,
        weight,
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumFeature :CompendiumBaseItem
    {
        public string prerequisite { get; set; }
        public string proficiency { get; set; }
        public CompendiumBaseModifier modifier { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumSpell : CompendiumBaseItem
    {
        public byte level { get; set; }
        [XmlIgnore]
        public bool levelSpecified { get; set; }
        public string school { get; set; }
        public string time { get; set; }
        public string range { get; set; }
        public string components { get; set; }
        public string duration { get; set; }
        [XmlElement("roll")]
        public string[] roll { get; set; }
        public string classes { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumMonster
    {
        [XmlElement("ac", typeof(string))]
        [XmlElement("action", typeof(CompendiumMonsterAction))]
        [XmlElement("alignment", typeof(string))]
        [XmlElement("cha", typeof(byte))]
        [XmlElement("con", typeof(byte))]
        [XmlElement("conditionImmune", typeof(string))]
        [XmlElement("cr", typeof(string))]
        [XmlElement("description", typeof(string))]
        [XmlElement("dex", typeof(byte))]
        [XmlElement("environment", typeof(string))]
        [XmlElement("hp", typeof(string))]
        [XmlElement("immune", typeof(string))]
        [XmlElement("int", typeof(byte))]
        [XmlElement("languages", typeof(string))]
        [XmlElement("legendary", typeof(CompendiumBaseItem))]
        [XmlElement("name", typeof(string))]
        [XmlElement("passive", typeof(byte))]
        [XmlElement("reaction", typeof(CompendiumBaseItem))]
        [XmlElement("resist", typeof(string))]
        [XmlElement("save", typeof(string))]
        [XmlElement("senses", typeof(string))]
        [XmlElement("size", typeof(string))]
        [XmlElement("skill", typeof(string))]
        [XmlElement("slots", typeof(string))]
        [XmlElement("speed", typeof(string))]
        [XmlElement("str", typeof(byte))]
        [XmlElement("trait", typeof(CompendiumBaseItem))]
        [XmlElement("type", typeof(string))]
        [XmlElement("wis", typeof(byte))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType2[] ItemsElementName { get; set; }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CompendiumMonsterAction : CompendiumBaseItem
    {
        [XmlElement("attack")]
        public string[] attack { get; set; }
    }

    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {
        ac,
        action,
        alignment,
        cha,
        con,
        conditionImmune,
        cr,
        description,
        dex,
        environment,
        hp,
        immune,
        @int,
        languages,
        legendary,
        name,
        passive,
        reaction,
        resist,
        save,
        senses,
        size,
        skill,
        slots,
        speed,
        str,
        trait,
        type,
        wis
    }


}

