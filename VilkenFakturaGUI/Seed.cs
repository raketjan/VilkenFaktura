using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilkenFakturaGUI.Entities;

namespace VilkenFakturaGUI
{
    public class Seed
    {
        public static Invoice[] cramo = new Invoice[]
            {
                new Invoice() { Id = 1, Name = "Korv", Cost = 237600 },
                new Invoice() { Id = 2, Name = "Sallad", Cost =  33000 },
                new Invoice() { Id = 3, Name = "Cykelslang", Cost =  33000 },
                new Invoice() { Id = 4, Name = "", Cost =  136400 },
                new Invoice() { Id = 5, Name = "", Cost =  42000 },
                new Invoice() { Id = 6, Name = "", Cost =  11060 },
                new Invoice() { Id = 7, Name = "", Cost =  42000 },
                new Invoice() { Id = 8, Name = "", Cost =  11060 },
                new Invoice() { Id = 9, Name = "", Cost =  42000 },
                new Invoice() { Id = 10, Name = "", Cost =  55000 },
                new Invoice() { Id = 11, Name = "", Cost =  15400 },
                new Invoice() { Id = 12, Name = "", Cost =  27300 },
                new Invoice() { Id = 13, Name = "", Cost =  39600 },
                new Invoice() { Id = 14, Name = "", Cost =  15400 },
                new Invoice() { Id = 15, Name = "", Cost =  201300 },
                new Invoice() { Id = 16, Name = "", Cost =  106700 },
                new Invoice() { Id = 17, Name = "", Cost =  55000 },
                new Invoice() { Id = 18, Name = "", Cost =  55000 },
                new Invoice() { Id = 19, Name = "", Cost =  600 },
                new Invoice() { Id = 20, Name = "", Cost =  37345 },
                new Invoice() { Id = 21, Name = "", Cost =  55000 },
                new Invoice() { Id = 22, Name = "", Cost =  55000 },
                new Invoice() { Id = 23, Name = "", Cost =  106700 },
                new Invoice() { Id = 24, Name = "", Cost =  70400 },
                new Invoice() { Id = 25, Name = "", Cost =  76000 },
                new Invoice() { Id = 26, Name = "", Cost =  100000 },
                new Invoice() { Id = 27, Name = "", Cost =  16000 },
                new Invoice() { Id = 28, Name = "", Cost =  22000 },
                new Invoice() { Id = 29, Name = "", Cost =  53350 },
                new Invoice() { Id = 30, Name = "", Cost =  60500 },
                new Invoice() { Id = 31, Name = "", Cost =  75000 },
                new Invoice() { Id = 32, Name = "", Cost =  27500 },
                new Invoice() { Id = 33, Name = "", Cost =  14000 },
                new Invoice() { Id = 34, Name = "", Cost =  60500 },
                new Invoice() { Id = 35, Name = "", Cost =  112035 },
                new Invoice() { Id = 36, Name = "", Cost =  63360 },
                new Invoice() { Id = 37, Name = "", Cost =  90695 },
                new Invoice() { Id = 38, Name = "", Cost =  75000 },
                new Invoice() { Id = 39, Name = "", Cost =  69355 },
                new Invoice() { Id = 40, Name = "", Cost =  13750 },
                new Invoice() { Id = 41, Name = "", Cost =  26675 },
                new Invoice() { Id = 42, Name = "", Cost =  110000 }
            };

        public static Decimal cramosum = 1592800;

        public static Invoice[] minitest = new Invoice[]
        {
            new Invoice() { Name = "", Cost =  1 },
            new Invoice() { Name = "", Cost =  1 },
            new Invoice() { Name = "", Cost =   3 },
            new Invoice() { Name = "", Cost =  2 },
            new Invoice() { Name = "", Cost =  1 }
        };

        public static Decimal minitestsum = 6;

        public static Invoice[] test60 = new Invoice[]
        {
            new Invoice() { Name = "", Cost =  142 },
            new Invoice() { Name = "", Cost =  53422 },
            new Invoice() { Name = "", Cost =  433 },
            new Invoice() { Name = "", Cost =  525 },
            new Invoice() { Name = "", Cost =  43242 },
            new Invoice() { Name = "", Cost =  53245 },
            new Invoice() { Name = "", Cost =  666 },
            new Invoice() { Name = "", Cost =  345 },
            new Invoice() { Name = "", Cost =  5436 },
            new Invoice() { Name = "", Cost =  43253 },
            new Invoice() { Name = "", Cost =  5233 },
            new Invoice() { Name = "", Cost =  5632},
            new Invoice() { Name = "", Cost =  5324},
            new Invoice() { Name = "", Cost =  1232},
            new Invoice() { Name = "", Cost =  7677 },
            new Invoice() { Name = "", Cost =  88 },
            new Invoice() { Name = "", Cost =  534245 },
            new Invoice() { Name = "", Cost =  34 },
            new Invoice() { Name = "", Cost =  76 },
            new Invoice() { Name = "", Cost =  53141 },
            new Invoice() { Name = "", Cost =  2 },
            new Invoice() { Name = "", Cost =  87686 },
            new Invoice() { Name = "", Cost =  4364 },
            new Invoice() { Name = "", Cost =  43211 },
            new Invoice() { Name = "", Cost =  53577 },
            new Invoice() { Name = "", Cost =  32 },
            new Invoice() { Name = "", Cost =  23 },
            new Invoice() { Name = "", Cost =  532532 },
            new Invoice() { Name = "", Cost =  6364 },
            new Invoice() { Name = "", Cost =  364 },
            new Invoice() { Name = "", Cost =  534 },
            new Invoice() { Name = "", Cost =  6345 },
            new Invoice() { Name = "", Cost =  5433 },
            new Invoice() { Name = "", Cost =  43 },
            new Invoice() { Name = "", Cost =  5325 },
            new Invoice() { Name = "", Cost =  543 },
            new Invoice() { Name = "", Cost =  7776 },
            new Invoice() { Name = "", Cost =  7544 },
            new Invoice() { Name = "", Cost =  2222 },
            new Invoice() { Name = "", Cost =  376437 },
            new Invoice() { Name = "", Cost =  423453 },
            new Invoice() { Name = "", Cost =  987 },
            new Invoice() { Name = "", Cost =  57657 },
            new Invoice() { Name = "", Cost =  22234 },
            new Invoice() { Name = "", Cost =  4332 },
            new Invoice() { Name = "", Cost =  5435 },
            new Invoice() { Name = "", Cost =  3646 },
            new Invoice() { Name = "", Cost =  24324 },
            new Invoice() { Name = "", Cost =  26463 },
            new Invoice() { Name = "", Cost =  8541 }
        };

        public static Decimal testsum = 2235458;
    }
}
