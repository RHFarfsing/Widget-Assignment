﻿using System;
using System.Collections.Generic;

namespace Widget_Assinment {
    class Program {
        static void Main(string[] args) {
            var widgets = new List<IProduct>();
            for(var idx = 0; idx < 3; idx++) {
                widgets.Add(new BronseWidget());
            }
            for(var idx2 = 0; idx2 < 7; idx2++) {
                widgets.Add(new SilverWidget());
            }
            for (var idx3 = 0; idx3 < 9; idx3++) {
                widgets.Add(new GoldWidget());
            }
            var total = 0.0;
            foreach(var widget in widgets) {
                total += widget.GetPrice();
            }
            Console.WriteLine($"Total is {total}");
        }
        
    }
}


