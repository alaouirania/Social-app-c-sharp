namespace testDB
{
    partial class Groups
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
            this.eventPlace = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.x = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.eventPlace);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.x);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.g);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.create);
            this.panel3.Controls.Add(this.group);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.eventName);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 338);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // eventPlace
            // 
            this.eventPlace.Location = new System.Drawing.Point(199, 234);
            this.eventPlace.Multiline = true;
            this.eventPlace.Name = "eventPlace";
            this.eventPlace.Size = new System.Drawing.Size(213, 23);
            this.eventPlace.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 176);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 33;
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
            // group
            // 
            this.group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group.AutoSize = true;
            this.group.BackColor = System.Drawing.Color.Black;
            this.group.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.group.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.ForeColor = System.Drawing.SystemColors.Control;
            this.group.Location = new System.Drawing.Point(2, 0);
            this.group.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(55, 21);
            this.group.TabIndex = 25;
            this.group.Text = "Events";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(113, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(113, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "Place";
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
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(199, 115);
            this.eventName.Multiline = true;
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(213, 23);
            this.eventName.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(42, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 19);
            this.label19.TabIndex = 18;
            this.label19.Text = "Create an event...";
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 335);
            this.Controls.Add(this.panel3);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
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
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox eventPlace;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}