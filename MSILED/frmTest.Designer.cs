namespace MSILED
{
    partial class frmTest
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_stylelist = new System.Windows.Forms.ComboBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.comboBox_mbname = new System.Windows.Forms.ComboBox();
            this.comboBox_ledlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog_getcolor = new System.Windows.Forms.ColorDialog();
            this.button_color = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox_cyclecolor = new System.Windows.Forms.ListBox();
            this.button_addcolor = new System.Windows.Forms.Button();
            this.button_startcycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "btnTest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // comboBox_stylelist
            // 
            this.comboBox_stylelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stylelist.FormattingEnabled = true;
            this.comboBox_stylelist.Location = new System.Drawing.Point(12, 179);
            this.comboBox_stylelist.Name = "comboBox_stylelist";
            this.comboBox_stylelist.Size = new System.Drawing.Size(272, 21);
            this.comboBox_stylelist.TabIndex = 2;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(398, 228);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 3;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // comboBox_mbname
            // 
            this.comboBox_mbname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mbname.FormattingEnabled = true;
            this.comboBox_mbname.Location = new System.Drawing.Point(12, 29);
            this.comboBox_mbname.Name = "comboBox_mbname";
            this.comboBox_mbname.Size = new System.Drawing.Size(337, 21);
            this.comboBox_mbname.TabIndex = 4;
            this.comboBox_mbname.SelectedIndexChanged += new System.EventHandler(this.comboBox_mbname_SelectedIndexChanged);
            // 
            // comboBox_ledlist
            // 
            this.comboBox_ledlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ledlist.FormattingEnabled = true;
            this.comboBox_ledlist.Location = new System.Drawing.Point(12, 86);
            this.comboBox_ledlist.Name = "comboBox_ledlist";
            this.comboBox_ledlist.Size = new System.Drawing.Size(177, 21);
            this.comboBox_ledlist.TabIndex = 5;
            this.comboBox_ledlist.SelectedIndexChanged += new System.EventHandler(this.comboBox_ledlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "LedID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Style";
            // 
            // colorDialog_getcolor
            // 
            this.colorDialog_getcolor.FullOpen = true;
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_color.Location = new System.Drawing.Point(12, 228);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(75, 23);
            this.button_color.TabIndex = 11;
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "btnColorList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnColorList_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "btnTestEnum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.btnTestEnum_Click);
            // 
            // listBox_cyclecolor
            // 
            this.listBox_cyclecolor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_cyclecolor.FormattingEnabled = true;
            this.listBox_cyclecolor.Location = new System.Drawing.Point(16, 288);
            this.listBox_cyclecolor.Name = "listBox_cyclecolor";
            this.listBox_cyclecolor.Size = new System.Drawing.Size(268, 212);
            this.listBox_cyclecolor.TabIndex = 15;
            this.listBox_cyclecolor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_cyclecolor_DrawItem);
            // 
            // button_addcolor
            // 
            this.button_addcolor.Location = new System.Drawing.Point(16, 259);
            this.button_addcolor.Name = "button_addcolor";
            this.button_addcolor.Size = new System.Drawing.Size(81, 23);
            this.button_addcolor.TabIndex = 16;
            this.button_addcolor.Text = "Add Color";
            this.button_addcolor.UseVisualStyleBackColor = true;
            this.button_addcolor.Click += new System.EventHandler(this.button_addcolor_Click);
            // 
            // button_startcycle
            // 
            this.button_startcycle.Location = new System.Drawing.Point(153, 259);
            this.button_startcycle.Name = "button_startcycle";
            this.button_startcycle.Size = new System.Drawing.Size(131, 23);
            this.button_startcycle.TabIndex = 17;
            this.button_startcycle.Text = "StartCycle";
            this.button_startcycle.UseVisualStyleBackColor = true;
            this.button_startcycle.Click += new System.EventHandler(this.button_startcycle_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 521);
            this.Controls.Add(this.button_startcycle);
            this.Controls.Add(this.button_addcolor);
            this.Controls.Add(this.listBox_cyclecolor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ledlist);
            this.Controls.Add(this.comboBox_mbname);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.comboBox_stylelist);
            this.Controls.Add(this.button2);
            this.Name = "frmTest";
            this.Text = "MSI RGB Control Test";
            this.Load += new System.EventHandler(this.Form_rgbcontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_stylelist;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.ComboBox comboBox_mbname;
        private System.Windows.Forms.ComboBox comboBox_ledlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog_getcolor;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox_cyclecolor;
        private System.Windows.Forms.Button button_addcolor;
        private System.Windows.Forms.Button button_startcycle;
    }
}

