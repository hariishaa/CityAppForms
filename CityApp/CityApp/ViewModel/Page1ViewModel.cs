﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.ViewModel
{
    public class Page1ViewModel
    {
        public Page1ViewModel(MainViewModel mainViewModel)
        {
            mainViewModel.Title = "Page 1";
        }
    }
}
