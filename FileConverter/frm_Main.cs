using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Spire.Xls;
using System.Reflection;

namespace FileConverter
{
    public partial class Frm_Main : Form
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private string ConvertedFilePath = @"C:\File Converter (RJ)\";

        public Frm_Main()
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

        private void Btn_SelectFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "Excel Files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    var fileName = Path.GetFileName(filePath);

                    // Check if the file already exists in DataGridView
                    if (!FileExistsInDataGridView(fileName))
                    {
                        Dgv_Details.Rows.Add(filePath, fileName,  "","0%");
                        Dgv_Details.ClearSelection();
                        Btn_Convert.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show($"File '{fileName}' is already exist", "File Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool FileExistsInDataGridView(string fileName)
        {
            foreach (DataGridViewRow row in Dgv_Details.Rows)
            {
                if (row.Cells[1].Value.ToString() == fileName)
                {
                    return true;
                }
            }
            return false;
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cmb_Output.Text))
            {
                MessageBox.Show("Please select the output format", "Output Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Dgv_Details.Rows.Count > 0)
            {
                ConvertFiles(Dgv_Details);

                Btn_Convert.Enabled = false;
                Dgv_Details.ReadOnly = true;
            }
        }

        private void UpdateProgress(string fileName, int progressPercentage, string Location)
        {
            foreach (DataGridViewRow row in Dgv_Details.Rows)
            {
                if (row.Cells[1].Value.ToString() == fileName)
                {
                    row.Cells[3].Value = $"{progressPercentage}%";

                    if (progressPercentage % 10 == 0)
                    {
                        Dgv_Details.Refresh();
                    }

                    row.Cells[2].Value = $"{Location}";

                    break;
                }
            }
        }

        private void ConvertExcelToCsv(string excelPath, string csvPath)
        {
            Debug.WriteLine($"[{DateTime.Now}]: Converting Excel to Csv.");

            try
            {
                stopwatch.Restart();

                // Combine the destination directory and the original file name with a new CSV extension
                string destinationCsvPath = Path.Combine(Path.GetDirectoryName(csvPath), Path.GetFileNameWithoutExtension(excelPath) + ".csv");


                using (StreamWriter streamWriter = new StreamWriter(destinationCsvPath))
                using (Workbook workbook = new Workbook())
                {
                    workbook.LoadFromFile(excelPath);
                    Worksheet worksheet = workbook.Worksheets[0];

                    for (int row = 1; row <= worksheet.LastRow; row++)
                    {
                        List<string> rowData = new List<string>();

                        for (int col = 1; col <= worksheet.LastColumn; col++)
                        {
                            CellRange cell = worksheet.Range[row, col];
                            string cellData = cell?.Value?.ToString()?.Trim();

                            cellData = string.IsNullOrEmpty(cellData) ? "-" : StrClean(cellData).ToUpper();

                            if (cellData.Contains(",") || cellData.Contains("\""))
                            {
                                cellData = $"\"{cellData.Replace("\"", "\"\"")}\"";
                            }

                            rowData.Add(cellData);
                        }

                        streamWriter.WriteLine(string.Join(",", rowData));

                        // Calculate progress percentage
                        int progressPercentage = (int)((double)row / worksheet.LastRow * 100);

                        // Update progress for each selected item in the DataGridView
                        UpdateProgress(Path.GetFileName(excelPath), progressPercentage, destinationCsvPath);
                    }

                    stopwatch.Stop();

                    // Show message with the number of rows and columns loaded
                    MessageBox.Show($"Excel Successfully Converted to Csv\n" +
                                    $"\nTotal Rows : {worksheet.LastRow}" +
                                    $"\nTotal Columns : {worksheet.LastColumn}" +
                                    $"\nTime taken : {stopwatch.Elapsed.ToString(@"hh\:mm\:ss")}",
                                    "Converting Excel to Csv",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ioEx)
            {
                HandleConversionError("IOException", ioEx.Message);
            }
            catch (Exception ex)
            {
                HandleConversionError("Error", ex.Message);
            }
        }

        private void HandleConversionError(string errorType, string errorMessage)
        {
            MessageBox.Show($"Converting Excel to Csv. \n{errorType}: {errorMessage}", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConvertFiles(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Get Path
                var FilePath       = row.Cells[0].Value.ToString();
                var OutputFile     = Cmb_Output.Text;
                var FileExtenstion = Path.GetExtension(FilePath);

                // Check file to convert into.
                switch (OutputFile)
                {

                    case "CSV":

                        // Check the file you need to convert
                        switch(FileExtenstion)
                        {
                            case ".xls":
                            case ".xlsx":
                                ConvertExcelToCsv(FilePath, ConvertedFilePath);
                                break;

                            case ".text":

                                break;

                            default:
                                MessageBox.Show("File is already a csv file","File Convertion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }

                        break;

                    case "TEXT":
                        break;

                    case "EXCEL":
                   
                        break;

                    default:
                        MessageBox.Show("File not supported", "Output File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
        }

        private void Frm_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Show a confirmation dialog
                DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    // Exit the application
                    Application.Exit();
                }
            }
        }

        public static string StrClean(string str)
        {
            Dictionary<string, string> replacements = new Dictionary<string, string>
            {
                { "ñ", "n" },
                { "Ñ", "N" },
                { "\t", "" },
                { "\n", "" },
                { "\r", "" },
                { " ", "" },
                { ",", "" },
                { "'", "" },
                { ";", "" },
                { "  ", " " },
                { "\"", "" }
            };

            string result = RemoveChars(str, replacements).ToUpper();

            return !string.IsNullOrWhiteSpace(result) ? result : "-";
        }

        private static string RemoveChars(string input, Dictionary<string, string> replacements)
        {
            StringBuilder sb = new StringBuilder(input);

            foreach (var replacement in replacements)
            {
                sb.Replace(replacement.Key, replacement.Value);
            }

            try
            {
                if (DateTime.TryParse(input, out DateTime tempDate))
                {
                    return tempDate.ToString("yyyy-MM-dd");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Failed Parsing Date. \nError: {ex.Message}", "Remove Characters");
                return null;
            }

            return sb.ToString();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            // Check if the directory exists
            if (!Directory.Exists(ConvertedFilePath))
            {
                try
                {
                    // Create the directory
                    Directory.CreateDirectory(ConvertedFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating directory: {ex.Message}", "Directory Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Optionally handle the error further if needed
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Dgv_Details.Rows.Clear();
            Btn_Convert.Enabled = false;
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (Dgv_Details.SelectedRows.Count > 0)
            {
                Dgv_Details.Rows.RemoveAt(Dgv_Details.SelectedRows[0].Index);
            }
        }

        private void Dgv_Details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string sFilePath = Dgv_Details.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Dgv_Details.Rows[e.RowIndex].Cells[3].Value.ToString() != "100%")
                {
                    return;
                }

                if (File.Exists(sFilePath))
                {
                    Frm_Preview Preview = new Frm_Preview();
                    Preview.FilePath = sFilePath;
                    Preview.Show();
                }
                else
                {
                    MessageBox.Show("File does not exist", "File Preview", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid selection", "File Preview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
