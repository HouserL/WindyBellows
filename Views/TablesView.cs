using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindyBellows.Views;

public partial class TablesView : UserControl
{
    private List<Table> _tables = new();

    public List<Table> Tables
    {
        get { return _tables; }
        set { _tables = value; }
    }

    public TablesView()
    {
        InitializeComponent();
    }



    public void LoadData()
    {
        try
        {
            TextBoxTableName.Text = _tables[0].Name;
            DataGridView1.DataSource = _tables[0].TableItems;
            LoadList(0);
        }
        catch (Exception)
        {

            //throw;
        }

    }
    private void LoadList(int index)
    {
        ListBoxTables.Items.Clear();
        for (int i = 0; i < _tables.Count; i++)
        {
            ListBoxTables.Items.Add(_tables[i].Name);
        }
        ListBoxTables.SelectedIndex = index;
    }
    private void ListBoxTables_SelectedIndexChanged(object sender, EventArgs e)
    {
        int inttotal = 0;
        for (int i = 0; i < _tables[ListBoxTables.SelectedIndex].TableItems.Count; i++)
        {
            inttotal += _tables[ListBoxTables.SelectedIndex].TableItems[i].Value;
        }
        DataGridView1.DataSource = _tables[ListBoxTables.SelectedIndex].TableItems;
        TextBoxTableName.Text = _tables[ListBoxTables.SelectedIndex].Name;
        label2.Text = "Total number of chances in table is x out of " + inttotal;
    }
    private void EditName_CheckedChanged(object sender, EventArgs e)
    {
        if (EditName.Checked) TextBoxTableName.ReadOnly = false; 
        else TextBoxTableName.ReadOnly = true;
    }
    private void RichTextBoxResults_ContentsResized(object sender, ContentsResizedEventArgs e)
    {
        // use this to resize richtext boxs with word wrap to just increase length
        const int margin = 5;
        RichTextBox rch = sender as RichTextBox;
        rch.ClientSize = new Size(
          e.NewRectangle.Width + margin,
        e.NewRectangle.Height + margin);

    }

    private void AddNewTable_Click(object sender, EventArgs e)
    {
        NewTable();
    }

    private void NewTable()
    {
        Table _newTable = new();
        _newTable.TableItems = new List<TableItem>();
        EditName.Checked = true;
        TextBoxTableName.Text = "Table Name";
        DataGridView1.DataSource = _newTable.TableItems;
        DataGridView1.AutoGenerateColumns = false;
        DataGridView1.DataSource = null;
        DataGridView1.Rows.Add();

    }
    private void SaveTable_Click(object sender, EventArgs e)
    {
        Table _newTable = new();

        _newTable.TableItems = new List<TableItem>();

        _newTable.Name = TextBoxTableName.Text;
        for (int i = 0; i < DataGridView1.Rows.Count; i++)
        {
            TableItem _newtableitem = new();
            _newtableitem.Name = DataGridView1.Rows[i].Cells[0].Value.ToString();
            _newtableitem.Value = Convert.ToInt32(DataGridView1.Rows[i].Cells[1].Value.ToString());
            if (DataGridView1.Rows[i].Cells[2].Value == null)
            {
                _newtableitem.IsTable = false;
            }
            else
            {
                _newtableitem.IsTable = Convert.ToBoolean(DataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            _newTable.TableItems.Add(_newtableitem);
            EditName.Checked = false;

        }
        for (int i = 0; i < _tables.Count; i++)
        {
            if (_tables[i].Name == TextBoxTableName.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Table with this name already exists do you want to Update that table?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _tables.RemoveAt(i);
                    _tables.Insert(i, _newTable);
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        _tables.Add(_newTable);
        ListBoxTables.Items.Clear();
        for (int i = 0; i < _tables.Count; i++)
        {
            ListBoxTables.Items.Add(_tables[i].Name);
        }
        DataGridView1.DataSource = _tables[^1].TableItems;
        ListBoxTables.SelectedIndex = ListBoxTables.Items.Count - 1;
    }
    private void AddRow_Click(object sender, EventArgs e)
    {
        if (DataGridView1.DataSource == null)
        {
            DataGridView1.Rows.Add();
        }
        else
        {
            _tables[ListBoxTables.SelectedIndex].TableItems.Add(new TableItem());
            int x = ListBoxTables.SelectedIndex;
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = _tables[x].TableItems;
        }
    }
    private void RemoveRow_Click(object sender, EventArgs e)
    {
        if (DataGridView1.DataSource == null)
        {
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex);
        }
        else
        {

            _tables[ListBoxTables.SelectedIndex].TableItems.RemoveAt(DataGridView1.CurrentCell.RowIndex);
            int x = ListBoxTables.SelectedIndex;
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = _tables[x].TableItems;

        }
    }
    private void TestTable_Click(object sender, EventArgs e)
    {
        RichTextBoxResults.Text = null;
        try
        {
            for (int i = 0; i < Convert.ToInt16(TextBoxTestNumber.Text.ToString()); i++) //Run Table for x times based on text box.
            {
                RichTextBoxResults.Text += Table.RunTable(_tables, _tables[ListBoxTables.SelectedIndex]) + " ";
            }
        }
        catch (Exception)
        {
            return;
        }
    }
    private void TextBoxTestNumber_Leave(object sender, EventArgs e)
    {
        try
        {
            int i = Convert.ToInt32(TextBoxTableName.Text.ToString());
        }
        catch (Exception)
        {
            TextBoxTableName.Text = null;
            return;
        }
    }

    private void RemoveTable_Click(object sender, EventArgs e)
    {
        _tables.RemoveAt(ListBoxTables.SelectedIndex);
        LoadList(ListBoxTables.SelectedIndex);

    }

    private void MoveUp_Click(object sender, EventArgs e)
    {
        if (ListBoxTables.SelectedIndex != 0)
        {
            Table tempTable = _tables[ListBoxTables.SelectedIndex] as Table;
            _tables.RemoveAt(ListBoxTables.SelectedIndex);
            _tables.Insert(ListBoxTables.SelectedIndex - 1, tempTable);
            LoadList(ListBoxTables.SelectedIndex - 1);
        }
    }

    private void MoveDown_Click(object sender, EventArgs e)
    {
        if (ListBoxTables.SelectedIndex != ListBoxTables.Items.Count - 1)
        {
            Table tempTable = _tables[ListBoxTables.SelectedIndex] as Table;
            _tables.RemoveAt(ListBoxTables.SelectedIndex);
            _tables.Insert(ListBoxTables.SelectedIndex + 1, tempTable);
            LoadList(ListBoxTables.SelectedIndex + 1);
        }
    }
}
