using DVDStore.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDStore.DataBase.Models
{
    public class Actor
    {
        public Actor()
        {
            this.DVD_Title = new HashSet<DVD>();
        }
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<DVD> DVD_Title { get; set; }
    }
}
