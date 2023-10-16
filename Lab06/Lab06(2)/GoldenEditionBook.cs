using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, float price) : base(title, author, price)
        {

        }

        public override float Price
        {
            get => base.Price * (float)1.3;

        }
    }
}
