namespace Attendance.Registeration_Forms
{
    partial class Forget_Password
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
            TBRestUN = new TextBox();
            label1 = new Label();
            TBRestPas = new TextBox();
            label2 = new Label();
            BTNRest = new Button();
            SuspendLayout();
            // 
            // TBRestUN
            // 
            TBRestUN.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBRestUN.Location = new Point(192, 93);
            TBRestUN.Name = "TBRestUN";
            TBRestUN.Size = new Size(175, 35);
            TBRestUN.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 93);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // TBRestPas
            // 
            TBRestPas.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBRestPas.Location = new Point(192, 185);
            TBRestPas.Name = "TBRestPas";
            TBRestPas.Size = new Size(175, 35);
            TBRestPas.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 188);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 4;
            label2.Text = "New Password";
            // 
            // BTNRest
            // 
            BTNRest.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNRest.Location = new Point(107, 304);
            BTNRest.Name = "BTNRest";
            BTNRest.Size = new Size(127, 44);
            BTNRest.TabIndex = 6;
            BTNRest.Text = "Rest";
            BTNRest.UseVisualStyleBackColor = true;
            BTNRest.Click += rest_password;
            // 
            // Forget_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 411);
            Controls.Add(BTNRest);
            Controls.Add(TBRestPas);
            Controls.Add(label2);
            Controls.Add(TBRestUN);
            Controls.Add(label1);
            MaximumSize = new Size(420, 450);
            MinimumSize = new Size(420, 450);
            Name = "Forget_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBRestUN;
        private Label label1;
        private TextBox TBRestPas;
        private Label label2;
        private Button BTNRest;
    }
}