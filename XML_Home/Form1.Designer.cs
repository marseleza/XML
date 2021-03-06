namespace XML_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.year_inst = new System.Windows.Forms.Label();
            this.type_inst = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudYear_of_origin = new System.Windows.Forms.NumericUpDown();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.name_inst = new System.Windows.Forms.Label();
            this.tbInstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvNames = new System.Windows.Forms.ListView();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear_of_origin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.year_inst);
            this.panel1.Controls.Add(this.type_inst);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.nudYear_of_origin);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.name_inst);
            this.panel1.Controls.Add(this.tbInstname);
            this.panel1.Location = new System.Drawing.Point(273, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 360);
            this.panel1.TabIndex = 0;
            // 
            // year_inst
            // 
            this.year_inst.AutoSize = true;
            this.year_inst.Location = new System.Drawing.Point(65, 228);
            this.year_inst.Name = "year_inst";
            this.year_inst.Size = new System.Drawing.Size(244, 17);
            this.year_inst.TabIndex = 5;
            this.year_inst.Text = "Popularity from zero to one hundread";
            // 
            // type_inst
            // 
            this.type_inst.AutoSize = true;
            this.type_inst.Location = new System.Drawing.Point(65, 125);
            this.type_inst.Name = "type_inst";
            this.type_inst.Size = new System.Drawing.Size(40, 17);
            this.type_inst.TabIndex = 4;
            this.type_inst.Text = "Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(389, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudYear_of_origin
            // 
            this.nudYear_of_origin.Location = new System.Drawing.Point(68, 248);
            this.nudYear_of_origin.Name = "nudYear_of_origin";
            this.nudYear_of_origin.Size = new System.Drawing.Size(396, 22);
            this.nudYear_of_origin.TabIndex = 2;
            this.nudYear_of_origin.ValueChanged += new System.EventHandler(this.nudYear_of_origin_ValueChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "-- Choose type--",
            "Strings",
            "Keyboards",
            "Percussion",
            "Wind instruments"});
            this.cmbType.Location = new System.Drawing.Point(68, 145);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(396, 24);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // name_inst
            // 
            this.name_inst.AutoSize = true;
            this.name_inst.Location = new System.Drawing.Point(65, 34);
            this.name_inst.Name = "name_inst";
            this.name_inst.Size = new System.Drawing.Size(45, 17);
            this.name_inst.TabIndex = 3;
            this.name_inst.Text = "Name";
            this.name_inst.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbInstname
            // 
            this.tbInstname.Location = new System.Drawing.Point(68, 54);
            this.tbInstname.Name = "tbInstname";
            this.tbInstname.Size = new System.Drawing.Size(396, 22);
            this.tbInstname.TabIndex = 0;
            this.tbInstname.TextChanged += new System.EventHandler(this.tbInstname_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Names";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Information";
            // 
            // lvNames
            // 
            this.lvNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNames.BackgroundImageTiled = true;
            this.lvNames.HideSelection = false;
            this.lvNames.Location = new System.Drawing.Point(12, 39);
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(255, 408);
            this.lvNames.TabIndex = 4;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.SelectedIndexChanged += new System.EventHandler(this.lwNames_SelectedIndexChanged);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(421, 3);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(88, 39);
            this.btnSerialize.TabIndex = 4;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(301, 3);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(88, 39);
            this.btnDeserialize.TabIndex = 4;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSerialize);
            this.panel2.Controls.Add(this.btnDeserialize);
            this.panel2.Location = new System.Drawing.Point(273, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 45);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "XML";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear_of_origin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label year_inst;
        private System.Windows.Forms.Label type_inst;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudYear_of_origin;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label name_inst;
        private System.Windows.Forms.TextBox tbInstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvNames;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Panel panel2;
    }
}

