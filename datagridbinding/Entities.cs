using System;
using System.Collections.Generic;

namespace datagridbinding
{
    public class LineItem
    {
        public decimal QTY { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }

    public class SalesInvoice
    {
        public SalesInvoice()
        {
            ID = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public bool Approved { get; set; }
        //public List<LineItem> Items { get; set; }
        public DateTime Date { get; set; }
        public int Serial { get; set; }
        public byte Status { get; set; }
        public Guid ID { get; set; }
        //public State InvoiceState { get; set; }
    }
}
