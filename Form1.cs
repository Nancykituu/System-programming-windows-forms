namespace systemprogramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemoryManagementForm memoryForm = new MemoryManagementForm();
            memoryForm.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            FileManagementForm fileForm = new FileManagementForm();
            fileForm.Show();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessControlForm processForm = new ProcessControlForm();
            processForm.Show();
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            CommunicationForm communicationForm = new CommunicationForm();
            communicationForm.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            InformationForm infoForm = new InformationForm();
            infoForm.Show();
        }
    }
}
