using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Library
{
    class BookViewModel : INotifyPropertyChanged
    {
        
        private Book selectedBook { get; set; }
        public ObservableCollection<Book> Books { get; set; }


#region Commands
        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Book book = new Book();
                      book.Name = "New Book";
                      Books.Insert(0, book);
                      
                      selectedBook = book;
                  using (BooksContext context = new BooksContext())
                      {
                          context.Books.Add(SelectedBook);
                      }
                  }));
            }
        }

        // команда удаления
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Book book = obj as Book;
                      if (book != null)
                      {
                          Books.Remove(book);
                      }
                  },
                 (obj) => Books.Count > 0));
            }
        }
        public RelayCommand SaveChangesCommand { get; set; }
        #endregion
        #region Properties
        public int Id
        {
            get
            {
                return SelectedBook.id;
            }
            set
            {
                SelectedBook.id = value;
                OnPropertyChanged("Id");
            }      
        }
        public string Name
        {
            get
            {
                return SelectedBook.Name;
            }
            set
            {
                SelectedBook.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Autor
        {
            get
            {
                return SelectedBook.Autor;
            }
            set
            {
                SelectedBook.Autor = value;
                OnPropertyChanged("Autor");
            }
        }
        public string Cover
        {
            get
            {
                return SelectedBook.Cover;
            }
            set
            {
                SelectedBook.Cover = value;
                OnPropertyChanged("Cover");
            }
        }
        public string Genge
        {
            get
            {
                return SelectedBook.Genge;
            }
            set
            {
                SelectedBook.Genge = value;
                OnPropertyChanged("Genge");
            }
        }
        public string Publisher
        {
            get
            {
                return SelectedBook.Publisher;
            }
            set
            {
                SelectedBook.Publisher = value;
                OnPropertyChanged("Publisher");
            }
        }
        public string Language
        {
            get
            {
                return SelectedBook.Language;
            }
            set
            {
                SelectedBook.Language = value;
                OnPropertyChanged("Language");
            }
        }
        public int? Price
        {
            get
            {
                return SelectedBook.Price;
            }
            set
            {
                SelectedBook.Price = value;
                OnPropertyChanged("Price");
            }
        }
        public int? Pages
        {
            get
            {
                return SelectedBook.Pages;
            }
            set
            {
                SelectedBook.Pages = value;
                OnPropertyChanged("Pages");
            }
        }
        public int? Year
        {
            get
            {
                return SelectedBook.Year;
            }
            set
            {
                SelectedBook.Year = value;
                OnPropertyChanged("Year");
            }
        }
        #endregion
        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            using (BooksContext context = new BooksContext())
            {
               // Books = context.Books.ToList();
            }
        }

        private void SaveCustomerChanges()
        {


        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
