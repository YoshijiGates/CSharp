using System;
using WinFormMVVM.ViewModels;

namespace WinFormMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _aaaLabelText = "AAALAbelText";
        private string _bbbTextBoxText = "BBBTextBoxText";
        private DateTime _cccTextBoxText = DateTime.Now;
        public string AAALabelText
        {
            get { return _aaaLabelText; }
            set
            {
                SetProperty(ref _aaaLabelText, value);
            }
        }

        public string BBBTextBoxText
        {   get { return _aaaLabelText; }
            set
            {
                SetProperty(ref _bbbTextBoxText, value);
            }
        }

        public DateTime CCCDateTimePickerValue
        {
            get { return _cccTextBoxText; }
            set
            {
                SetProperty(ref _cccTextBoxText, value);
            }
        }
        internal void Update()
        {
            AAALabelText = "Update AAALabelText";
            BBBTextBoxText = "Update BBBTextBoxText";
            CCCDateTimePickerValue = DateTime.Now;
        }
    }
}
