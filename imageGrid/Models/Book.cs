using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageGrid.Models
{
    public class Book
    {
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            string[] carga = new string[6] { "Assets/img_1.png",
                                             "Assets/img_2.jpg",
                                             "Assets/img_3.jpg",
                                             "Assets/img_4.jpg",
                                             "Assets/img_5.jpg",
                                             "Assets/img_6.jpg"
            };
            

            books.Add(new Book { CoverImage = carga[0] });
            books.Add(new Book { CoverImage = carga[1] });
            books.Add(new Book { CoverImage = carga[2] });
            books.Add(new Book { CoverImage = carga[3] });
            books.Add(new Book { CoverImage = carga[4] });
            books.Add(new Book { CoverImage = carga[5] });

            return books;
        }
    }
}
