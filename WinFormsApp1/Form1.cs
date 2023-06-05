namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Numbers(object sender, EventArgs e)
        {
            var button = (Button)sender;
            textBox1.Text += button.Text;


            
            switch (button.Text)
            {
                case "1": textBox1.Text = "1"; break;
                case "2": textBox1.Text = "2"; break;
                case "3": textBox1.Text = "3"; break;
                case "4": textBox1.Text = "4"; break;
                case "5": textBox1.Text = "5"; break;
                case "6": textBox1.Text = "6"; break;
                case "7": textBox1.Text = "7"; break;
                case "8": textBox1.Text = "8"; break;
                case "9": textBox1.Text = "9"; break;
                case "0": textBox1.Text = "0"; break;


                case "+": textBox1.Text = "+"; break;
                case "-": textBox1.Text = "-"; break;
                case "*": textBox1.Text = "*"; break;
                case "/": textBox1.Text = "/"; break;
                case "=": textBox1.Text = "="; break;



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}