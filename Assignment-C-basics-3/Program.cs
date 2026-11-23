using System.Text;

namespace Assignment_C_basics_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //string Title = "clean code";
            //string upperTitle = Title.ToUpper();
            //Console.WriteLine(Title);
            //Console.WriteLine(upperTitle);
            #endregion
            #region Question 2
            //string s1 = "Clean Code";
            //string s2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(s1, s2));
            #endregion
            #region Question 3
            //StringBuilder List = new StringBuilder();
            //List.Append("Book List");
            //List.Append("- Updated");
            //Console.WriteLine(List);
            #endregion
            #region Question 4
            //List.Replace("Book List", "Library");
            //Console.WriteLine(List);
            #endregion
            #region Question 5
            //string title = "Clean Code";
            int pages = 464;
            //string sentence = "Book: " + title+ ", Pages: "+pages;
            //Console.WriteLine(sentence);
            #endregion
            #region Question 6
            //string sentence2 = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(sentence2);
            #endregion
            #region Question 7
            //string sentence3 = String.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(sentence3);
            #endregion
            #region Question 8
            //if(pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion
            #region Question 9
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            //else
            //    Console.WriteLine("You can not borrow this book");
            #endregion
            #region Question 10
            //string title = "Refactoring";
            //string ans = title switch
            //{
            //    "Clean Code" => "Great choice!",
            //    "Refactoring" => "Nice pick!",
            //    _ => "Never heard of it"
            //};
            //Console.Write(ans);
            #endregion
            #region Question 11
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            #endregion
            #region Question 12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion
            #region Question 13
            //int y = 0;
            //while (y < books.Length)
            //{
            //    Console.WriteLine($"{y + 1}. {books[y]}");
            //    y++;
            //}
            #endregion
            #region Question 14
            //int z = 3;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    z--;
            //} while (z > 0);
            #endregion
            #region Question 15
            //foreach(string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion
            #region Question 16
            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //        break;
            //    Console.WriteLine(book);
            //}
            #endregion
            #region Question 17
            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine(book);
            //}
            #endregion
            #region Question 18
            //string PrintFirstBook(string[] books)
            //{
            //    if (books.Length > 0)
            //    {
            //        Console.WriteLine(books[0]);
            //        return "";
            //    }
            //    else
            //        return "";
            //}
            //PrintFirstBook(books);
            #endregion
        }
    }
}
