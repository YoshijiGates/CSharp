using System.Windows.Forms;
using WinFormMVVM.ViewModels;

namespace WinFormMVVM.Views
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel = new MainViewModel();
        public MainView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AAALabel.DataBindings.Add("Text", _viewModel,nameof(_viewModel.AAALabelText));
            BBBTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.BBBTextBoxText));
            CCCDateTimePicker.DataBindings.Add(nameof(CCCDateTimePicker.Value), _viewModel, nameof(_viewModel.CCCDateTimePickerValue));
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            _viewModel.Update();
        }
    }
}
