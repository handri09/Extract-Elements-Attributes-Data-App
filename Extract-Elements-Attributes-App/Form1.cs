using System.Windows.Forms;

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
    }
}
