using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace App7.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<NewsViewModel> ViewModels { get; }
        public MainViewModel()
        {
            ViewModels = new ObservableCollection<NewsViewModel>()
            {
                new NewsViewModel("1"),
                new NewsViewModel("2"),
                new NewsViewModel("3"),
                new NewsViewModel("4"),
                new NewsViewModel("5"),
                new NewsViewModel("6"),
                new NewsViewModel("7"),
                new NewsViewModel("8"),
                new NewsViewModel("9"),
                new NewsViewModel("10"),
                new NewsViewModel("11"),
                new NewsViewModel("12"),
                new NewsViewModel("13")
            };
        }
    }
}
