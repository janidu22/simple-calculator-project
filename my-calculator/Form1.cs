using System.Data;
using System.Diagnostics.Contracts;

namespace my_calculator
{
    public partial class Form1 : Form
    {
        private string CurrentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Button_click(object sender, EventArgs e)
        {
            CurrentCalculation += (sender as Button).Text;
            txtDisplay.Text = CurrentCalculation;
        }

        public void Btn_assignment_click(object sender, EventArgs e)
        {
            string formattedCalculation = CurrentCalculation.ToString();

            try
            {
                txtDisplay.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                CurrentCalculation = txtDisplay.Text;
            }
            catch (Exception ex)
            {

                txtDisplay.Text = "ERROR";
                CurrentCalculation = "";
            }
        }

        public void Clear_button_click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            CurrentCalculation = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (CurrentCalculation.Length > 0)
            {
                CurrentCalculation = CurrentCalculation.Remove(CurrentCalculation.Length -1,1);
            }
            txtDisplay.Text = CurrentCalculation;
        }
    }
}
