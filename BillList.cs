using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemensCloset
{
    internal class BillList
    {
        List<Bill> bills;
        
        public BillList()
        {
            bills = new List<Bill>();
            bills = LoadBills();
        }

        private List<Bill> LoadBills()
        {
            List<Bill> bills = new List<Bill>();

            if (!File.Exists("bills.txt"))
            {
                return bills;
            }

            try
            {
                StreamReader file = new StreamReader("bills.txt");
                int amount = Convert.ToInt32(file.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Bill b = new Bill(file.ReadLine(), file.ReadLine(), DateTime.Parse(file.ReadLine()), Convert.ToDecimal(file.ReadLine()));

                    string separator = file.ReadLine();

                    bills.Add(b);
                }
                file.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return bills;
        }
        public void SaveBills()
        {
            try
            {
                StreamWriter file = new StreamWriter("bills.txt");
                file.WriteLine(bills.Count);
                foreach (Bill b in bills)
                {
                    file.WriteLine(b.billId);
                    file.WriteLine(b.sellerName);
                    file.WriteLine(b.sellDate);
                    file.WriteLine(b.totalAmount);
                    file.WriteLine();
                }
                file.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public List<Bill> GetBills()
        {
            return bills;
        }

        public void AddBill(Bill bill)
        {
            bills.Add(bill);
        }
    }
}
