using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilkenFakturaGUI.Entities
{
    public class Invoice : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Decimal _cost;
        public Decimal Cost
                            { get { return _cost; } 
                                set
            {
                // I Always want to store 2 decimals. There is probably a much better way to do this...
                int decimals = BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
                if (decimals == 0)
                    _cost = value * 1.00M;
                else if (decimals == 1)
                    _cost = value * 1.0M;
                else
                    _cost = Decimal.Round(value, 2);
            }
                            }
        public bool Include { get; set; } = true;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
