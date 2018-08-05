using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//TODO: fix all namespace
namespace UI_Example.Models
{

    public enum SizeTypeEnum
    {
        small,
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
        bulgarian,
        dragon,
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

        public KebabItem(DataRow row)
        {
            sizeType = (SizeTypeEnum)Enum.Parse(typeof(SizeTypeEnum), row.Field<String>("size"));
            pitaType = (PitaTypeEnum)Enum.Parse(typeof(PitaTypeEnum), row.Field<String>("pita"));
            quantity = (int)row.Field<Int64>("quantity");

            setSauces(row);
        }

        private void setSauces(DataRow row)
        {
            sauces = new List<SauceTypeEnum>();
            String info = row.Field<String>("type");
            if (info.Contains("По-болгарски"))
                sauces.Add(SauceTypeEnum.bulgarian);
            if (info.Contains("Дыхание дракона"))
                sauces.Add(SauceTypeEnum.dragon);
            if (info.Contains("БигМак"))
                sauces.Add(SauceTypeEnum.bigMac);
            if (info.Contains("БигТейсти"))
                sauces.Add(SauceTypeEnum.bigTasty);
            if (info.Contains("Цезарь"))
                sauces.Add(SauceTypeEnum.caesar);
            if (info.Contains("Сырный"))
                sauces.Add(SauceTypeEnum.cheesy);
            if (info.Contains("Чесночный"))
                sauces.Add(SauceTypeEnum.garlic);
            if (info.Contains("Горчичный"))
                sauces.Add(SauceTypeEnum.mustard);
            if (info.Contains("Сальса"))
                sauces.Add(SauceTypeEnum.salsa);
        }

        public double CountCost()
        {
            double cost = 0;
            if (sizeType == SizeTypeEnum.big)
                cost += 8.0;
            else if (sizeType == SizeTypeEnum.standart)
                cost += 6.0;
            else
                cost += 4.0;
            bool isPremium = sauces.Exists(x =>( x == SauceTypeEnum.bigTasty || x == SauceTypeEnum.bigMac));
            if (isPremium)
                cost += 0.5;

            return cost * quantity;
        }

        public string GetSizeString()
        {
            switch (sizeType)
            {
                case SizeTypeEnum.big:
                    return "Большая";
                case SizeTypeEnum.small:
                    return "Маленькая";
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
                if (sauce == SauceTypeEnum.bulgarian)
                {
                    result += "По-болгарски\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.dragon)
                {
                    result += "Дыхание дракона\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.bigMac)
                {
                    result += "БигМак\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.bigTasty)
                {
                    result += "БигТейсти\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.caesar)
                {
                    result += "Цезарь\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.cheesy)
                {
                    result += "Сырный\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.garlic)
                {
                    result += "Чесночный\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.mustard)
                {
                    result += "Горчичный\n";
                    continue;
                }
                if (sauce == SauceTypeEnum.salsa)
                {
                    result += "Сальса\n";
                    continue;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string result;

            if (sizeType == SizeTypeEnum.big)
                result = "Большая, ";
            else if (sizeType == SizeTypeEnum.small)
                result = "Маленькая, ";
            else
                result = "Cтандарт, ";

            if (pitaType == PitaTypeEnum.wheaten)
                result += "Пш. лаваш, ";
            else
                result += "Сыр. лаваш, ";

            result += "Cоус: ";

            foreach (SauceTypeEnum sauce in sauces)
            {
                if (sauce == SauceTypeEnum.bulgarian)
                {
                    result += "По-болгарски";
                    continue;
                }
                if (sauce == SauceTypeEnum.dragon)
                {
                    result += "Дыхание дракона";
                    continue;
                }
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
