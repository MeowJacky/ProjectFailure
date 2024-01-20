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

public class CustomDataGridViewComboBoxCell : DataGridViewComboBoxCell
{
    //public override object Clone()
    //{
    //    CustomDataGridViewComboBoxCell clone = (CustomDataGridViewComboBoxCell)base.Clone();
    //    clone.ComboBox = (ComboBox)this.ComboBox.Clone();
    //    return clone;
    //}
}
