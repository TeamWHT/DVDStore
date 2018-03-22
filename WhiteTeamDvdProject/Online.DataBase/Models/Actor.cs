using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Online.DataBase.Models
{
    public class Actor
    {
        public Actor()
        {
            this.DVD_ID = new HashSet<DVD>();
        }
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<DVD> DVD_ID { get; set; }
    }
}
