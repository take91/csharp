using System.ComponentModel;

namespace LoginWindow.Model
{
    class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstname;
        private string _lastname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; RaisePropertyChange("FirstName"); }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; RaisePropertyChange("LastName"); }
        }

        public void RaisePropertyChange(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


    }
}
