using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddOrder
{
    public partial class AddOrderForm : Form
    {
        private Label lastLabel;
        private int labelCounter;
        private double summary = 0;

        public AddOrderForm()
        {
            InitializeComponent();
        }

        private double getCost()
        {
            double cost;
            if (rbBig.Checked)
                cost = 7;
            else
                cost = 5;

            if (cbBigMac.Checked || cbBigTasty.Checked)
                cost += (double)1.5;
            return cost * int.Parse(tbCount.Text);
        }

        private string makeText()
        {
            string result;

            if (rbBig.Checked)
                result = "Большая, ";
            else
                result = "Cтандарт, ";

            if (rbWheat.Checked)
                result += "Пш. лаваш, ";
            else
                result += "Сыр. лаваш, ";

            result += "Cоус: ";

            if (cbBigMac.Checked)
                result += "БигМак ";
            if (cbBigTasty.Checked)
                result += "БигТейсти ";
            if (cbCaesar.Checked)
                result += "Цезарь ";
            if (cbCheese.Checked)
                result += "Сырный ";
            if (cbGarlic.Checked)
                result += "Чесночный ";
            if (cbMustard.Checked)
                result += "Горчичный ";
            if (cbSalsa.Checked)
                result += "Сальса ";

            result += "X" + tbCount.Text;

            if (rtbComment.Text != "")
                result += " \n(" + rtbComment.Text + ")";

            return result;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(checkInput())
            {
                Label newLabel = new Label();
                newLabel.Name = "lbN" + labelCounter;
                newLabel.Left = 10;
                newLabel.Width = gbOrder.Width - 100;
                newLabel.Height = 30;
                if (lastLabel == null)
                    newLabel.Top = 20;
                else
                    newLabel.Top = lastLabel.Bottom;

                newLabel.Text = makeText();
                gbOrder.Controls.Add(newLabel);

                Label costLabel = new Label();
                costLabel.Width = 60;
                costLabel.Name = "costN" + labelCounter;
                costLabel.Left = gbOrder.Width - 70;
                costLabel.Top = newLabel.Top;
                costLabel.Text = "=" + getCost();
                gbOrder.Controls.Add(costLabel);

                summary += getCost();

                labelCounter++;
                lastLabel = newLabel;

                recountTotalAndChange(sender, e);

                clearInput();
            }
        }

        private void clearInput()
        {
            rbBig.Checked = false;
            rbStandart.Checked = false;
            rbWheat.Checked = false;
            rbCheese.Checked = false;

            cbBigMac.Checked = false;
            cbBigTasty.Checked = false;
            cbCaesar.Checked = false;
            cbCheese.Checked = false;
            cbGarlic.Checked = false;
            cbMustard.Checked = false;
            cbSalsa.Checked = false;

            tbCount.Text = "1";

            rtbComment.Text = "";
        }

        private void clearErrorProvider(object sender, EventArgs e)
        {
            errProvider.Clear();
        }

        private bool checkInput()
        {
            if (!rbStandart.Checked && !rbBig.Checked)
            {
                errProvider.SetError(gbSize, "Размер не выбран");
                return false;
            }
            if (!rbCheese.Checked && !rbWheat.Checked)
            {
                errProvider.SetError(gbPita, "Лаваш не выбран");
                return false;
            }
            if (!cbCaesar.Checked && !cbCheese.Checked && !cbGarlic.Checked && !cbMustard.Checked 
                && !cbSalsa.Checked && !cbBigMac.Checked && !cbBigTasty.Checked)
            {
                errProvider.SetError(lbSause, "Соус не выбран");
                return false;
            }
            int count;
            if (tbCount.Text == "" ||  !int.TryParse(tbCount.Text, out count) || count <= 0)
            {
                errProvider.SetError(tbCount, "Введите количество");
                return false;
            }
            return true;
        }

        private void paymentChanged(object sender, EventArgs e)
        {
            if (rbCard.Checked)
            {
                tbGiven.Enabled = false;
                tbGiven.Text = "";
                lbChange.Text = "Сдача: ";
            }
            else
                tbGiven.Enabled = true;
            recountTotalAndChange(sender, e);
        }

        private void recountTotalAndChange(object sender, EventArgs e)
        {
            double total = summary;
            double discount, given;
            if (double.TryParse(tbDiscount.Text, out discount) && discount >= 0)
                total *= (100 - discount) / 100;
            total = Math.Round(total, 2);
            lbTotal.Text = "Итого: " + total;

            if (double.TryParse(tbGiven.Text, out given) && given >= total)
                lbChange.Text = "Сдача: " + (given - total);
        }

        private void printCkeckButtonClicked(object sender, EventArgs e)
        {
            //TODO: print check
        }
    }
}
