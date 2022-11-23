using OSIsoft.AF;
using OSIsoft.AF.Asset;
using System.Windows.Forms;
using System.Linq;


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
    }
}
