﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreB.Models.DTO.Requests
{
    public class AddMovieRequest
    {
        public string Title { get; set; }

        public int Year { get; set; }
    }
}
