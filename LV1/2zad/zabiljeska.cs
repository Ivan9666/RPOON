using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novakonzolnaaplikacija
{
    class zabiljeska
    {public static int PRIORITY_LOW = 10;
     public static int PRIORITY_MEDIUM = 5;
     public static int PRIORITY_HIGH = 1;

        private int priority;
        private String description;
        private String author;

        public int Priority { 
            get { return priority; }
            set { this.priority = value; }
        }
        public String Description { 
            get { return description; }
            set { this.description = value; }
        }
        public String Author { get { return author; } }

        public zabiljeska() {
            this.priority = zabiljeska.PRIORITY_LOW;
            this.description = "Placeholder";
            this.author = "Unknown";
        }
        public zabiljeska(String description, String author, int priority) {
            this.priority = priority;
            this.description = description;
            this.author = author;
        }
        public zabiljeska(zabiljeska reference)
        {
            this.priority = reference.priority;
            this.description = reference.description;
            this.author = reference.author;
        }
    }
}
