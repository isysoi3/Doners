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

        public AddOrderForm()
        {
            InitializeComponent();
        }

        private float getCost()
        {
            float cost;
            if (rbBig.Checked)
                cost = 7;
            else
                cost = 5;

            if (cbBigMac.Checked || cbBigTasty.Checked)
                cost += (float)1.5;
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
                result += "БМ ";
            if (cbBigTasty.Checked)
                result += "БТ ";
            if (cbCaesar.Checked)
                result += "Цез ";
            if (cbCheese.Checked)
                result += "Сыр ";
            if (cbGarlic.Checked)
                result += "Чесн ";
            if (cbMustard.Checked)
                result += "Горч ";
            if (cbSalsa.Checked)
                result += "Сальса ";

            result += "X" + tbCount.Text;

            if (rtbComment.Text != "")
                result += " (" + rtbComment.Text + ")";

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

                labelCounter++;
                lastLabel = newLabel;
            }
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
    }
}
