using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: fix all namespace
namespace UI_Example.Models
{

    public enum SizeTypeEnum
    {
        standart,
        big
    }

    public enum PitaTypeEnum
    {
        wheaten,
        cheesy
    }

    public enum SauceTypeEnum
    {
        garlic,
        salsa,
        cheesy,
        caesar,
        mustard,
        bigMac,
        bigTasty
    }

    public class KebabItem
    {

        public PitaTypeEnum pitaType { get; private set; }
        public SizeTypeEnum sizeType { get; private set; }
        public List<SauceTypeEnum> sauces { get; private set; }
        public int quantity { get; private set; }
        public string comment { get; private set; }

        public KebabItem(SizeTypeEnum sizeType,
            PitaTypeEnum pitaType,
            List<SauceTypeEnum> sauces,
            string comment,
            int quantity)
        {
            this.pitaType = pitaType;
            this.sizeType = sizeType;
            this.sauces = sauces;
            this.comment = comment;
            this.quantity = quantity;
        }

        public double CountCost()
        {
            double cost = 0;
            if (sizeType == SizeTypeEnum.big)
                cost += 7.0;
            else
                cost += 5.0;
            bool isPremium = sauces.Exists(x =>( x == SauceTypeEnum.bigTasty || x == SauceTypeEnum.bigMac));
            if (isPremium)
                cost += 1.5;

            return cost * quantity;
        }

        public string GetSizeString()
        {
            switch (sizeType)
            {
                case SizeTypeEnum.big:
                    return "Большая";
                default:
                    return "Стандартная";
            }
        }

        public string GetPitaTypeString()
        {
            switch (pitaType)
            {
                case PitaTypeEnum.cheesy:
                    return "Сырный";
                default:
                    return "Пшеничный";
            }
        }

        public string GetSaucesString()
        {
            string result = "";
            foreach (SauceTypeEnum sauce in sauces)
            {
                if (sauce == SauceTypeEnum.bigMac)
                {
                    result += "БигМак ";
                    continue;
                }
                if (sauce == SauceTypeEnum.bigTasty)
                {
                    result += "БигТейсти ";
                    continue;
                }
                if (sauce == SauceTypeEnum.caesar)
                {
                    result += "Цезарь ";
                    continue;
                }
                if (sauce == SauceTypeEnum.cheesy)
                {
                    result += "Сырный ";
                    continue;
                }
                if (sauce == SauceTypeEnum.garlic)
                {
                    result += "Чесночный ";
                    continue;
                }
                if (sauce == SauceTypeEnum.mustard)
                {
                    result += "Горчичный ";
                    continue;
                }
                if (sauce == SauceTypeEnum.salsa)
                {
                    result += "Сальса ";
                    continue;
                }
            }
            return result;
        }

        public override string ToString()
        {

            string result;
            //delete duplicating
            if (sizeType == SizeTypeEnum.big)
                result = "Большая, ";
            else
                result = "Cтандарт, ";

            if (pitaType == PitaTypeEnum.wheaten)
                result += "Пш. лаваш, ";
            else
                result += "Сыр. лаваш, ";

            result += "Cоус: ";

            foreach (SauceTypeEnum sauce in sauces)
            {
                if (sauce == SauceTypeEnum.bigMac)
                {
                    result += "БигМак ";
                    continue;
                }
                if (sauce == SauceTypeEnum.bigTasty)
                {
                    result += "БигТейсти ";
                    continue;
                }
                if (sauce == SauceTypeEnum.caesar)
                {
                    result += "Цезарь ";
                    continue;
                }
                if (sauce == SauceTypeEnum.cheesy) { 
                    result += "Сырный ";
                    continue;
                }
                if (sauce == SauceTypeEnum.garlic) { 
                    result += "Чесночный ";
                    continue;
                }
                if (sauce == SauceTypeEnum.mustard) { 
                    result += "Горчичный ";
                    continue;
                }
                if (sauce == SauceTypeEnum.salsa) { 
                    result += "Сальса ";
                    continue;
                }
            }

            result += "X" + quantity.ToString();

            if (comment != "")
                result += " \n(" + comment + ")";

            return result;
        }

    }
}
