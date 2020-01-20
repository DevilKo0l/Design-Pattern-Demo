﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
