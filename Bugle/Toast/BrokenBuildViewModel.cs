﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace SevanConsulting.Bugle.Toast
{
    public class BrokenBuildViewModel:PropertyChangedBase
    {
        public string BuildMessage { get; set; }
        public string Heading { get; set; }

        public BrokenBuildViewModel()
        {
            
        }

    }
}
