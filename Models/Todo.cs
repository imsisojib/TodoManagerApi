﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoManagerApi.Models
{
    public class Todo
    {
        public Guid Id { get; set; }

        public string Tittle { get; set; }

        public string Description { get; set; }
    }
}
