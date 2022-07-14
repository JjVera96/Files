namespace Archivos
{
    public partial class FileManagement : Form
    {
        private readonly OpenFileDialog Dialog = new();
        public FileManagement()
        {
            Dialog.RestoreDirectory = true;
            Dialog.Title = "Search file";
            Dialog.DefaultExt = "txt";
            Dialog.Filter = "Text files .txt | *.txt|All files| *.*|Excel files|*.xlsx|Excel files|*.xls";
            Dialog.CheckFileExists = true;
            Dialog.CheckPathExists = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog.ShowDialog();
            TitleFile.Text = Dialog.FileName;
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            if (TitleFile.Text == String.Empty)
            {
                MessageBox.Show("No file selected");
            }
            else
            {
                ContentFile.Text = File.ReadAllText(TitleFile.Text);
                MessageBox.Show("file read successfully");
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(TitleFile.Text, ContentFile.Text);
            MessageBox.Show("file saved successfully");
        }

        private void AddLine_Click(object sender, EventArgs e)
        {
            StreamWriter file = new(TitleFile.Text, true);
            file.WriteLine(Line.Text);
            file.Close();
            MessageBox.Show("Line added successfully");

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PersonalInfo pi = new PersonalInfo();
            pi.Show();
        }
    }
}