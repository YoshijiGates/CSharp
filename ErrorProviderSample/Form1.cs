using System.Text.RegularExpressions;

namespace ErrorProviderSample
{
    public partial class Form1 : Form
    {

        // ErrorProvider�̃C���X�^���X�𐶐�
        ErrorProvider errorProvider = new ErrorProvider();

        // ���K�\���𐶐�
        Regex notIntRegex = new Regex(@"[^0-9]"); //�����ȊO�Ƀ}�b�`����

        public Form1()
        {
            InitializeComponent();
            // �A�C�R����_�łȂ��ɐݒ肷��
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }


        /// <summary>
        /// Age�e�L�X�g�{�b�N�X��ύX������
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
        /// Age�e�L�X�g�{�b�N�X�̌��؃R�[�h���Ăяo��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(AgeTextBox.Text)) {
                // ����ɐ����ɕϊ��ł����ꍇ�̓G���[���N���A����
                errorProvider.SetError(AgeTextBox, "");
                AgeTextBox.BackColor = Color.White;
            }
        }
        
        /// <summary>
        /// Check�{�^�����N���b�N������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckButton_Click(object sender, EventArgs e)
        {
            // �K�{���̓`�F�b�N
            if (string.IsNullOrEmpty(AgeTextBox.Text))
            {
                // ��O�����������̂ŃG���[��\������
                errorProvider.SetError(AgeTextBox, "Age�͓��͕K�{�ł�");
                AgeTextBox.BackColor = Color.LightPink;

                return;
            }

            MessageBox.Show("���̓`�F�b�NOK");
        }
    }
}