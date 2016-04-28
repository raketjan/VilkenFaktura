using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilkenFakturaGUI.Entities;

namespace VilkenFakturaGUI
{
    public static class Calculate
    {
        public static string Process(ObservableCollection<Invoice> invoicelist, Decimal sum)
        {
            // turn into ints...
            var invoices = from invoice in invoicelist
                           where invoice.Include
                           select Convert.ToInt32(invoice.Cost.ToString().Replace(",", ""));
                           ;
            int intsum = Convert.ToInt32(sum.ToString().Replace(",", ""));
            if (intsum == 0)
                return "Summan kan inte vara 0";         
            List<int> trimmedinvoices = invoices.ToList<int>();
            int trimmedzeros = Trim(trimmedinvoices, ref intsum);
            string result = SubsetSum(trimmedinvoices, intsum, trimmedzeros);
            if (result == "")
                return "Fann ingen lösning.";
            else 
                return "Detta är en lösning:\n" + result;
        }

        private static string SubsetSum(IEnumerable<int> list, int s, int trimmedzeros)
        {
            int[] array = list.ToArray<int>();
            Array.Sort<int>(array);
            int num = (from i in array
                       where i < 0
                       select i).Sum();
            int num2 = (from i in array
                        where i > 0
                        select i).Sum();
            string result;
            if (num > s || num2 < s)
            {
                result = "";
            }
            else
            {
                bool[,] array2 = new bool[array.Length + 1, s + 1];
                for (int l = 0; l <= s; l++)
                {
                    array2[0, l] = false;
                }
                for (int j = 1; j <= s; j++)
                {
                    for (int l = 1; l <= array.Length; l++)
                    {
                        bool[,] arg_18D_0 = array2;
                        int arg_18D_1 = l;
                        int arg_18D_2 = j;
                        bool arg_18D_3;
                        if (array[l - 1] != j && !array2[l - 1, j])
                        {
                            if (j - array[l - 1] < (from number in array.Take(l)
                                                    where number < 0
                                                    select number).Sum())
                            {
                                goto IL_189;
                            }
                            if (j - array[l - 1] > (from number in array.Take(l)
                                                    where number > 0
                                                    select number).Sum())
                            {
                                goto IL_189;
                            }
                            arg_18D_3 = array2[l - 1, j - array[l - 1]];
                            goto IL_18D;
                            IL_189:
                            arg_18D_3 = false;
                        }
                        else
                        {
                            arg_18D_3 = true;
                        }
                        IL_18D:
                        arg_18D_0[arg_18D_1, arg_18D_2] = arg_18D_3;
                    }
                }
                string text = "";
                int num3 = array.Length;
                for (int k = s; k > 0; k -= array[num3])
                {
                    while (array2[num3, k])
                    {
                        num3--;
                    }
                    string text2 = array[num3].ToString();
                    text2 += new string('0', trimmedzeros);
                    text2 = text2.Insert(text2.Length - 2, ",");
                    // weird way to solve currency formatting
                    Decimal dec = Decimal.Parse(text2);
                    text2 = dec.ToString("c");                    
                    text += text2 + Environment.NewLine;
                }
                result = text;
            }
            return result;
        }

        public static IEnumerable<string> GetCombinationes(int[] set, int sum, string values)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int num = sum - set[i];
                string text = set[i] + "," + values;
                if (num == 0)
                {
                    yield return text;
                }
                else
                {
                    int[] array = (from n in set.Take(i)
                                   where n <= sum
                                   select n).ToArray<int>();
                    if (array.Length > 0)
                    {
                        foreach (string current in GetCombinationes(array, num, text))
                        {
                            yield return current;
                        }
                    }
                }
            }
            yield break;
        }

       

        private static int Trim(List<int> values, ref int totsum)
        {
            string text = Reverse(totsum.ToString());
            int num = 0;
            num = 0;
            while (text[num] == '0')
            {
                num++;
            }
            string[] array = new string[values.Count];
            int num2 = 0;
            foreach (int current in values)
            {
                array[num2++] = Reverse(current.ToString());
            }
            int i = 0;
            for (i = 0; i < num; i++)
            {
                string[] array2 = array;
                for (int j = 0; j < array2.Length; j++)
                {
                    string text2 = array2[j];
                    if (text2[i] != '0')
                    {
                        goto IL_CE;
                    }
                }
            }
            IL_CE:
            int num3 = 1;
            for (int k = 0; k < i; k++)
            {
                num3 *= 10;
            }
            totsum /= num3;
            for (int k = 0; k < values.Count; k++)
            {
                int index;
                values[index = k] = values[index] / num3;
            }
            return i;
        }

        private static string Reverse(string text)
        {
            string result;
            if (text == null)
            {
                result = null;
            }
            else
            {
                char[] array = text.ToCharArray();
                Array.Reverse(array);
                result = new string(array);
            }
            return result;
        }
    }
}

