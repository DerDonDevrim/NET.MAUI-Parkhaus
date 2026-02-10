using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausApp
{
    public class Ticket
    {
        public Ticket() { }

        public int ticketNr { get; set; }
        public double price { get; set; }
        public DateTime entryTime { get; set; }
        public bool isPaid { get; set; }


    } 
        
        
    }

