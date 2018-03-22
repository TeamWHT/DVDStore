﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DVDStore.DataBase.Models
{
    public class DVD
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string TimeLength { get; set; }
        public string Language { get; set; }
        public string Rating { get; set; }
        public int Sold { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Actor> Actor_ID { get; set; }

    }
}
