using QRGenerator.Engine.Enum;

namespace QRGeneratorForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbx_Errorlvl.DataSource = Enum.GetValues(typeof(ErrorLevelCorrectionEnum));
        }
    }
}
