using OnelineBookStoreAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.DAL
{
   
    public class OnlineBookStoreDBInitializer 
    {
        public OnlineBookStoreDBInitializer(OnelineBookStoreDBContext context)
        {
            Seed(context);
        }

        protected void Seed(OnelineBookStoreDBContext context)
        {
            IList<UserDAO> defaultUsers = new List<UserDAO>();

            defaultUsers.Add(new UserDAO() { UserID = "1", UserName = "John", UserEmail = "johm@gmail.com" , UserPhoneNumber="9902112345", Password = "abc@12345"});
            defaultUsers.Add(new UserDAO() { UserID = "2", UserName = "Vijay", UserEmail = "vijay@gmail.com", UserPhoneNumber = "9902112346", Password = "abc@23456" });
            defaultUsers.Add(new UserDAO() { UserID = "3", UserName = "Raj", UserEmail = "raj@gmail.com", UserPhoneNumber = "9902112347", Password = "abc@34567" });

            context.Users = new List<UserDAO>();
            context.Users.AddRange(defaultUsers);

            IList<BooksDAO> avilableBooks = new List<BooksDAO>();

            avilableBooks.Add(new BooksDAO() { BookID = 100001, BookTitle = "Harry Potter Deathly Hallows Part 1", AuthorName= "J. K. Rowling", BookSourceImagePath = "../assets/images/DeathlyHallows1.jpg", BookPrice = 100.00, BookShortDescription = "After Voldemort takes over the Ministry of Magic, Harry, Ron and Hermione are forced into hiding. They try to decipher the clues left to them by Dumbledore to find and destroy Voldemort's Horcruxes.", BookLongDescription = "After Voldemort takes over the Ministry of Magic, Harry, Ron and Hermione are forced into hiding. They try to decipher the clues left to them by Dumbledore to find and destroy Voldemort's Horcruxes." });

            avilableBooks.Add(new BooksDAO() { BookID = 100002, BookTitle = "Harry Potter Deathly Hallows Part 2", AuthorName = "J. K. Rowling", BookSourceImagePath = "../assets/images/DeathlyHallows2.jpg", BookPrice = 110.00, BookShortDescription = "Harry, Ron and Hermione race against time to destroy the remaining Horcruxes. Meanwhile, the students and teachers unite to defend Hogwarts against Lord Voldemort and the Death Eaters.", BookLongDescription = "Harry, Ron and Hermione race against time to destroy the remaining Horcruxes. Meanwhile, the students and teachers unite to defend Hogwarts against Lord Voldemort and the Death Eaters." });
            
            avilableBooks.Add(new BooksDAO() { BookID = 100003, BookTitle = "Harry Potter Philosopers Stone", AuthorName = "J. K. Rowling", BookSourceImagePath = "../assets/images/PhilosopersStone.jpg", BookPrice = 99.00, BookShortDescription = "The philosopher's stone, or stone of the philosophers is a legendary alchemical substance capable of turning base metals such as mercury into gold or silver. It is also called the elixir of life, useful for rejuvenation and for achieving immortality; for many centuries, it was the most sought goal in alchemy. ", BookLongDescription = "The philosopher's stone, or stone of the philosophers is a legendary alchemical substance capable of turning base metals such as mercury into gold or silver. It is also called the elixir of life, useful for rejuvenation and for achieving immortality; for many centuries, it was the most sought goal in alchemy." });

            avilableBooks.Add(new BooksDAO() { BookID = 100004, BookTitle = "Harry Potter SorcererStone Part 1", AuthorName = "J. K. Rowling", BookSourceImagePath = "../assets/images/SorcererStone1.jpg", BookPrice = 110.00, BookShortDescription = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.", BookLongDescription = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him." });

            avilableBooks.Add(new BooksDAO() { BookID = 100005, BookTitle = "Harry Potter SorcererStone Part 2", AuthorName = "J. K. Rowling", BookSourceImagePath = "../assets/images/SorcererStone2.jpg", BookPrice = 110.00, BookShortDescription = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.", BookLongDescription = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him." });

            context.Books = new List<BooksDAO>();
            context.Books.AddRange(avilableBooks);

            context.Orders = new List<OrderDAO>();
        }
    }
}
