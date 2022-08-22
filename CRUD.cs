using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_BookManagementSystem
{
    interface CRUD
    {
        /// <summary>
        ///To add a new user input record to the database where it is stored
        /// </summary>
        /// <param name="book">a book type object (record) to add to the database</param>
        void AddRecord(Book book);

        /// <summary>
        /// To delete a user selected record from the database where it is stored
        /// </summary>
        /// <param name="book">a book type object (record) to delete from the database</param>
        void DeleteRecord(Book book);

        /// <summary>
        /// To edit/update a user selected record in the database where it is stored
        /// </summary>
        /// <param name="isbn">the ISBN of the book record that needs to be updated</param> 
        /// /// <param name="book">the updated book record that you want to replace the old one with</param>
        void UpdateRecord(long isbn, Book book);

        /// <summary>
        /// To find a record in the database when the ISBN is given as argument and return the record as a book object
        /// </summary>
        /// <param name="isbn">the ISBN of the book user wants to find</param>
        /// <returns>the found book object or null if a record with the given isbn is not found</returns>
        Book FindRecord(long isbn);

        /// <summary>
        /// Gets all the book records from the database and returns it as an ICollection list
        /// </summary>
        /// <returns>ICollection list of type book consisting of all Book records in our database</returns>
        ICollection<Book> GetAllRecords();

        /// <summary>
        /// To search for a passed ISBN in the database to see if it is already in the database
        /// </summary>
        /// <param name="isbn">the book ISBN string</param>
        /// <returns>Boolean true if given ISBN is in the database records, and false if not</returns>
        bool ISBNInDatabase(long isbn); //to check if the passed isbn is already in database
    }
    class BookRepo : CRUD
    {
        BookDBEntities entities;

        public BookRepo()
        {
            entities = new BookDBEntities();
        }
        public void AddRecord(Book book)
        {
            entities.Books.Add(book); //add book object to the DBSet ready to be updated to db
            entities.SaveChanges(); //saves changes causing above added object in the DBSet to be added in the actual db
        }

        public void DeleteRecord(Book book)
        {
            entities.Books.Remove(book);  //remove the passed book record from the the DBSet, ready to be removed from the DB
            entities.SaveChanges(); //save changes causing the record deleted in the DBSet to actually be deleted from the DB
        }
        public void UpdateRecord(long isbn, Book book)
        {
            //the reason we pass the isbn and the Book object that already has a isbn in it separately is in case the isbn itself was
            //what needed to be updated isbn holds the old isbn of that record and book.ISBN will be the updated ISBN
            Book bookToUpdate = entities.Books.Find(isbn);  //get the record to be updated in the DBSet and store it in temp variable bookToUpdate
            bookToUpdate.ISBN = book.ISBN; //assign the updated property values passed in the book variable to our DBSet record through bookTOUPdate variable
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.ReleaseDate = book.ReleaseDate;
            //if(bookToUpdate.ISBN == isbn)   //meaning we are not updating primary key value
            entities.SaveChanges(); //save changes causing the updated record in the DBSet to actually be updated in the DB
        }

        public Book FindRecord(long isbn)
        {
            return entities.Books.Find(isbn); //searches for the passed ISBN in the DBSet. If found returned, else returns null
        }

        public ICollection<Book> GetAllRecords()
        {
            return entities.Books.ToList();  //gets and returns all book records from our DBSet which gets it from the actual db
        }

        public bool ISBNInDatabase(long isbn)
        {
            Book temp = entities.Books.Find(isbn); //LHS: temporary book record to hold search result
                                                //RHS: seraches for a record with the given isbn, if not found returns null
            if (temp == null)   //if temp record is null, means record with that isbn not found
                return false;   //then return false for ISBNInDatabase
            else
                return true;    //otherwise (if found), return true for ISBNInDatabase
        }
    }
}
