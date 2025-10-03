namespace Attendance.Registeration_Forms
{
    partial class Register
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
            label1 = new Label();
            TBRegUN = new TextBox();
            TBRegPas = new TextBox();
            label2 = new Label();
            BTNReg = new Button();
            RBTeacher = new RadioButton();
            RBStudent = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 76);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            //label1.Click += this.label1_Click;
            // 
            // TBRegUN
            // 
            TBRegUN.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBRegUN.Location = new Point(188, 73);
            TBRegUN.Name = "TBRegUN";
            TBRegUN.Size = new Size(238, 35);
            TBRegUN.TabIndex = 1;
            //TBRegUN.TextChanged += this.TBRegUN_TextChanged;
            // 
            // TBRegPas
            // 
            TBRegPas.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBRegPas.Location = new Point(188, 149);
            TBRegPas.Name = "TBRegPas";
            TBRegPas.Size = new Size(238, 35);
            TBRegPas.TabIndex = 3;
            TBRegPas.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 154);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            //label2.Click += this.label2_Click;
            // 
            // BTNReg
            // 
            BTNReg.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNReg.Location = new Point(188, 305);
            BTNReg.Name = "BTNReg";
            BTNReg.Size = new Size(127, 44);
            BTNReg.TabIndex = 4;
            BTNReg.Text = "Register";
            BTNReg.UseVisualStyleBackColor = true;
            BTNReg.Click += register_New_User;
            // 
            // RBTeacher
            // 
            RBTeacher.AutoSize = true;
            RBTeacher.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBTeacher.Location = new Point(14, 19);
            RBTeacher.Name = "RBTeacher";
            RBTeacher.Size = new Size(111, 34);
            RBTeacher.TabIndex = 5;
            RBTeacher.TabStop = true;
            RBTeacher.Text = "Teacher";
            RBTeacher.UseVisualStyleBackColor = true;
            // 
            // RBStudent
            // 
            RBStudent.AutoSize = true;
            RBStudent.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBStudent.Location = new Point(166, 19);
            RBStudent.Name = "RBStudent";
            RBStudent.Size = new Size(110, 34);
            RBStudent.TabIndex = 6;
            RBStudent.TabStop = true;
            RBStudent.Text = "Student";
            RBStudent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(RBTeacher);
            panel1.Controls.Add(RBStudent);
            panel1.Location = new Point(113, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 56);
            panel1.TabIndex = 7;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 377);
            Controls.Add(panel1);
            Controls.Add(BTNReg);
            Controls.Add(TBRegPas);
            Controls.Add(label2);
            Controls.Add(TBRegUN);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            //Load += this.Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBRegUN;
        private TextBox TBRegPas;
        private Label label2;
        private Button BTNReg;
        private RadioButton RBTeacher;
        private RadioButton RBStudent;
        private Panel panel1;
    }
}