namespace Calulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtValue1.Text);
            var b = Convert.ToInt32(txtValue2.Text);
            var c = a + b;
            txtresult.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtValue1.Text);
            var b = Convert.ToInt32(txtValue2.Text);
            var c = a - b;
            txtresult.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtValue1.Text);
            var b = Convert.ToInt32(txtValue2.Text);
            var c = a * b;
            txtresult.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtValue1.Text);
            var b = Convert.ToInt32(txtValue2.Text);
            var c = a / b;
            txtresult.Text = c.ToString();
        }
    }
}
