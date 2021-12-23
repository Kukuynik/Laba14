using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba14
{
    public partial class Form1 : Form
    {
        BankAccount account1 = new BankAccount(1200, TypeOfAccount.DEBIT);
        BankAccount account2 = new BankAccount(1000, TypeOfAccount.DEBIT);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = $"Number: {account1.accountNumber}, balance: {account1.accountBalance}, type: {account1.accountType}";
            richTextBox2.Text = $"Number: {account2.accountNumber}, balance: {account2.accountBalance}, type: {account2.accountType}";
            richTextBox3.Text = $"aaccount1 == account2: {account1 == account2}\naccount1 != account2: {account1 != account2}\naccount1 == account2: {account1 == account2}\n account1 equals account2: {account1.Equals(account2)}\naccount1 GetHashCode: {account1.GetHashCode()}\naccount1 ToString(): {account1.ToString()}\n";
        }

        void Task2()
        {
            RationalNumbers number1 = new RationalNumbers(10, 5);
            RationalNumbers number2 = new RationalNumbers(20, 4);

            DrawRac(richTextBox6, number1);
            DrawRac(richTextBox5, number2);

            richTextBox4.Text = "";
            richTextBox4.Text = $"Действия:\n" +
                $"1 < 2 = {number1 < number2}\n" +
                $"1 > 2 = {number1 > number2}\n" +
                $"1 <= 2 = {number1 <= number2}\n" +
                $"1 >= 2 = {number1 >= number2}\n" +
                $"1 + 2 = {number1 + number2}\n" +
                $"1 - 2 = {number1 - number2}\n" +
                $"1++ = {number1++} | 2++ = {number2++}\n" +
                $"1-- = {number1--} | 2-- = {number2--}\n" +
                $"1 * 2 = {number1 * number2}\n" +
                $"1 / 2 = {number1 / number2}\n" +
                $"1.Float() = {number1.GetFloat()} | 2.Float() = {number2.GetFloat()}";
        }
        void DrawRac(RichTextBox richTextBox, RationalNumbers rationalNumbers)
        {
            richTextBox.Text+= $"{rationalNumbers.numerator} / {rationalNumbers.denominator}";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                Task2();
            }
        }

    }
}
