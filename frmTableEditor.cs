using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindyBellows
{
    public partial class TableEditor : Form
    {
        //public TableBase _table;
        public TableEditor()
        {
            InitializeComponent();
        }
        private void FrmTableEditor_Load(object sender, EventArgs e)
        {
            //_table = SerializableObjectBase.FromFile<TableBase>(@"C:\Program Files (x86)\Compendium\Table.xml");
            textBox1.Text = FrmMain._comp.Tables[0].Name;
            dataGridView1.DataSource = FrmMain._comp.Tables[0].TableItems;
            LoadList(0);
        }

        private void LoadList(int index)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < FrmMain._comp.Tables.Count; i++)
            {
                listBox1.Items.Add(FrmMain._comp.Tables[i].Name);
            }
            listBox1.SelectedIndex = index;
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inttotal = 0;
            for (int i = 0; i < FrmMain._comp.Tables[listBox1.SelectedIndex].TableItems.Count; i++)
            {
                inttotal += FrmMain._comp.Tables[listBox1.SelectedIndex].TableItems[i].Value;
            }
            dataGridView1.DataSource = FrmMain._comp.Tables[listBox1.SelectedIndex].TableItems;
            textBox1.Text = FrmMain._comp.Tables[listBox1.SelectedIndex].Name;
            label2.Text = "Total number of chances in table is x out of " + inttotal;
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox1.ReadOnly = false; }
            else { textBox1.ReadOnly = true; }
        }
        private void RichTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            // use this to resize richtext boxs with word wrap to just increase length
            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
              e.NewRectangle.Width + margin,
            e.NewRectangle.Height + margin);

        }

        private void BtnNewTable_Click(object sender, EventArgs e)
        {
            NewTable();
        }

        private void NewTable()
        {
            Table _newTable = new();
            _newTable.TableItems = new List<TableItem>();
            checkBox1.Checked = true;
            textBox1.Text = "Table Name";
            dataGridView1.DataSource = _newTable.TableItems;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add();

        }
        private void BtnSaveTable_Click(object sender, EventArgs e)
        {
            Table _newTable = new();

            _newTable.TableItems = new List<TableItem>();

            _newTable.Name = textBox1.Text;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TableItem _newtableitem = new();
                _newtableitem.Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                _newtableitem.Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
                if (dataGridView1.Rows[i].Cells[2].Value == null)
                {
                    _newtableitem.IsTable = false;
                }
                else
                {
                    _newtableitem.IsTable = Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                _newTable.TableItems.Add(_newtableitem);
                checkBox1.Checked = false;

            }
            for (int i = 0; i < FrmMain._comp.Tables.Count; i++)
            {
                if (FrmMain._comp.Tables[i].Name == textBox1.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Table with this name already exists do you want to Update that table?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FrmMain._comp.Tables.RemoveAt(i);
                        FrmMain._comp.Tables.Insert(i, _newTable);
                        return;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            FrmMain._comp.Tables.Add(_newTable);
            listBox1.Items.Clear();
            for (int i = 0; i < FrmMain._comp.Tables.Count; i++)
            {
                listBox1.Items.Add(FrmMain._comp.Tables[i].Name);
            }
            dataGridView1.DataSource = FrmMain._comp.Tables[^1].TableItems;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                dataGridView1.Rows.Add();
            }
            else
            {
                FrmMain._comp.Tables[listBox1.SelectedIndex].TableItems.Add(new TableItem());
                int x = listBox1.SelectedIndex;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FrmMain._comp.Tables[x].TableItems;
            }
        }
        private void BtnRemoveRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            else
            {

                FrmMain._comp.Tables[listBox1.SelectedIndex].TableItems.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                int x = listBox1.SelectedIndex;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FrmMain._comp.Tables[x].TableItems;

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            try
            {
                for (int i = 0; i < Convert.ToInt16(textBox2.Text.ToString()); i++) //Run Table for x times based on text box.
                {
                    richTextBox1.Text += Table.RunTable(FrmMain._comp.Tables, FrmMain._comp.Tables[listBox1.SelectedIndex]) + " ";
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void TextBox2Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox2.Text.ToString());
            }
            catch (Exception)
            {
                textBox2.Text = null;
                return;
            }
        }

        private void BtnRemoveTable_Click(object sender, EventArgs e)
        {
            FrmMain._comp.Tables.RemoveAt(listBox1.SelectedIndex);
            LoadList(listBox1.SelectedIndex);

        }

        private void BtnTableUp_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
                Table tempTable = FrmMain._comp.Tables[listBox1.SelectedIndex] as Table;
                FrmMain._comp.Tables.RemoveAt(listBox1.SelectedIndex);
                FrmMain._comp.Tables.Insert(listBox1.SelectedIndex - 1, tempTable);
                LoadList(listBox1.SelectedIndex - 1);
            }
        }

        private void BtnTableDown_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                Table tempTable = FrmMain._comp.Tables[listBox1.SelectedIndex] as Table;
                FrmMain._comp.Tables.RemoveAt(listBox1.SelectedIndex);
                FrmMain._comp.Tables.Insert(listBox1.SelectedIndex + 1, tempTable);
                LoadList(listBox1.SelectedIndex + 1);
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
