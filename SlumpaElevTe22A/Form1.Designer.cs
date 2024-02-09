namespace SlumpaElev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { resources.GetString("checkedListBox1.Items"), resources.GetString("checkedListBox1.Items1"), resources.GetString("checkedListBox1.Items2"), resources.GetString("checkedListBox1.Items3"), resources.GetString("checkedListBox1.Items4"), resources.GetString("checkedListBox1.Items5"), resources.GetString("checkedListBox1.Items6"), resources.GetString("checkedListBox1.Items7"), resources.GetString("checkedListBox1.Items8"), resources.GetString("checkedListBox1.Items9") });
            resources.ApplyResources(checkedListBox1, "checkedListBox1");
            checkedListBox1.Name = "checkedListBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}
