using MauiAppTutorial2.Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Mvvm.ViewModels
{
    public class TimesViewModel
    {
        public List<Time> Times { get; set; }

        public TimesViewModel()
        {
            Times = [
                new("Real Madrid", "real.png"),
                new("Manchester City", "man_city.png"),
                new("Milan", "milan.png"),
                new("Nápoli", "napoli.png"),
                new("Chelsea", "chelsea.png"),
                new("Bayer", "bayern.png"),
                new("Benfica", "benfica.png"),
                new("PSG", "psg.png"),
                new("Barcelona", "barca.png")
            ];
        }
    }
}
