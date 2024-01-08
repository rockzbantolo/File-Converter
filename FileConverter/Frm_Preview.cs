using Spire.Xls;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FileConverter
{
    public partial class Frm_Preview : Form
    {
        public string FilePath { get; set; }


        public Frm_Preview()
        {
            InitializeComponent();
            DoubleBuffer(Dgv_Details);
        }

        private static void DoubleBuffer(Control ctrl)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctrl, new object[] { true });
        }

        private void Frm_Preview_Load(object sender, EventArgs e)
        {
            var FileExtenstion = Path.GetExtension(FilePath);

            switch (FileExtenstion)
            {
                case ".xls":
                case ".xlsx":
                    LoadExcelToDgv(Dgv_Details, FilePath);
                    break;

                case ".text":

                    break;

                case ".csv":
                    LoadCsvToDgv(Dgv_Details, FilePath);
                    break;

                default:
                    MessageBox.Show("Error viewing file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private static void LoadExcelToDgv(DataGridView Dgv, string filePath)
        {
            Debug.WriteLine($"[{DateTime.Now}]: Uploading to Gridview.");

            try
            {
                // Reset the DataGridView
                Dgv.DataSource = null;

                // Load the Excel workbook
                using (Workbook workbook = new Workbook())
                {
                    workbook.LoadFromFile(filePath);
                    Worksheet worksheet = workbook.Worksheets[0]; // Assuming you want to convert the first worksheet

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Create DataTable columns using the first row values
                    for (int col = 1; col <= worksheet.LastColumn; col++)
                    {
                        string columnName = worksheet.Range[1, col].Text;
                        dataTable.Columns.Add(columnName);
                    }

                    // Populate DataTable
                    for (int row = 2; row <= worksheet.LastRow; row++)
                    {
                        DataRow dataRow = dataTable.Rows.Add();
                        for (int col = 1; col <= worksheet.LastColumn; col++)
                        {
                            // Get cell value and handle null or empty values
                            dataRow[col - 1] = worksheet.Range[row, col].Text ?? "-";
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    Dgv.DataSource = dataTable;

                }
            }
            catch (IOException ioEx)
            {
                // Handle IOException (file-related error)
                MessageBox.Show($"Uploading Excel to Grid. \nIOException: {ioEx.Message}", "Uploading Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Uploading Excel to Grid. \nException: {ex.Message}", "Uploading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadCsvToDgv(DataGridView Dgv, string Path)
        {
            Debug.WriteLine($"[{DateTime.Now}]: Uploading to GridView.");

            try
            {
                // Clear Grid
                Dgv.DataSource = null;

                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(Path);

                if (lines.Length == 0)
                {
                    // Handle the case where the CSV file is empty
                    MessageBox.Show("CSV file is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Split the first line into column names
                string[] columnNames = lines[0].Split(',');

                // Create a DataTable with columns based on column names
                DataTable dt = new DataTable();

                // Ensure unique and non-empty column names
                for (int i = 0; i < columnNames.Length; i++)
                {
                    string columnName = string.IsNullOrWhiteSpace(columnNames[i]) ? $"Column{i + 1}" : columnNames[i];
                    columnName = GetUniqueColumnName(dt, columnName);
                    dt.Columns.Add(columnName);
                }

                // Populate the DataTable
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    dt.Rows.Add(values);
                }

                // Bind the DataTable to the DataGridView
                Dgv.DataSource = dt;
            }
            catch (IOException ioEx)
            {
                // Handle IOException (file-related error)
                MessageBox.Show($"Uploading Csv file to GridView.\nIOException: {ioEx.Message}", "Uploading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Uploading Csv file to GridView.\nException: {ex.Message}", "Uploading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to get a unique column name
        private static string GetUniqueColumnName(DataTable dataTable, string originalColumnName)
        {
            string columnName = originalColumnName;
            int suffix = 1;

            // Loop until a unique column name is found
            while (dataTable.Columns.Contains(columnName))
            {
                columnName = $"{originalColumnName}{suffix}";
                suffix++;
            }

            return columnName;
        }


    }
}
