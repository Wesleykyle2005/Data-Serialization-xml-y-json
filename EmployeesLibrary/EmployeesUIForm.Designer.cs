namespace EmployeesLibrary
{
    partial class EmployeesUIForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            departamentTextBox = new TextBox();
            salaryTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(50, 58);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Primer nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 108);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 158);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 208);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Salario";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(250, 50);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 23);
            firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(250, 100);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // departamentTextBox
            // 
            departamentTextBox.Location = new Point(250, 150);
            departamentTextBox.Name = "departamentTextBox";
            departamentTextBox.Size = new Size(200, 23);
            departamentTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(250, 200);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(200, 23);
            salaryTextBox.TabIndex = 7;
            // 
            // EmployeesUIForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(500, 700);
            ControlBox = false;
            Controls.Add(salaryTextBox);
            Controls.Add(departamentTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "EmployeesUIForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EmployeesUIForm";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox departamentTextBox;
        private TextBox salaryTextBox;
    }
}