namespace maskedtextBoxlistBoxpictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + "  " 
                + maskedTextBox2.Text + "  " +  maskedTextBox3.Text +
                " " + maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(dateTimePicker1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox2.Text);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = listBox3.Text;
        }
    }
}