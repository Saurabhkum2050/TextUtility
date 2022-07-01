namespace TextUtility
{
    public partial class TextUtilityForm : Form
    //public partial class TextUtilityForm : MaterialForm
    {
        int DefaultMaxLength = 10000;
        public TextUtilityForm()
        {
            InitializeComponent();

            // Theme
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            FormatTypes.Text = "lower case";
            TextData.MaxLength = DefaultMaxLength;
        }

        private void TextData_TextChanged(object sender, EventArgs e)
        {
            string data = TextData.Text;
            switch (FormatTypes.SelectedItem.ToString())
            {
                case "lower case":
                    TextData.Text = data.ToLower();
                    break;
                case "Sentence case":
                    TextData.Text = SentenceCase(data);
                    break;
                case "Title Case":
                    TextData.Text = TitleCase(data);
                    break;
                case "UPPER CASE":
                    TextData.Text = data.ToUpper();
                    break;
            }

            TextData.SelectionStart = TextData.Text.Length;
            TextData.SelectionLength = 0;
            LabelCharacterCount.Text = "Word Count: " + data.Length.ToString().PadLeft(4, '0') + " / " + DefaultMaxLength;
            NumOfSpaces.Text = "Spaces: " + CountRepeatingCharacter(data, ' ').ToString().PadLeft(3, '0');
            NumOfNumbers.Text = "Numbers: " + CountNumbers().ToString().PadLeft(3, '0');
            NumOfCharacters.Text = "Alphabets: " + CountAlphabets().ToString().PadLeft(3, '0');
        }

        private int CountNumbers()
        {
            int numberCount = 0;
            List<char> numbers = "0123456789".ToList();
            numbers.ForEach(n => numberCount += CountRepeatingCharacter(TextData.Text, n));
            return numberCount;
        }

        private int CountAlphabets()
        {
            int numberCount = 0;
            List<char> smallLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToList();
            List<char> capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            smallLetters.ForEach(n => numberCount += CountRepeatingCharacter(TextData.Text, n));
            capitalLetters.ForEach(n => numberCount += CountRepeatingCharacter(TextData.Text, n));
            return numberCount;
        }

        private int CountRepeatingCharacter(string text, char c)
        {
            int count = 0;
            int textLength = text.Length;
            for (int i = 0; i < textLength; i++)
            {
                if (c == text[i])
                {
                    count++;
                }
            }
            return count;
        }

        private static string SentenceCase(string input)
        {
            if (input.Length < 1) return input;
            string textData = input.ToLower();
            return textData[0].ToString().ToUpper() + textData.Substring(1);
        }

        private static string TitleCase(string input)
        {
            if (input.Length < 1) return input;
            string textData = "";
            string[] textDataList = input.ToLower().Split(" ");

            for (int i = 0; i < textDataList.Length; i++)
            {
                if (textDataList[i].Length > 0)
                {
                    if (i > 0) textData += " ";
                    textData += textDataList[i][0].ToString().ToUpper() + textDataList[i].Substring(1);
                }
            }

            if (input.EndsWith(" ")) textData += " ";
            return textData;
        }

        private void TextUtilityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseApp() == false) e.Cancel = true;
        }

        private static bool CloseApp()
        {
            const string message = "Are you sure that you would like to exit text utility ?";
            const string caption = "Exit Text Utility";
            var result = MessageBox.Show(
                message,
                caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            return result == DialogResult.Yes;
        }
    }
}