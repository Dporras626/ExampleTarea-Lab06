﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTarea
{
    public class Group : List<Item>
    {
        public string Title { get; set; }

        public Group(string title)
        {
            Title = title;
        }
    }
}