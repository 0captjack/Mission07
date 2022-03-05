using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();
        //model for Shopping Cart and controller for the cart line item??
        public virtual void AddItem (Book book, int qty)
        {
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();
            
            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                Book = book,
                Quantity = qty,
                Price = book.Price
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem (Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearCart ()
        {
            Items.Clear();
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Price); //book.price 
            return sum;
        }
    }

    public class CartLineItem
    { //model
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
    }
}
