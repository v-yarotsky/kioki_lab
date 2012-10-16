using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptographyTemplate
{
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();
        }

        private int[][] indices;
        private int requiredCellsCount;
        private int selectedCellsCount;
        private int size = 4;
        private CheckBox[][] cells;

        public bool[,] GetGrid()
        {
            bool[,] selectedCellsCount = new bool[size, size];
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    selectedCellsCount[i, j] = cells[i][j].Checked;
                }
            }
            return selectedCellsCount;
        }

        private void CreateIndexMatrix()
        {
            indices = new int[size][];
            for (var i = 0; i < size; i++)
            {
                indices[i] = new int[size];
            }

            var currentIndex = 1;
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (indices[i][j] == 0)
                    {
                        indices[i][j] = currentIndex;
                        indices[j][size - 1 - i] = currentIndex;
                        indices[size - 1 - i][size - 1 - j] = currentIndex;
                        indices[size - 1 - j][i] = currentIndex;
                        currentIndex++;
                    }
                }
            }
            requiredCellsCount = currentIndex - 1 - (size % 2 == 0 ? 0 : 1);
            selectedCellsCount = 0;
        }

        protected void CreateGrille()
        {
            this.CreateIndexMatrix();
            var cellSize = (float)100 / size;

            gridLayout.SuspendLayout();
            gridLayout.RowStyles.Clear();
            gridLayout.ColumnStyles.Clear();
            gridLayout.Controls.Clear();

            gridLayout.RowCount = size;
            gridLayout.ColumnCount = size;
            
            cells = new CheckBox[size][];
            for (var i = 0; i < size; i++)
            {
                gridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, cellSize));
                cells[i] = new CheckBox[size];

                for (var j = 0; j < size; j++)
                {
                    cells[i][j] = new CheckBox()
                    {
                        Anchor = AnchorStyles.None,
                        Dock = DockStyle.Fill,
                        CheckAlign = ContentAlignment.MiddleCenter,
                        Text = indices[i][j].ToString(),
                        TextAlign = ContentAlignment.TopCenter,
                        Enabled = !(size % 2 == 1 && i == (size / 2) && i == j)
                    };
                    cells[i][j].Click += CellClick;
                    gridLayout.Controls.Add(cells[i][j], j, i);
                    gridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, cellSize));
                }
            }
            gridLayout.ResumeLayout(true);
        }

        private void CellClick(Object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
            var index = Int32.Parse(checkbox.Text);

            if (checkbox.Checked)
                selectedCellsCount++;
            else
                selectedCellsCount--;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (indices[i][j] == index && cells[i][j] != checkbox)
                    {
                        cells[i][j].Enabled = !checkbox.Checked;
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (selectedCellsCount != requiredCellsCount)
            {
                MessageBox.Show("Выберите отверстия");
                this.DialogResult = DialogResult.None;
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void gridSizeSpinBox_ValueChanged(object sender, EventArgs e)
        {
            this.size = (int)((NumericUpDown)sender).Value;
            CreateGrille();
        }

        private void GridForm_Shown(object sender, EventArgs e)
        {
            gridSizeSpinBox.Value = size;
            CreateGrille();
        }

    }
}
