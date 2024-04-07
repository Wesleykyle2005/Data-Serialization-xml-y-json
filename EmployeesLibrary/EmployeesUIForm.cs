using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesLibrary
{
    public partial class EmployeesUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;

        public enum TextBoxIndices { FirstName, LastName, Departament, Salary }

        public EmployeesUIForm()
        {
            InitializeComponent();
        }


        public void ClearAllTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException($"Debe haber {TextBoxCount} cadenas de texto en el array ", nameof(values)));
            }
            else
            {
                firstNameTextBox.Text = values[(int)TextBoxIndices.FirstName];
                lastNameTextBox.Text = values[(int)TextBoxIndices.LastName];
                departamentTextBox.Text = values[(int)TextBoxIndices.Departament];
                salaryTextBox.Text = values[(int)TextBoxIndices.Salary];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                departamentTextBox.Text,
                salaryTextBox.Text
            };
        }

      
    }
}
