using QRGenerator.Engine.Enum;

namespace QRGeneratorForms
{
    public partial class Form1 : Form
    {
        private string selectedImagePath;
        public Form1()
        {
            InitializeComponent();

            cmbx_Errorlvl.DataSource = Enum.GetValues(typeof(ErrorLevelCorrectionEnum));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    MessageBox.Show("Imagen seleccionada: " + selectedImagePath, "Imagen Cargada");
                }
            }
        }
    }
}
