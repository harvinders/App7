using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using App7.Annotations;

namespace App7.ViewModels
{
    public class NewsViewModel
    {
        public NewsViewModel(string name)
        {
            Name = name;
        }

        ~NewsViewModel()
        {
            Trace.WriteLine($"~NewsViewModel {Name}");
        }

        public string Name { get; }

        public string Image
        {
            get => $"ms-appx:///Assets/Nature-{Name}.jpg";
        }
    }
}
