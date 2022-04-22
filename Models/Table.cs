using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public class Table : SerializableObjectBase
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
