using OSIsoft.AF;
using OSIsoft.AF.Asset;
using System.Windows.Forms;
using System.Linq;
using OSIsoft.AF.UnitsOfMeasure;
using OSIsoft.AF.Time;
using OSIsoft.AF.Data;
using System;

namespace Extract_Elements_Attributes_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // connect the system picker to the database picker
            afDatabasePicker1.SystemPicker = piSystemPicker1;
        }

        private void afDatabasePicker1_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            // get the database
            AFDatabase db = afDatabasePicker1.AFDatabase;

            //Clear the treeview
            afTreeView1.AFRoot = null;

            // if database exist then get elements into af tree view
            if (db != null)
            {
                // set the root of the tree-view
                afTreeView1.AFRoot = db.Elements;
            }
        }

        private void afTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // get the selected element that is in the list box elements
            AFElement selectedElement = afTreeView1.AFSelection as AFElement;

            // clear the list box that contains attributes
            lbAttributes.Items.Clear();

            // check if selected attributes exist
            if (selectedElement != null)
            {
                lbAttributes.Items.AddRange(selectedElement.Attributes.ToArray<AFAttribute>());
            }
        }

        private void lbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            lbValuesAll.Items.Clear();
            foreach (var item in lbAttributes.SelectedItems)
            {
                lbValuesAll.Items.Add(item.ToString());
            }

            //Clear the ComboBox
            cbUOM.Items.Clear();
            cbUOM.Text = null;

            //If no attribute is selected, ball
            if (selectedAttribute == null || selectedAttribute.DefaultUOM == null) return;

            //Find the class of UOM that interest us
            UOMClass selectedUOMClass = selectedAttribute.DefaultUOM.Class;

            //Populate the combobox
            cbUOM.Items.AddRange(selectedUOMClass.UOMs.ToArray());

            //Select the default UOM, since we're benevolent people
            cbUOM.SelectedItem = selectedAttribute.DefaultUOM;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //Get data for the selected attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Get some AFTime objects
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            // Make the data call
            UOM desiredUOM = cbUOM.SelectedItem as UOM;

            AFValues values = new AFValues();

            switch (cbDataMethod.Text)
            {
                case "Recorded Values":
                    //Check if it support HasFlag
                    if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.RecordedValues))
                    {
                        values = selectedAttribute.Data.RecordedValues(timeRange
                                                              , AFBoundaryType.Interpolated
                                                              , desiredUOM
                                                              , null
                                                              , true);
                    }
                    break;
                case "Interpolated Values":
                    if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.InterpolatedValues))
                    {
                        values = selectedAttribute.Data.InterpolatedValues(timeRange
                                                          , AFTimeSpan.Parse("5m")  //Hard code a 5min time step here
                                                          , desiredUOM
                                                          , null
                                                          , true);
                    }
                    break;
                case "Plot Values":
                    if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.PlotValues))
                    {
                        values = selectedAttribute.Data.PlotValues(timeRange
                                                          , 300  // Hard code a 300px plot width here
                                                          , desiredUOM);
                    }
                    break;
                default:
                    values = new AFValues();
                    break;
            }

            //populate the valuse in listbox
            lbValues.Items.Clear();
            foreach (AFValue value in values)
            {
                string s = String.Format("{0} \t {1} {2}"
                                         , value.Timestamp.LocalTime
                                         , value.Value
                                         , value.UOM != null ? value.UOM.Abbreviation : null);
                lbValues.Items.Add(s);
            }

        }

        private void btPutTxt_Click(object sender, EventArgs e)
        {
            // get selected item as attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            const string sPath = "save.txt";
            
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);

            // add some parameters
            SaveFile.WriteLine("Database; Element; Attribute");
            SaveFile.WriteLine("{0}; {1}; {2}", selectedAttribute.Database, selectedAttribute.Element, lbAttributes.SelectedItem);
            SaveFile.WriteLine("Timestamp; Value; UOM ");

            foreach (var item in lbValues.Items)
            {
                SaveFile.WriteLine(item.ToString().Replace(" 	 ", "; "));
            }

            SaveFile.ToString();
            SaveFile.Close();

            MessageBox.Show("Programs saved!");
        }
    }
}
