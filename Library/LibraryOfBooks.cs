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
    class LibraryOfBooks : INotifyPropertyChanged
    {
        SqlConnection connection = new SqlConnection();
        private Book selectedBook;
        public ObservableCollection<Book> Books { get; set; }

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
                      Books.Insert(0, book);
                      selectedBook = book;
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

        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public LibraryOfBooks()
        {
            Books = new ObservableCollection<Book>
            {

            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
