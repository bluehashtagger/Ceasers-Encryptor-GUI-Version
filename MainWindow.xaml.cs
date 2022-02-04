using System.Windows;
using System.Windows.Controls;

namespace Ceasers_Encryptor_GUI_Version
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

			KeywordInput.Text = keyword;

		}
		string cyphertext = "";
		string plaintext = "";
		string keyword = "";
		string task = "";
		

		void Encyptor()
		{
			cyphertext = "";
			int x = plaintext.Length;
			int temp;
			int KwLenth = keyword.Length;
			int Key = 0;
			for (int y = 0; y < x; y++)
			{
				if (task == "E")
				{
					temp = plaintext[y] + keyword[Key];
					cyphertext = cyphertext + (char)temp;
				}
				else if (task == "D")
				{
					temp = plaintext[y] - keyword[Key];
					cyphertext = cyphertext + (char)temp;
				}
				++Key;
				if (Key == KwLenth)
				{
					Key = 0;
				}
			}
			Output.Text = cyphertext;
		}

        private void Current_Task_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Current_Task.SelectedIndex == 0 )
            {
				task = "E";
				texttype.Text = "Plaintext";
				texttype2.Text = "Cyhertext";
			}
			else if (Current_Task.SelectedIndex == 1)
			{
				task = "D";
				texttype.Text = "Cyhertext";
				texttype2.Text = "Plaintext";
			}
		}

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
			plaintext = Input.Text;
		}
        private void KeywordInput_TextChanged(object sender, TextChangedEventArgs e)
        {
			keyword = KeywordInput.Text;
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
			plaintext = Input.Text;
			keyword = KeywordInput.Text;
			Encyptor();
        }
    }
	
}

