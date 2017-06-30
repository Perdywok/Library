using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Library
{
    class Book : INotifyPropertyChanged
    {
        private string name;
        private string autor;
        private string cover;
        private string genge;
        private string publisher;
        private string language;
        private int price;
        private int pages;
        private int year;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
                OnPropertyChanged("Autor");
            }
        }

        public string Cover
        {
            get
            {
                return cover;
            }
            set
            {
                cover = value;
                OnPropertyChanged("Cover");
            }
        }

        public string Genge
        {
            get
            {
                return genge;
            }
            set
            {
                genge = value;
                OnPropertyChanged("Genge");
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
                OnPropertyChanged("Publisher");
            }
        }
        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
                OnPropertyChanged("Language");
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
                OnPropertyChanged("Pages");
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
