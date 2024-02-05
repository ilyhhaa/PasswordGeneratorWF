namespace PasswordGeneratorWF
{
    public partial class Form1 : Form
    {
        int currentPassword = 0;
        Random character = new Random();

        private void Passgenerator(int passwordLength)
        {
            String allcharacters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm!@#$%^&*()_+=1234567890";
            String randomPassword = " ";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allcharacters.Length);
                randomPassword += allcharacters[randomNum];
            }
            passwordLabel.Text = randomPassword;
        }
        public Form1()
        {
           
            
            InitializeComponent();
            passwordLengthSlider.Minimum = 5;
            passwordLengthSlider.Maximum = 20;
            Passgenerator(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Clipboard.SetText(passwordLabel.Text);
        }

        private void passwordLengthSlider_Scroll(object sender, EventArgs e)
        {
            passwordLength_Label.Text = "Password Length: " + passwordLengthSlider.Value.ToString();
            currentPassword = passwordLengthSlider.Value;
            Passgenerator(currentPassword);
        }

        private void passwordLength_Click(object sender, EventArgs e)
        {

        }
    }
}