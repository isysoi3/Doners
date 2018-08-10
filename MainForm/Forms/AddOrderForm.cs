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
using UI_Example.Controls;
using UI_Example;

//TODO: fix all namespace
namespace AddOrder
{

    public delegate void AddNewOrderDelegate(OrderItem item);

    public partial class AddOrderForm : Form
    {
        private Label lastLabel;
        private int labelCounter;
        private OrderItem currentOrder;
        public AddNewOrderDelegate AddOrderCallback;
        private DataBaseWrapper dbWrapper;
        private OrderPaymentControl orderPaymentControl;
        private Control currentGroupBox;

        public AddOrderForm()
        {
            currentOrder = new OrderItem();
            dbWrapper = new DataBaseWrapper();
            

            InitializeComponent();


            orderPaymentControl = new OrderPaymentControl();
            currentGroupBox = gbMakeOrder;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;

            SizeTypeEnum size;
            if (rbSmall.Checked)
                size = SizeTypeEnum.small;
            else if (rbStandart.Checked)
                size = SizeTypeEnum.standart;
            else
                size = SizeTypeEnum.big;
            PitaTypeEnum pitaType = (rbWheat.Checked ? PitaTypeEnum.wheaten : PitaTypeEnum.cheesy);
            List<SauceTypeEnum> sauces = GetKebabSauces();
            string comment = rtbComment.Text;
            int quantity = int.Parse(tbCount.Text);

            KebabItem kebab = new KebabItem(
                size,
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

            clearErrorProvider(sender, e);
            clearInput();
        }

        private void clearInput()
        {
            rbBig.Checked = false;
            rbStandart.Checked = false;
            rbSmall.Checked = false;

            rbWheat.Checked = false;
            rbCheese.Checked = false;

            rbDragon.Checked = false;
            rbBulgarian.Checked = false;
            rbCommon.Checked = true;
            typeSelectionChanged(this, new EventArgs());

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

        private void clearOrderInput()
        {
            if (currentGroupBox == gbMakeOrder)
                clearInput();
            else
                orderPaymentControl.clearOrderInput();
            lastLabel = null;
            gbOrder.Controls.Clear();
        }

        private void clearErrorProvider(object sender, EventArgs e)
        {
            errProvider.Clear();
        }

        private bool checkInput()
        {
            if (!rbStandart.Checked && !rbBig.Checked && !rbSmall.Checked)
            {
                errProvider.SetError(gbSize, "Размер не выбран");
                return false;
            }
            if (!rbCheese.Checked && !rbWheat.Checked)
            {
                errProvider.SetError(gbPita, "Лаваш не выбран");
                return false;
            }
            if (rbCommon.Checked && !cbCaesar.Checked && !cbCheese.Checked && !cbGarlic.Checked && !cbMustard.Checked
                && !cbSalsa.Checked && !cbBigMac.Checked && !cbBigTasty.Checked)
            {
                errProvider.SetError(gbSauce, "Соус не выбран");
                return false;
            }
            int count;
            if (tbCount.Text == "" || !int.TryParse(tbCount.Text, out count) || count <= 0)
            {
                errProvider.SetError(tbCount, "Введите количество");
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            currentOrder.ClearOrder();
            clearOrderInput();
        }

        private List<SauceTypeEnum> GetKebabSauces()
        {
            List<SauceTypeEnum> sauces = new List<SauceTypeEnum>();

            if (rbBulgarian.Checked)
            {
                sauces.Add(SauceTypeEnum.bulgarian);
                return sauces;
            }

            if (rbDragon.Checked)
            {
                sauces.Add(SauceTypeEnum.dragon);
                return sauces;
            }

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

        private void FormWillClose(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void typeSelectionChanged(object sender, EventArgs e)
        {
            if (rbCommon.Checked)
            {
                gbSauce.Enabled = true;
                rbSmall.Enabled = true;
            }
            else
            {
                gbSauce.Enabled = false;
                rbSmall.Checked = false;
                rbSmall.Enabled = false;
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentGroupBox == gbMakeOrder)
            {
                if (currentOrder.IsOrderEmpty())
                {
                    errProvider.SetError(gbOrder, "Пустой заказ");
                    return;
                }

                Controls.Remove(gbMakeOrder);

                orderPaymentControl.Top = currentGroupBox.Top;
                orderPaymentControl.Left = currentGroupBox.Left;
                currentGroupBox = orderPaymentControl;
                orderPaymentControl.setCurrentOrder(currentOrder);
                Controls.Add(currentGroupBox);

                btBack.Enabled = true;
            }
            else
            {
                if(orderPaymentControl.endOrderButtonClick())
                {
                    currentOrder = orderPaymentControl.getCurrentOrder();
                    AddOrderCallback(currentOrder);
                    dbWrapper.addOrder(currentOrder);
                    ClearForm();
                    Hide();
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            btBack.Enabled = false;

            Controls.Remove(currentGroupBox);
            currentGroupBox = gbMakeOrder;
            Controls.Add(currentGroupBox);
        }
    }
}