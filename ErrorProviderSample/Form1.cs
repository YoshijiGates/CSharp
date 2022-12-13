using System.Text.RegularExpressions;

namespace ErrorProviderSample
{
    public partial class Form1 : Form
    {

        // ErrorProviderのインスタンスを生成
        ErrorProvider errorProvider = new ErrorProvider();

        // 正規表現を生成
        Regex notIntRegex = new Regex(@"[^0-9]"); //数字以外にマッチする

        public Form1()
        {
            InitializeComponent();
            // アイコンを点滅なしに設定する
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }


        /// <summary>
        /// Ageテキストボックスを変更した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = AgeTextBox.SelectionStart;
            AgeTextBox.Text = notIntRegex.Replace(AgeTextBox.Text, "");
            AgeTextBox.SelectionStart = i;
        }

        /// <summary>
        /// Ageテキストボックスの検証コードを呼び出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(AgeTextBox.Text)) {
                // 正常に整数に変換できた場合はエラーをクリアする
                errorProvider.SetError(AgeTextBox, "");
                AgeTextBox.BackColor = Color.White;
            }
        }
        
        /// <summary>
        /// Checkボタンをクリックした時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckButton_Click(object sender, EventArgs e)
        {
            // 必須入力チェック
            if (string.IsNullOrEmpty(AgeTextBox.Text))
            {
                // 例外が発生したのでエラーを表示する
                errorProvider.SetError(AgeTextBox, "Ageは入力必須です");
                AgeTextBox.BackColor = Color.LightPink;

                return;
            }

            MessageBox.Show("入力チェックOK");
        }
    }
}