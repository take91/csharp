using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace CommandPattern
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public Emp _SelectedEmp;
        public Emp SelectedEmp
        {
            get { return _SelectedEmp; }
            set
            {
                _SelectedEmp = value;
                OnPropertyChanged("SelectedEmp");
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string PName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PName));
        }

        public RelayCommand AddEmpCommand { get; set; }
        public ObservableCollection<Emp> Emps { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            Emps = new ObservableCollection<Emp>();

            Emps.Add(new Emp { Ename = "홍길동", job = "Designer" });
            Emps.Add(new Emp { Ename = "김길동", job = "Programmer" });
            Emps.Add(new Emp { Ename = "정길동", job = "Teacher" });
            Emps.Add(new Emp { Ename = "박길동", job = "Doctor" });
            Emps.Add(new Emp { Ename = "성길동", job = "President" });

            AddEmpCommand = new RelayCommand(AddEmp);
        }

        public void AddEmp(object param)
        {
            Emps.Add(new Emp
            {
                Ename = param.ToString().Contains(",") ? param.ToString().Substring(0,param.ToString().IndexOf(',')) : param.ToString()
                               ,
                job = param.ToString().Contains(",") ? param.ToString().Substring(param.ToString().IndexOf(',') + 1) : "무직"
            });
        }

    }
}
