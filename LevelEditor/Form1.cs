using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel _characterTable;
        private TableLayoutPanel _colorTable;
        private TableLayoutPanel _moveableTable;
        private TableLayoutPanel _passableTable;

        public Form1()
        {
            InitializeComponent();
        }

        private TableLayoutPanel CreateTextboxTable(int width, int height)
        {
            var table = new TableLayoutPanel();
            table.ColumnCount = width;
            table.RowCount = height;

            for (int i = 0; i < width; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / width));
                for (int j = 0; j < height; j++)
                {
                    var textBox = new TextBox();
                    textBox.Name = "_textbox";
                    table.Controls.Add(textBox, i, j);

                    textBox.Parent = table;
                    textBox.Location = new Point(3, 3);
                    textBox.Dock = DockStyle.Fill;
                    textBox.TextChanged += CharacterChanged;
                }
            }
            for (int j = 0; j < height; j++)
            {
                table.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 100 / height));
            }

            table.Dock = DockStyle.Fill;
            table.Name = "levelGrid";
            table.TabIndex = 0;

            return table;
        }

        private TableLayoutPanel CreateCheckboxTable(int width, int height)
        {
            var table = new TableLayoutPanel();
            table.ColumnCount = width;
            table.RowCount = height;

            for (int i = 0; i < width; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / width));
                for (int j = 0; j < height; j++)
                {
                    var checkbox = new CheckBox();
                    checkbox.Name = "_checkbox";
                    table.Controls.Add(checkbox, i, j);

                    checkbox.Parent = table;
                    checkbox.Location = new Point(3, 3);
                    checkbox.Dock = DockStyle.Fill;
                }
            }
            for (int j = 0; j < height; j++)
            {
                table.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 100 / height));
            }

            table.Dock = DockStyle.Fill;
            table.Name = "levelGrid";
            table.TabIndex = 0;

            return table;
        }

        private void ClickResize(object sender, System.EventArgs e)
        {
            var width = int.Parse(levelWidth.Text);
            var height = int.Parse(levelHeight.Text);

            this.tabControl.TabPages[0].Controls.Clear();
            this.tabControl.TabPages[1].Controls.Clear();
            this.tabControl.TabPages[2].Controls.Clear();
            this.tabControl.TabPages[3].Controls.Clear();

            _characterTable = CreateTextboxTable(width, height);
            _colorTable = CreateTextboxTable(width, height);
            _moveableTable = CreateCheckboxTable(width, height);
            _passableTable = CreateCheckboxTable(width, height);

            this.tabControl.TabPages[0].Controls.Add(_characterTable);
            this.tabControl.TabPages[1].Controls.Add(_colorTable);
            this.tabControl.TabPages[2].Controls.Add(_moveableTable);
            this.tabControl.TabPages[3].Controls.Add(_passableTable);
        }

        private void CharacterChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            var text = textBox.Text;
            var cellPosition = _characterTable.GetCellPosition(textBox);

            var label = GetControlAt<Label>(_colorTable, cellPosition.Column, cellPosition.Row);
            if(label != null)
            {
                label.Text = text;
            }
            else
            {
                label = new Label();
                label.Text = text;
                _colorTable.Controls.Add(label, cellPosition.Column, cellPosition.Row);
            }
        }

        private static T GetControlAt<T>(TableLayoutPanel panel, int column, int row) where T : Control
        {
            foreach (Control control in panel.Controls)
            {
                if (!(control is T)) continue;
                var cellPosition = panel.GetCellPosition(control);
                if(cellPosition.Column == column && cellPosition.Row == row)
                {
                    return control as T;
                }
            }
            return null;
        }
    }
}
