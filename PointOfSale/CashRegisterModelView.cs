using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// The ModelView for a cash register control
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Model class for this ModelView
        /// </summary> 
        public static CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        private double totalValue = 0;

        /// <summary>
        /// TotalWithTax value customer has paid
        /// </summary>
        public double TotalPaid { get => totalValue; }

        /// <summary>
        /// Counts number of pennies given
        /// </summary>
        private int countPennies = 0;
        /// <summary>
        /// Counts number of nickels given
        /// </summary>
        private int countNickels = 0;
        /// <summary>
        /// Counts number of dimes given
        /// </summary>
        private int countDimes = 0;
        /// <summary>
        /// Counts number of quarters given
        /// </summary>
        private int countQuarters = 0;
        /// <summary>
        /// Counts number of halfdollars given
        /// </summary>
        private int countHalfDollars = 0;
        /// <summary>
        /// Counts number of dollars given
        /// </summary>
        private int countDollars = 0;
        /// <summary>
        /// Counts number of ones given
        /// </summary>
        private int countOnes = 0;
        /// <summary>
        /// Counts number of twos given
        /// </summary>
        private int countTwos = 0;
        /// <summary>
        /// Counts number of fives given
        /// </summary>
        private int countFives = 0;
        /// <summary>
        /// Counts number of tens given
        /// </summary>
        private int countTens = 0;
        /// <summary>
        /// Counts number of twenties given
        /// </summary>
        private int countTwenties = 0;
        /// <summary>
        /// Counts number of fifties given
        /// </summary>
        private int countFifties = 0;
        /// <summary>
        /// Counts number of hundreds given
        /// </summary>
        private int countHundreds = 0;

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => countPennies;

            set
            {
                if (countPennies == value || value < 0) return;
                int quantity = value - countPennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    countPennies++;
                    totalValue += 0.01;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    countPennies--;
                    totalValue -= 0.01;
                }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets or sets the number of nickels in the cash register
        /// </summary>
        public int Nickels
        {
            get => countNickels;

            set
            {
                if (countNickels == value || value < 0) return;
                int quantity = value - countNickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    countNickels++;
                    totalValue += 0.05;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    countNickels--;
                    totalValue -= 0.05;
                }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets or sets the number of dimes in the cash register
        /// </summary>
        public int Dimes
        {
            get => countDimes;

            set
            {
                if (countDimes == value || value < 0) return;
                int quantity = value - countDimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    countDimes++;
                    totalValue += 0.10;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    countDimes--;
                    totalValue -= 0.10;
                }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets or sets the number of quarters in the cash register
        /// </summary>
        public int Quarters
        {
            get => countQuarters;

            set
            {
                if (countQuarters == value || value < 0) return;
                int quantity = value - countQuarters;
                if (quantity > 0) { drawer.AddCoin(Coins.Quarter, quantity); countQuarters++; totalValue += 0.25; }
                else { drawer.RemoveCoin(Coins.Quarter, -quantity); countQuarters--; totalValue -= 0.25; }
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets or sets the number of half dollars in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => countHalfDollars;

            set
            {
                if (countHalfDollars == value || value < 0) return;
                int quantity = value - countHalfDollars;
                if (quantity > 0) { drawer.AddCoin(Coins.HalfDollar, quantity); countHalfDollars++; totalValue += 0.50; }
                else { drawer.RemoveCoin(Coins.HalfDollar, -quantity); countHalfDollars--; totalValue -= 0.50; }
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Dollars
        {
            get => countDollars;

            set
            {
                if (countDollars == value || value < 0) return;
                int quantity = value - countDollars;
                if (quantity > 0) { drawer.AddCoin(Coins.Dollar, quantity); countDollars++; totalValue += 1.00; }
                else { drawer.RemoveCoin(Coins.Dollar, -quantity); countDollars--; totalValue -= 1.00; }
                InvokePropertyChanged("Dollar");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Ones
        {
            get => countOnes;

            set
            {
                if (countOnes == value || value < 0) return;
                int quantity = value - countOnes;
                if (quantity > 0) { drawer.AddBill(Bills.One, quantity); countOnes++; totalValue += 1.00;}
                else { drawer.RemoveBill(Bills.One, -quantity); countOnes--; totalValue -= 1.00; }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Twos
        {
            get => countTwos;

            set
            {
                if (countTwos == value || value < 0) return;
                int quantity = value - countTwos;
                if (quantity > 0) { drawer.AddBill(Bills.Two, quantity); countTwos++; totalValue += 2;}
                else { drawer.RemoveBill(Bills.Two, -quantity); countTwos--; totalValue -= 2.00; }
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Fives
        {
            get => countFives;

            set
            {
                if (countFives == value || value < 0) return;
                int quantity = value - countFives;
                if (quantity > 0) { drawer.AddBill(Bills.Five, quantity); countFives++; totalValue += 5.00; }
                else { drawer.RemoveBill(Bills.Five, -quantity); countFives--; totalValue -= 5.00; }
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Tens
        {
            get => countTens;

            set
            {
                if (countTens == value || value < 0) return;
                int quantity = value - countTens;
                if (quantity > 0) { drawer.AddBill(Bills.Ten, quantity); countTens++; totalValue += 10.00; }
                else { drawer.RemoveBill(Bills.Ten, -quantity); countTens--; totalValue -= 10.00; }
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Twenties
        {
            get => countTwenties;

            set
            {
                if (countTwenties == value || value < 0) return;
                int quantity = value - countTwenties;
                countTwenties = value;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                totalValue = quantity * 20.00;
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Fifties
        {
            get => countFifties;

            set
            {
                if (countFifties == value || value < 0) return;
                int quantity = value - countFifties;
                if (quantity > 0) { drawer.AddBill(Bills.Fifty, quantity); countFifties++; totalValue += 50.00; }
                else { drawer.RemoveBill(Bills.Fifty, -quantity); countFifties--; totalValue -= 50.00; }
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Gets or sets the number of doallar coins in the cash register
        /// </summary>
        public int Hundreds
        {
            get => countHundreds;

            set
            {
                if (countHundreds == value || value < 0) return;
                int quantity = value - countHundreds;
                if (quantity > 0) { drawer.AddBill(Bills.Hundred, quantity); countHundreds++; totalValue += 100.00; }
                else { drawer.RemoveBill(Bills.Hundred, -quantity); countHundreds--; totalValue -= 100.00; }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
        }

    }

}
