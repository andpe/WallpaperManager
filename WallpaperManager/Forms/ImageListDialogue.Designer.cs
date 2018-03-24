namespace WallpaperManager.Forms
{
    partial class ImageListDialogue
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("TestPath1");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("TestPath2");
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteList = new System.Windows.Forms.Button();
            this.buttonSaveAsList = new System.Windows.Forms.Button();
            this.buttonRenameList = new System.Windows.Forms.Button();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(493, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteList);
            this.groupBox1.Controls.Add(this.buttonSaveAsList);
            this.groupBox1.Controls.Add(this.buttonRenameList);
            this.groupBox1.Controls.Add(this.buttonNewList);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(872, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profiles";
            // 
            // buttonDeleteList
            // 
            this.buttonDeleteList.Location = new System.Drawing.Point(781, 26);
            this.buttonDeleteList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteList.Name = "buttonDeleteList";
            this.buttonDeleteList.Size = new System.Drawing.Size(84, 29);
            this.buttonDeleteList.TabIndex = 4;
            this.buttonDeleteList.Text = "Delete";
            this.buttonDeleteList.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAsList
            // 
            this.buttonSaveAsList.Location = new System.Drawing.Point(690, 26);
            this.buttonSaveAsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveAsList.Name = "buttonSaveAsList";
            this.buttonSaveAsList.Size = new System.Drawing.Size(84, 29);
            this.buttonSaveAsList.TabIndex = 3;
            this.buttonSaveAsList.Text = "Save as";
            this.buttonSaveAsList.UseVisualStyleBackColor = true;
            // 
            // buttonRenameList
            // 
            this.buttonRenameList.Location = new System.Drawing.Point(598, 26);
            this.buttonRenameList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRenameList.Name = "buttonRenameList";
            this.buttonRenameList.Size = new System.Drawing.Size(84, 29);
            this.buttonRenameList.TabIndex = 2;
            this.buttonRenameList.Text = "Rename";
            this.buttonRenameList.UseVisualStyleBackColor = true;
            // 
            // buttonNewList
            // 
            this.buttonNewList.Location = new System.Drawing.Point(507, 26);
            this.buttonNewList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(84, 29);
            this.buttonNewList.TabIndex = 1;
            this.buttonNewList.Text = "New";
            this.buttonNewList.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(7, 26);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 664);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(864, 699);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove image";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(742, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Adjustments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ImageListDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 816);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImageListDialogue";
            this.Text = "ImageListDialogue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteList;
        private System.Windows.Forms.Button buttonSaveAsList;
        private System.Windows.Forms.Button buttonRenameList;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}