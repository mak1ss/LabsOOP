using System.Text;
using System.Text.RegularExpressions;

namespace Lab06
{

    public class Book
    {
        protected float price;
        protected string title;
        protected string author;

        public Book(string title, string author, float price)
        {
            this.Price = price;
            this.Author = author;
            this.Title = title;
        }

        public virtual float Price
        {
            get => this.price;
            set => this.price = value > 0 ? value : throw new ArgumentException("Price is not valid");
        }

        public string Title
        {
            get => this.title;
            set => this.title = value.Length > 3 ? value : throw new ArgumentException("Title is not valid");
        }

        public string Author
        {
            get => this.author;
            set => this.author = !Regex.IsMatch(value, @"^\S+\s+(\d\w*)") ? value : throw new ArgumentException("Author not valid");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");
            return builder.ToString();
        }
    }
}
