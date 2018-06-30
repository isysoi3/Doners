using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UI_Example.Models;

//TODO: fix all namespace
namespace AddOrder
{
    public partial class AddOrderForm : Form
    {
        private Label lastLabel;
        private int labelCounter;
        private OrderItem currentOrder;

        public AddOrderForm()
        {
            currentOrder = new OrderItem();
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(!checkInput())
                return;

            SizeTypeEnum size = (rbBig.Checked ? SizeTypeEnum.big : SizeTypeEnum.standart);
            PitaTypeEnum pitaType = (rbWheat.Checked ? PitaTypeEnum.wheaten : PitaTypeEnum.cheesy);
            List<SauceTypeEnum> sauces = GetKebabSauces();
            string comment = rtbComment.Text;
            int quantity = int.Parse(tbCount.Text);

            KebabItem kebab = new KebabItem(size, 
                pitaType, 
                sauces,
                comment,
                quantity);

            currentOrder.AddNewKebabToOrder(kebab);

            Label newLabel = new Label();
            newLabel.Name = "lbN" + labelCounter;
            newLabel.Left = 10;
            newLabel.Width = gbOrder.Width - 100;
            newLabel.Height = 30;
            if (lastLabel == null)
                newLabel.Top = 20;
            else
                newLabel.Top = lastLabel.Bottom;

            newLabel.Text = kebab.ToString();
            gbOrder.Controls.Add(newLabel);

            Label costLabel = new Label();
            costLabel.Width = 60;
            costLabel.Name = "costN" + labelCounter;
            costLabel.Left = gbOrder.Width - 70;
            costLabel.Top = newLabel.Top;
            costLabel.Text = "=" + kebab.CountCost();
            gbOrder.Controls.Add(costLabel);

            labelCounter++;
            lastLabel = newLabel;

            recountTotalAndChange(sender, e);

            clearInput();
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
            double total = currentOrder.summary;
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

        private void endOrderButtonClick(object sender, EventArgs e)
        {
            //callbackOrder(currentOrder);
            currentOrder.ClearOrder();
            clearInput();
            this.Hide();
        }

        private List<SauceTypeEnum> GetKebabSauces()
        {
            List<SauceTypeEnum> sauces = new List<SauceTypeEnum>();
            if (cbBigMac.Checked)
                sauces.Add(SauceTypeEnum.bigMac);

            if (cbBigTasty.Checked)
                sauces.Add(SauceTypeEnum.bigTasty);

            if (cbCaesar.Checked)
                sauces.Add(SauceTypeEnum.caesar);

            if (cbCheese.Checked)
                sauces.Add(SauceTypeEnum.cheesy);

            if (cbGarlic.Checked)
               sauces.Add(SauceTypeEnum.garlic);
               
            if (cbSalsa.Checked)
                sauces.Add(SauceTypeEnum.salsa);

            return sauces;
        }

    }
}