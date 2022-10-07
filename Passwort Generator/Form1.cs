namespace Bruteforce_stile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //numbergenerator

            richTextBox1.Text = "Passwort";
            var random = new Random();
            var list = new List<string> { "text" ,"more text"};
            int index = random.Next();
            
            richTextBox1.Text = index.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Randomgenerator

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            richTextBox1.Text = finalString;



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }
    }
}