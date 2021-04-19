﻿using BlazorFluentUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentUI.Demo.Shared.Models
{
    class RibbonItem :IRibbonItem
    {
        public string? Text { get; set; }
        public double Priority { get; set; }
    }
}
