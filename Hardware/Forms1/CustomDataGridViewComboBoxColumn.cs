using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

public class CustomDataGridViewComboBoxColumn : DataGridViewComboBoxColumn
{
    public CustomDataGridViewComboBoxColumn()
    {
        CellTemplate = new CustomDataGridViewComboBoxCell();
    }

    public override object Clone()
    {
        CustomDataGridViewComboBoxColumn clone = (CustomDataGridViewComboBoxColumn)base.Clone();
        clone.CellTemplate = (CustomDataGridViewComboBoxCell)this.CellTemplate.Clone();
        return clone;
    }
}
