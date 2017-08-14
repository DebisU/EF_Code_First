using EF_Code_First_Try.Controller;
using EF_Code_First_Try.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_Code_First_Try
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookController controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new BookController();
            LoadToGrid();
        }

        private void BtInsert_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book()
            {
                BookID = TransformStringIntoInt(TbBookId.Text),
                BookName = TbBookName.Text,
                ISBN = TbISBN.Text,
            };


            Book createdBook = controller.Create(book);
            MessageBox.Show("The book with " + createdBook.ToString() + " has been created successfully.");
            LoadToGrid();
        }

        private void BtUpdate_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book()
            {
                BookID = TransformStringIntoInt(TbBookId.Text),
                BookName = TbBookName.Text,
                ISBN = TbISBN.Text
            };

            Book editedBook = controller.Edit(book.BookID, book);
            MessageBox.Show("The book with " + editedBook.ToString() + " has been updated successfully.");
            LoadToGrid();
        }

        private void BtDelete_Click(object sender, RoutedEventArgs e)
        {
            Book seletedBook = dataGrid.SelectedItems[0] as Book;
            int selectedId = !string.IsNullOrEmpty(TbBookId.Text) ? TransformStringIntoInt(TbBookId.Text) : seletedBook.BookID ;
            
            Book deletedBook = controller.Delete(selectedId);
            MessageBox.Show("The book with " + deletedBook.ToString() + "has been deleted succesfully");
            LoadToGrid();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TbBookId.Text = ((Book)dataGrid.SelectedItem).BookID.ToString();
            TbBookName.Text = ((Book)dataGrid.SelectedItem).BookName;
            TbISBN.Text = ((Book)dataGrid.SelectedItem).ISBN.ToString();

        }

        private void LoadToGrid()
        {
            var load = controller.Index();
            if (load != null)
            {
                dataGrid.ItemsSource = load.ToList();
            }
        }

        private int TransformStringIntoInt(string input)
        {
            int output;
            int.TryParse(input, out output);
            return output;
        }
    }
}
