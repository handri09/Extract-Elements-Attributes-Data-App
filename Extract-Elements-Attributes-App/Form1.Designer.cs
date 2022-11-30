namespace Extract_Elements_Attributes_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afTreeView1 = new OSIsoft.AF.UI.AFTreeView();
            this.lbAttributes = new System.Windows.Forms.ListBox();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.cbDataMethod = new System.Windows.Forms.ComboBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.lbValuesAll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI System Picker";
            this.piSystemPicker1.AccessibleName = "PI System Picker";
            this.piSystemPicker1.ConnectAutomatically = true;
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.Location = new System.Drawing.Point(12, 12);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowDelete = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNew = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.ShowProperties = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(388, 22);
            this.piSystemPicker1.TabIndex = 1;
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "Database Picker";
            this.afDatabasePicker1.AccessibleName = "Database Picker";
            this.afDatabasePicker1.Location = new System.Drawing.Point(12, 40);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowList = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(388, 22);
            this.afDatabasePicker1.TabIndex = 2;
            this.afDatabasePicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker1_SelectionChange);
            // 
            // afTreeView1
            // 
            this.afTreeView1.HideSelection = false;
            this.afTreeView1.ItemHeight = 16;
            this.afTreeView1.Location = new System.Drawing.Point(12, 68);
            this.afTreeView1.Name = "afTreeView1";
            this.afTreeView1.ShowNodeToolTips = true;
            this.afTreeView1.Size = new System.Drawing.Size(217, 381);
            this.afTreeView1.TabIndex = 3;
            this.afTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView1_AfterSelect);
            // 
            // lbAttributes
            // 
            this.lbAttributes.FormattingEnabled = true;
            this.lbAttributes.Location = new System.Drawing.Point(235, 68);
            this.lbAttributes.Name = "lbAttributes";
            this.lbAttributes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAttributes.Size = new System.Drawing.Size(165, 381);
            this.lbAttributes.TabIndex = 4;
            this.lbAttributes.SelectedIndexChanged += new System.EventHandler(this.lbAttributes_SelectedIndexChanged);
            // 
            // cbUOM
            // 
            this.cbUOM.DisplayMember = "Abbreviation";
            this.cbUOM.FormattingEnabled = true;
            this.cbUOM.Location = new System.Drawing.Point(565, 14);
            this.cbUOM.Name = "cbUOM";
            this.cbUOM.Size = new System.Drawing.Size(109, 21);
            this.cbUOM.TabIndex = 10;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(486, 14);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(70, 20);
            this.tbEndTime.TabIndex = 8;
            this.tbEndTime.Text = "*";
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(407, 14);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(73, 20);
            this.tbStartTime.TabIndex = 9;
            this.tbStartTime.Text = "*-3h";
            // 
            // cbDataMethod
            // 
            this.cbDataMethod.FormattingEnabled = true;
            this.cbDataMethod.Items.AddRange(new object[] {
            "Recorded Values",
            "Interpolated Values",
            "Plot Value"});
            this.cbDataMethod.Location = new System.Drawing.Point(681, 14);
            this.cbDataMethod.Name = "cbDataMethod";
            this.cbDataMethod.Size = new System.Drawing.Size(143, 21);
            this.cbDataMethod.TabIndex = 11;
            this.cbDataMethod.Text = "Recorded Values";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(830, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(155, 23);
            this.btnGetData.TabIndex = 12;
            this.btnGetData.Text = "Get Data!";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lbValues
            // 
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(406, 42);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(268, 407);
            this.lbValues.TabIndex = 13;
            // 
            // lbValuesAll
            // 
            this.lbValuesAll.FormattingEnabled = true;
            this.lbValuesAll.Location = new System.Drawing.Point(680, 42);
            this.lbValuesAll.Name = "lbValuesAll";
            this.lbValuesAll.Size = new System.Drawing.Size(305, 407);
            this.lbValuesAll.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 455);
            this.Controls.Add(this.lbValuesAll);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.cbDataMethod);
            this.Controls.Add(this.cbUOM);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.lbAttributes);
            this.Controls.Add(this.afTreeView1);
            this.Controls.Add(this.afDatabasePicker1);
            this.Controls.Add(this.piSystemPicker1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extract Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private OSIsoft.AF.UI.AFTreeView afTreeView1;
        private System.Windows.Forms.ListBox lbAttributes;
        private System.Windows.Forms.ComboBox cbUOM;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.ComboBox cbDataMethod;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ListBox lbValues;
        private System.Windows.Forms.ListBox lbValuesAll;
    }
}

