namespace Attendance
{
    partial class ClassSetting
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
<<<<<<< HEAD
            TBClassID = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BTNViewClass = new Button();
            BTNDeleteClass = new Button();
            BTNEditClass = new Button();
            BTNViewAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TBClassID
            // 
            TBClassID.Location = new Point(134, 44);
            TBClassID.Name = "TBClassID";
            TBClassID.Size = new Size(200, 23);
            TBClassID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter class ID";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(374, 326);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 160);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter class ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 242);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Enter class ID";
            // 
            // BTNViewClass
            // 
            BTNViewClass.Location = new Point(134, 102);
            BTNViewClass.Name = "BTNViewClass";
            BTNViewClass.Size = new Size(75, 23);
            BTNViewClass.TabIndex = 7;
            BTNViewClass.Text = "View Class";
            BTNViewClass.UseVisualStyleBackColor = true;
            BTNViewClass.Click += BTNViewClass_Click;
            // 
            // BTNDeleteClass
            // 
            BTNDeleteClass.Location = new Point(242, 102);
            BTNDeleteClass.Name = "BTNDeleteClass";
            BTNDeleteClass.Size = new Size(92, 23);
            BTNDeleteClass.TabIndex = 8;
            BTNDeleteClass.Text = "Delete Class";
            BTNDeleteClass.UseVisualStyleBackColor = true;
            // 
            // BTNEditClass
            // 
            BTNEditClass.Location = new Point(172, 315);
            BTNEditClass.Name = "BTNEditClass";
            BTNEditClass.Size = new Size(92, 23);
            BTNEditClass.TabIndex = 9;
            BTNEditClass.Text = "Edit Class";
            BTNEditClass.UseVisualStyleBackColor = true;
            // 
            // BTNViewAll
            // 
            BTNViewAll.Location = new Point(30, 102);
            BTNViewAll.Name = "BTNViewAll";
            BTNViewAll.Size = new Size(75, 23);
            BTNViewAll.TabIndex = 10;
            BTNViewAll.Text = "View All";
            BTNViewAll.UseVisualStyleBackColor = true;
            BTNViewAll.Click += BTNViewAll_Click;
            // 
            // ClassSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNViewAll);
            Controls.Add(BTNEditClass);
            Controls.Add(BTNDeleteClass);
            Controls.Add(BTNViewClass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(TBClassID);
            Name = "ClassSetting";
            Text = "ClassSetting";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
=======
            SuspendLayout();
            // 
            // ClassSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ClassSetting";
            Text = "Class Setting";
            ResumeLayout(false);
>>>>>>> 242ca7816b496cc8061f1246b74d6794550a89e8
        }

        #endregion

        private TextBox TBClassID;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button BTNViewClass;
        private Button BTNDeleteClass;
        private Button BTNEditClass;
        private Button BTNViewAll;
    }
}