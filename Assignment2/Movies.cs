using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }

        public Movies(int movieId, string movieName, string language)
        {
            MovieId = movieId;
            MovieName = movieName;
            Language = language;
        }
    }

    class Customer
    {
        public int CustId { get; set; }
        public DateTime BorrowDate { get; set; }
        public int MovieId { get; set; }
        public DateTime ReturnDate { get; set; }

        public Customer(int custId, DateTime borrowDate, int movieId)
        {
            CustId = custId;
            BorrowDate = borrowDate;
            MovieId = movieId;
            ReturnDate = borrowDate.AddDays(10);
        }

        public void Borrow()
        {
            if (ReturnDate <= DateTime.Now)
            {
                Console.WriteLine($"Customer {CustId} has not returned the movie in time.");
                // Add to a list of overdue movies or take appropriate action.
            }
            else
            {
                Console.WriteLine($"Customer {CustId} has successfully borrowed the movie.");
            }
        }
    }
}