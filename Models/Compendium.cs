using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows
{
    public partial class Compendium : SerializableObjectBase
    {

        [System.Xml.Serialization.XmlElementAttribute("Player")]
        public List<Player> Players { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("Monster")]
        public List<Monster> Monsters { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("Table")]
        public List<Table> Tables { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("NPC")]
        public List<NPC> NPCs { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("Guild")]
        public List<Guild> Guilds { get; set; }

    }
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Player : SerializableObjectBase
    {
        public string Name { get; set; }
        public byte Level { get; set; }
        public byte HP { get; set; }
        public BaseStats Stats { get; set; }
        public byte AC { get; set; }
        public byte Old_AC { get; set; }
        public int Old_Preception { get; set; }
        public List<Prof> Prof { get; set; } = new();
        [System.Xml.Serialization.XmlElementAttribute("Trait")]
        public List<BaseItem> Trait { get; set; } = new();
        public int ProfBonus
        {
            get
            {
                return (Level - 1) / 4 + 2;
            }
        }
        public int Preception
        {
            get
            {
                if (Prof == null)
                {
                    Prof = new List<Prof>();
                }
                return Prof.Contains(WindyBellows.Prof.Perception) ? (Stats.WIS / 2) - 5 + 10 + ProfBonus : (Stats.WIS / 2) - 5 + 10;
            }

        }
       
       // public int Athletics;
        //public int AnimalHandling;
        //blah blah
    }
    public class Skills
    {
        private readonly Player _player;
        public Skills(Player player)
        {
            _player = player;
        }
        public int Athletics
        {
            get
            {
                return _player.Stats.STR;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class BaseItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
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

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BaseStats
    {
        public byte STR { get; set; }
        public byte DEX { get; set; }
        public byte CON { get; set; }
        public byte INT { get; set; }
        public byte WIS { get; set; }
        public byte CHR { get; set; }
    }


    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NPC
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public BaseStats Stats { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public string Occupation { get; set; }
        public string Personality { get; set; }
        public string SocialClass { get; set; }
        public string Talents { get; set; }
        public string Ideals { get; set; }
        public string Age { get; set; }
        public string Goals { get; set; }
        public string Alignment { get; set; }
        public string Reason { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Apperance { get; set; }
        public string Fear { get; set; }
        public string Mannerisms { get; set; }
        public string Interaction { get; set; }
        public string Alignment_Ideal { get; set; }
        public int Old_AC { get; set; }
        public int Old_Preception { get; set; }
        public string Flaws { get; set; }
        public string Class { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Monster : SerializableObjectBase
    {

        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Alignment { get; set; }
        public string AC { get; set; }
        public string Speed { get; set; }
        public int HitDie { get; set; }
        public byte HitDieValue { get; set; }
        public string OldSkill { get; set; }
        public string OldSave { get; set; }
        public BaseStats Stats { get; set; } = new();
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
                return (Stats.WIS / 2 - 5 + 10 + ProfBonus);
            }
            return (Stats.WIS / 2 - 5 + 10);

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
           return (HitDieValue * (HitDie + 1) / 2 + HitDie * (Stats.CON / 2 - 5));
        }
        public int RandomHP()
        {
            int Output = 0;
            for (int i = 0; i < HitDie; i++)
            {
                Output += Table.RandomNumberSeeded(HitDieValue) + (Stats.CON / 2 - 5);
            }
            return Output;
        }
        public string HPFormula()
        {
            switch (Stats.CON)
            {
                case < 10: return (HitDie + "d" + HitDieValue + "-" + Stats.CON).ToString();
                case 10 or 11: return (HitDie + "d" + HitDieValue).ToString();
                case > 11: return (HitDie + "d" + HitDieValue + "+" + Stats.CON).ToString();
                default: 
            }
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Table : SerializableObjectBase
    {
        public string Name { get; set; }
        public List<TableItem> TableItems { get; set; }

        public static int TableTotalValue(Table _Table)
        {
            //Get total number of Values in a table
            int odds = 0;
            for (int i = 0; i < _Table.TableItems.Count; i++)
            {
                odds += _Table.TableItems[i].Value;
            }
            return odds;
        }
        // RandomNumberSeeded gets a seeded number for various objects seeded based on current millisec and throttles to make sure
        // that its a new seed each process so not repeating results.
        public static int RandomNumberSeeded(int DieValue)
        {
            Wait();
            //System.Threading.Thread.Sleep(1);
            Random random = new((int)DateTime.Now.Ticks & 0x0000FFFF);
            return random.Next(1, DieValue + 1);
        }
        private static void Wait()
        {
            int cTime = Convert.ToInt32(DateTime.Now.Ticks & 0x0000FFFF);
            do
            {
                System.Diagnostics.Debug.WriteLine(Convert.ToString(DateTime.Now.Ticks & 0x0000FFFF));
                System.Diagnostics.Debug.WriteLine(cTime.ToString());
            } while (cTime == Convert.ToInt32(DateTime.Now.Ticks & 0x0000FFFF));
        }
        public static int RandomNumberSeeded(Table _table)
        {
            Wait();
            Random random = new((int)DateTime.Now.Ticks & 0x0000FFFF);
            return random.Next(Table.TableTotalValue(_table));
        }
        public static string RunTable(List<Table> _TableList, Table _Table)
        {
            int r = RandomNumberSeeded(_Table);
            int compare = new();
            for (int i = 0; i < _Table.TableItems.Count; i++)
            {
                compare += _Table.TableItems[i].Value;
                if (r < compare)
                {
                    if (_Table.TableItems[i].IsTable == true)
                    {
                        string TableName = _Table.TableItems[i].Name;
                        for (int j = 0; j < _TableList.Count; j++)
                        {
                            if (_TableList[j].Name == TableName)
                            {
                                return RunTable(_TableList, _TableList[j]);
                            }
                        }
                    }
                    else
                    {
                        return _Table.TableItems[i].Name;
                    }
                }
            }
            return "Contact Developer"; //If this return ever shows up Figure out why.
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TableItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsTable { get; set; }
    }
    public partial class Guild
    {
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("Player")]
        public List<string> Players { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("NPC")]
        public List<string> NPCs { get; set; }
    }



}
