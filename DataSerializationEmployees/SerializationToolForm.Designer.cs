namespace DataSerializationEmployees
{
    partial class SerializationToolForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            buttonSerializeJson = new Button();
            buttonSerializeXml = new Button();
            addEmployee = new Button();
            dgvDatosEmployee = new DataGridView();
            label5 = new Label();
            deleteRowButton = new Button();
            exitButton = new Button();
            loadFileButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmployee).BeginInit();
            SuspendLayout();
            // 
            // buttonSerializeJson
            // 
            buttonSerializeJson.Enabled = false;
            buttonSerializeJson.FlatStyle = FlatStyle.Flat;
            buttonSerializeJson.ForeColor = Color.FromArgb(16, 64, 59);
            buttonSerializeJson.Location = new Point(215, 250);
            buttonSerializeJson.Margin = new Padding(0);
            buttonSerializeJson.Name = "buttonSerializeJson";
            buttonSerializeJson.Size = new Size(70, 40);
            buttonSerializeJson.TabIndex = 8;
            buttonSerializeJson.Text = "Serializar a JSON";
            buttonSerializeJson.UseVisualStyleBackColor = true;
            buttonSerializeJson.Click += buttonSerializeJson_Click;
            // 
            // buttonSerializeXml
            // 
            buttonSerializeXml.Enabled = false;
            buttonSerializeXml.FlatStyle = FlatStyle.Flat;
            buttonSerializeXml.ForeColor = Color.FromArgb(16, 64, 59);
            buttonSerializeXml.Location = new Point(310, 250);
            buttonSerializeXml.Margin = new Padding(0);
            buttonSerializeXml.Name = "buttonSerializeXml";
            buttonSerializeXml.Size = new Size(70, 40);
            buttonSerializeXml.TabIndex = 9;
            buttonSerializeXml.Text = "Serializar a XML";
            buttonSerializeXml.UseVisualStyleBackColor = true;
            buttonSerializeXml.Click += buttonSerializeXml_Click;
            // 
            // addEmployee
            // 
            addEmployee.FlatStyle = FlatStyle.Flat;
            addEmployee.ForeColor = Color.FromArgb(16, 64, 59);
            addEmployee.Location = new Point(120, 250);
            addEmployee.Margin = new Padding(0);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(70, 40);
            addEmployee.TabIndex = 10;
            addEmployee.Text = "Agregar empleado";
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // dgvDatosEmployee
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 64, 59);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(76, 89, 88);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatosEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatosEmployee.BackgroundColor = Color.FromArgb(138, 166, 163);
            dgvDatosEmployee.BorderStyle = BorderStyle.None;
            dgvDatosEmployee.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDatosEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(16, 64, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(76, 89, 88);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatosEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosEmployee.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 64, 59);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(76, 89, 88);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDatosEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDatosEmployee.Dock = DockStyle.Bottom;
            dgvDatosEmployee.EnableHeadersVisualStyles = false;
            dgvDatosEmployee.GridColor = Color.FromArgb(191, 191, 191);
            dgvDatosEmployee.Location = new Point(0, 300);
            dgvDatosEmployee.MultiSelect = false;
            dgvDatosEmployee.Name = "dgvDatosEmployee";
            dgvDatosEmployee.ReadOnly = true;
            dgvDatosEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 64, 59);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(76, 89, 88);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDatosEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDatosEmployee.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(16, 64, 59);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(76, 89, 88);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDatosEmployee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDatosEmployee.Size = new Size(500, 200);
            dgvDatosEmployee.TabIndex = 11;
            dgvDatosEmployee.RowsAdded += dgvDatosEmployee_RowsAdded;
            dgvDatosEmployee.RowsRemoved += dgvDatosEmployee_RowsRemoved;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(18, 115, 105);
            label5.Location = new Point(100, 10);
            label5.Name = "label5";
            label5.Size = new Size(294, 33);
            label5.TabIndex = 12;
            label5.Text = "Serializador de datos";
            // 
            // deleteRowButton
            // 
            deleteRowButton.Enabled = false;
            deleteRowButton.FlatStyle = FlatStyle.Flat;
            deleteRowButton.ForeColor = Color.FromArgb(16, 64, 59);
            deleteRowButton.Location = new Point(405, 250);
            deleteRowButton.Margin = new Padding(0);
            deleteRowButton.Name = "deleteRowButton";
            deleteRowButton.Size = new Size(70, 40);
            deleteRowButton.TabIndex = 13;
            deleteRowButton.Text = "Eliminar fila";
            deleteRowButton.UseVisualStyleBackColor = true;
            deleteRowButton.Click += deleteThisRow;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(475, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.TabIndex = 14;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += closeWindowClick;
            // 
            // loadFileButton
            // 
            loadFileButton.BackColor = Color.FromArgb(191, 191, 191);
            loadFileButton.FlatStyle = FlatStyle.Flat;
            loadFileButton.ForeColor = Color.FromArgb(16, 64, 59);
            loadFileButton.Location = new Point(25, 250);
            loadFileButton.Margin = new Padding(0);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(70, 40);
            loadFileButton.TabIndex = 15;
            loadFileButton.Text = "Cargar archivo";
            loadFileButton.UseVisualStyleBackColor = false;
            loadFileButton.Click += LoadFileClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 89, 88);
            panel1.Location = new Point(0, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 1);
            panel1.TabIndex = 16;
            // 
            // SerializationToolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 191, 191);
            ClientSize = new Size(500, 500);
            Controls.Add(panel1);
            Controls.Add(loadFileButton);
            Controls.Add(exitButton);
            Controls.Add(deleteRowButton);
            Controls.Add(label5);
            Controls.Add(dgvDatosEmployee);
            Controls.Add(addEmployee);
            Controls.Add(buttonSerializeXml);
            Controls.Add(buttonSerializeJson);
            Name = "SerializationToolForm";
            Text = "Form1";
            MouseDown += SerializationToolForm_MouseDown;
            MouseMove += SerializationToolForm_MouseMove;
            MouseUp += SerializationToolForm_MouseUp;
            Controls.SetChildIndex(buttonSerializeJson, 0);
            Controls.SetChildIndex(buttonSerializeXml, 0);
            Controls.SetChildIndex(addEmployee, 0);
            Controls.SetChildIndex(dgvDatosEmployee, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(deleteRowButton, 0);
            Controls.SetChildIndex(exitButton, 0);
            Controls.SetChildIndex(loadFileButton, 0);
            Controls.SetChildIndex(panel1, 0);
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSerializeJson;
        private Button buttonSerializeXml;
        private Button addEmployee;
        private DataGridView dgvDatosEmployee;
        private Label label5;
        private Button deleteRow;
        private Button deleteRowButton;
        private Button exitButton;
        private Button loadFileButton;
        private Panel panel1;
    }
}
