﻿using AbstartFactory;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Menu;

namespace Restaurant.Task1.Factory
{
    public interface IMenuMaker
    {
        public RestourantMenu CreateMenu();

    }
}
