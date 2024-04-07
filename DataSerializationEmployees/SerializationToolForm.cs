using EmployeesLibrary;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace DataSerializationEmployees
{
    public partial class SerializationToolForm : EmployeesUIForm
    {

        List<Empleados> empleados = new List<Empleados>();
        private int totalFilas;
        public SerializationToolForm()
        {
            InitializeComponent();
            InjectSampleData();

            dgvDatosEmployee.RowsAdded += (s, ev) => ActualizarEstadoBoton();
            dgvDatosEmployee.RowsRemoved += (s, ev) => ActualizarEstadoBoton();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();

            // Validar que los campos no estén vacíos
            if (String.IsNullOrWhiteSpace(values[(int)TextBoxIndices.FirstName]) ||
                String.IsNullOrWhiteSpace(values[(int)TextBoxIndices.LastName]) ||
                String.IsNullOrWhiteSpace(values[(int)TextBoxIndices.Departament]) ||
                String.IsNullOrWhiteSpace(values[(int)TextBoxIndices.Salary]))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el formato del salario
            if (!decimal.TryParse(values[(int)TextBoxIndices.Salary], out decimal salario) || salario <= 0)
            {
                MessageBox.Show("El salario debe ser un número positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todos los campos están validados correctamente, crear y agregar el empleado
            var empleado = new Empleados(
                values[(int)TextBoxIndices.FirstName],
                values[(int)TextBoxIndices.LastName],
                values[(int)TextBoxIndices.Departament],
                salario
            );

            empleados.Add(empleado);

            dgvDatosEmployee.DataSource = null;
            dgvDatosEmployee.DataSource = empleados;

            buttonSerializeJson.Enabled = true;
            buttonSerializeXml.Enabled = true;
            deleteRowButton.Enabled = true;

            ClearAllTextBoxes();

        }

        private void buttonSerializeJson_Click(object sender, EventArgs e)
        {
            SerializeData("json");
        }

        private void buttonSerializeXml_Click(object sender, EventArgs e)
        {
            SerializeData("xml");
        }

        private void SerializeData(string format)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                switch (format)
                {
                    case "json":
                        fileChooser.DefaultExt = "json";
                        fileChooser.Filter = "Archivos JSON (*.json)|*.json";
                        break;
                    case "xml":
                        fileChooser.DefaultExt = "xml";
                        fileChooser.Filter = "Archivos XML (*.xml)|*.xml";
                        break;
                    default:
                        throw new ArgumentException("Formato de archivo no válido");
                }

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (!fileName.EndsWith($".{format}"))
                {
                    fileName += $".{format}";
                }

                IDataRepositoryFactory serializerFactory;
                ObjectDataRepository serializer;

                switch (format)
                {
                    case "json":
                        serializerFactory = new JsonSerializerFactory();
                        serializer = new ObjectDataRepository(serializerFactory);
                        break;
                    case "xml":
                        serializerFactory = new XmlSerializerFactory();
                        serializer = new ObjectDataRepository(serializerFactory);
                        break;
                    default:
                        throw new ArgumentException("Formato de archivo no válido");
                }

                serializer.Serialize(empleados, fileName);
            }
        }



        //Evento para eliminar la fila seleccionada
        private void deleteThisRow(object sender, EventArgs e)
        {
            if (dgvDatosEmployee.CurrentRow != null)
            {
                var index = dgvDatosEmployee.CurrentCell.RowIndex;
                empleados.RemoveAt(index);
                dgvDatosEmployee.DataSource = null;
                dgvDatosEmployee.DataSource = empleados;
            }
        }

        //Eventos para arrastrar la ventana
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void SerializationToolForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void SerializationToolForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void SerializationToolForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        //Cerrar la ventana

        private void closeWindowClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Inyeccion de datos
        private void InjectSampleData()
        {
            // Datos de ejemplo para inyectar en la lista de empleados
            var sampleData = new List<Empleados>
            {
                new Empleados("Juan", "González", "Departamento 1", 2500),
                new Empleados("María", "López", "Departamento 2", 2800),
                new Empleados("Juan", "Gutierrez", "Departamento 4", 300),
                new Empleados("Pedro", "Ruiz", "Departamento 5", 30500),
                new Empleados("José", "Sanchez", "Departamento 6", 8000),
                new Empleados("Yader", "Solano", "Departamento 7", 10000),
            };
            foreach (var empleado in sampleData)
            {
                empleados.Add(empleado);
            }

            dgvDatosEmployee.DataSource = null;
            dgvDatosEmployee.DataSource = empleados;
        }

        //Deshabilitar los botones si no hay información que guardar   
        private void dgvDatosEmployee_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totalFilas = dgvDatosEmployee.RowCount;
            ActualizarEstadoBoton();
        }

        private void dgvDatosEmployee_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totalFilas = dgvDatosEmployee.RowCount;
            ActualizarEstadoBoton();
        }

        private void ActualizarEstadoBoton()
        {
            if (totalFilas > 0)
            {
                buttonSerializeJson.Enabled = true;
                buttonSerializeXml.Enabled = true;
                deleteRowButton.Enabled = true;
            }
            else if (totalFilas == 0)
            {
                buttonSerializeJson.Enabled = false;
                buttonSerializeXml.Enabled = false;
                deleteRowButton.Enabled = false;
            }
        }

        private void LoadFileClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string extension = Path.GetExtension(filePath);

                    try
                    {
                        List<Empleados> loadedEmpleados = new List<Empleados>();

                        if (extension.ToLower() == ".xml")
                        {
                            IDataRepositoryFactory dataRepositoryFactory = new XmlSerializerFactory();
                            ObjectDataRepository xmlObjectSerializer = new ObjectDataRepository(dataRepositoryFactory);
                            loadedEmpleados = xmlObjectSerializer.Deserialize<List<Empleados>>(filePath);
                        }
                        else if (extension.ToLower() == ".json")
                        {
                            IDataRepositoryFactory dataRepositoryFactory = new JsonSerializerFactory();
                            ObjectDataRepository jsonObjectSerializer = new ObjectDataRepository(dataRepositoryFactory);
                            loadedEmpleados = jsonObjectSerializer.Deserialize<List<Empleados>>(filePath);
                        }
                        else
                        {
                            MessageBox.Show("Formato de archivo no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        empleados.Clear();

                        empleados.AddRange(loadedEmpleados);
                        dgvDatosEmployee.DataSource = null;
                        dgvDatosEmployee.DataSource = empleados;

                        ActualizarEstadoBoton();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
