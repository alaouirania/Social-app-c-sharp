namespace testDB
{
    partial class EventForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.x = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpMembers = new System.Windows.Forms.ComboBox();
            this.grpCategory = new System.Windows.Forms.ComboBox();
            this.grpName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.x);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.g);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.create);
            this.panel3.Controls.Add(this.Event);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.grpMembers);
            this.panel3.Controls.Add(this.grpCategory);
            this.panel3.Controls.Add(this.grpName);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 338);
            this.panel3.TabIndex = 41;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.SystemColors.Desktop;
            this.x.Location = new System.Drawing.Point(149, 292);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(0, 19);
            this.x.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(266, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 22);
            this.label18.TabIndex = 30;
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.SystemColors.Desktop;
            this.g.Location = new System.Drawing.Point(266, 168);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(0, 22);
            this.g.TabIndex = 29;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button6.Location = new System.Drawing.Point(2, 308);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 27);
            this.button6.TabIndex = 28;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.LightSkyBlue;
            this.create.Location = new System.Drawing.Point(405, 306);
            this.create.Margin = new System.Windows.Forms.Padding(2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(83, 27);
            this.create.TabIndex = 27;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Event
            // 
            this.Event.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Event.AutoSize = true;
            this.Event.BackColor = System.Drawing.Color.Black;
            this.Event.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Event.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.ForeColor = System.Drawing.SystemColors.Control;
            this.Event.Location = new System.Drawing.Point(2, 0);
            this.Event.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(59, 21);
            this.Event.TabIndex = 25;
            this.Event.Text = "Groups";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(113, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "Category";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(113, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "Members";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(113, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 19);
            this.label17.TabIndex = 22;
            this.label17.Text = "Name";
            // 
            // grpMembers
            // 
            this.grpMembers.FormattingEnabled = true;
            this.grpMembers.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "100",
            "200"});
            this.grpMembers.Location = new System.Drawing.Point(199, 236);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(213, 21);
            this.grpMembers.TabIndex = 21;
            // 
            // grpCategory
            // 
            this.grpCategory.FormattingEnabled = true;
            this.grpCategory.Items.AddRange(new object[] {
            "Art",
            "Business",
            "Chill",
            "Cultures",
            "Creativity",
            "Design",
            "Languages",
            "Movies",
            "Shows",
            ""});
            this.grpCategory.Location = new System.Drawing.Point(199, 174);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(213, 21);
            this.grpCategory.TabIndex = 20;
            // 
            // grpName
            // 
            this.grpName.Location = new System.Drawing.Point(199, 115);
            this.grpName.Multiline = true;
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(213, 23);
            this.grpName.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(43, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 19);
            this.label19.TabIndex = 18;
            this.label19.Text = "Create a group...";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 339);
            this.Controls.Add(this.panel3);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox grpMembers;
        private System.Windows.Forms.ComboBox grpCategory;
        private System.Windows.Forms.TextBox grpName;
        private System.Windows.Forms.Label label19;
    }
}