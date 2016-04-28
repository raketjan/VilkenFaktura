using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VilkenFakturaGUI.Entities;

namespace VilkenFakturaGUI
{
    /// <summary>
    /// Interaction logic for VilkenFakturaHome.xaml
    /// </summary>
    public partial class VilkenFakturaHome : Page
    {
        private Decimal _sum = 1.00M;
        public Decimal Sum
        {
            get { return _sum; }
            set
            {
                if (value != _sum)
                {
                    // I Always want to store 2 decimals. There is probably a much better way to do this...
                    int decimals = BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
                    if (decimals == 0)
                        _sum = value * 1.00M;
                    else if (decimals == 1)
                        _sum = value * 1.0M;
                    else
                        _sum = Decimal.Round(value, 2);                    
                    onPropertyChanged("Sum");
                }
            }
        }
        private ObservableCollection<Invoice> _invoicesList;
        public ObservableCollection<Invoice> InvoicesList
        {
            get { return _invoicesList; }
            set
            {
                _invoicesList = value;
                onPropertyChanged("InvoicesList");
            }
        }
        private int maxId;

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string propertyname)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public VilkenFakturaHome()
        {
            InitializeComponent();
            
            if (InvoicesList == null)
            {
                //InvoicesList = new ObservableCollection<Invoice>(Seed.cramo);
                InvoicesList = new ObservableCollection<Invoice>();
                maxId = InvoicesList.Count;
                invoiceListBox.DataContext = InvoicesList;
                SumTextBox.DataContext = this;
                Sum = 0;
                //NewInvoiceName.Focus();
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (InvoicesList.Count == 0)
                return;
            Calculate_Button.Content = "Räknar...";
            string result = Calculate.Process(InvoicesList, Sum);
            Results.Text = result;
            MainTabControl.SelectedIndex = 1;
            Calculate_Button.Content = "Beräkna";
            //VilkenFakturaReportPage vilkenFakturaReportPage = new VilkenFakturaReportPage(result);

            //this.NavigationService.Navigate(vilkenFakturaReportPage);
        }

        private void NewInvoiceButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewInvoiceCost.Text == "")
            {
                MessageBox.Show("Du måste ange en kostnad för fakturaposten.");
                return;
            }
            Decimal? kostnad = ToDecimal(NewInvoiceCost.Text);
            if (kostnad == null)
            {
                MessageBox.Show("Felaktigt format på kostnaden");
                return;
            }
            Invoice newInvoice = new Invoice()
            {
                Name = NewInvoiceName.Text,
                Cost = (Decimal)kostnad,
                Id = ++maxId
            };
            InvoicesList.Add(newInvoice);
            NewInvoiceCost.Text = "";
            NewInvoiceName.Text = "";
            NewInvoiceName.Focus();
        }
        private Decimal? ToDecimal(string dec)
        {
            try
            {
                if (dec.Contains(","))
                    return Decimal.Parse(dec);
                else
                    return Decimal.Parse(dec) * 1.00M;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); 
            dlg.DefaultExt = ".xml";
            dlg.Filter = "Xml filer (.xml)|*.xml";
            dlg.Title = "Öppna fil";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                InvoicesList = IOHelper.LoadFile(dlg.FileName);
                invoiceListBox.DataContext = InvoicesList;
                maxId = InvoicesList.OrderBy(i => i.Id).Last().Id;
            }            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.RestoreDirectory = true;
            sfd.DefaultExt = ".xml";
            sfd.Title = "Spara fakturabelopp";
            sfd.Filter = "Xml filer (.xml)|*.xml";
            Nullable<bool> result = sfd.ShowDialog();
            if (result == true)
            {
                IOHelper.SaveFile(InvoicesList, Sum, sfd.FileName);
            }
        }
        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Txt filer (.txt)|*.txt";
            dlg.Title = "Importera fakturabelopp";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                InvoicesList = IOHelper.ImportFile(dlg.FileName);
                invoiceListBox.DataContext = InvoicesList;
                maxId = InvoicesList.OrderBy(i => i.Id).Last().Id;
            }
        }

        private void DeleteRow_Click(object sender, RoutedEventArgs e)
        {
            int id = (((Button)sender).DataContext as Invoice).Id;
            Invoice invoice = InvoicesList.First<Invoice>(i => i.Id == id);
            InvoicesList.Remove(invoice);
        }
    }

    
}
