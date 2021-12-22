using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    public enum TypeOfAccount
    {
        DEBIT,
        CREDIT,
        DEPOSIT
    }
    class BankAccount
    {
        protected int _number;
        protected decimal _balance;
        protected TypeOfAccount _typeAccount;
        static int _counter = 1;
        private System.Collections.Queue transactions = new System.Collections.Queue();
        private bool disposed = false;

        public BankAccount()
        {
            _number = Increase();
        }
        public BankAccount(decimal balance)
        {
            _balance = balance;
            _number = Increase();
        }
        public BankAccount(TypeOfAccount typeAccount)
        {
            _typeAccount = typeAccount;
            _number = Increase();
        }
        public BankAccount(decimal balance, TypeOfAccount typeAccount)
        {
            _typeAccount = typeAccount;
            _balance = balance;
            _number = Increase();
        }
        public int Increase()
        {
            return _counter++;
        }
        public System.Collections.Queue accountTransactions
        {
            get { return transactions; }

        }
        public int accountNumber
        {
            get { return _number; }
            set { _number = value; }
        }
        public decimal accountBalance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public TypeOfAccount accountType
        {
            get { return _typeAccount; }
            set { _typeAccount = value; }
        }

        public void TransferMoney(ref BankAccount transferAccaunt, int amount)
        {
            if (transferAccaunt.accountBalance >= amount)
            {
                transferAccaunt.accountBalance -= amount;
                this.accountBalance += amount;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
                disposed = true;
            }
        }
        ~BankAccount()
        {
            Dispose(false);
        }

        public static bool operator ==(BankAccount a, BankAccount b)
        {
            if (a.accountNumber == b.accountNumber)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(BankAccount a,BankAccount b)
        {
            if (a.accountNumber != b.accountNumber) return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return (int)_balance + (int)_typeAccount;
        }
        public override string ToString()
        {
            return $"{accountNumber}, {accountBalance}, {accountType}";
        }
    }
}