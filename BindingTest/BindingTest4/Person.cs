using System.ComponentModel;



namespace INotifyTest
{



    public class Person : INotifyPropertyChanged
    {



        private string name;





        // Declare the event 



        public event PropertyChangedEventHandler PropertyChanged;


 

        public Person() { }





        public Person(string value) { this.name = value; }



        //아래 PersonName 속성 값이 변경되면



        public string PersonName



        {



            get { return name; }



            set



            {



                name = value;



                // Call OnPropertyChanged whenever the property is updated 



                OnPropertyChanged("PersonName");


            }



        }



        // Create the OnPropertyChanged method to raise the event 



        protected void OnPropertyChanged(string name)



        {



            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));



        }



    }



}