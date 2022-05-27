using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Goods
    {
        // // // fields: // // //
        // 
        // Имя товара
        // Имя поставщика
        // Стоимость закупки
        // Стоимость продажи
        // Количество купленного товара
        // Количество проданного товара
        //
        // // // Methods: // // //
        // 
        // Выручка (В) - это совокупный объем денежных средств, полученный компанией, предприятимем или подлежащий получению за определеннный период времени коммерческой деятельности
        // Прибыль (П) - разница между суммарными доходами (выручка) и затратами на производство или прибретение, хранение , транспортировку, сбыт этих товаров и услуг
        // 
        // В = Стоимость проданного товара * Количество проданного товара
        // П = В -  (Количество купленного товара * Стоимость закупки)
        //
        // // // // // // // // //
        // Fields
        public string name { get; set; }
        public string provider_name { get; set; }
        public static int purchase_price { get; set; }
        public static int selling_price { get; set; }
        public static int number_of_purchased_goods { get; set; }
        public static int number_of_goods_sold { get; set; }
        public static int profit { get; set; }

        public Goods(string goods_name, string prov_name, int purchase_price, int selling_price, int number_purchased, int number_sold)
        {
            this.name = goods_name;
            this.provider_name = prov_name;
            Goods.purchase_price = purchase_price;
            Goods.selling_price = selling_price;
            Goods.number_of_purchased_goods = number_purchased;
            Goods.number_of_goods_sold = number_sold;
        }
        private int get_just_profit()
        {
            int profit = number_of_goods_sold * selling_price;
            Console.WriteLine("Прибыль: " + profit);
            return profit;
        }
        private int get_just_revenue()
        {
            int revenue = (number_of_goods_sold * selling_price - number_of_purchased_goods * purchase_price);
            Console.WriteLine("Выручка: " + revenue);
            return revenue;
            
        }
        // Methods
        public void show_information()
        {
            Console.WriteLine("#############################");
            Console.WriteLine("Имя товара: " + name);
            Console.WriteLine("Название поставщика: " + provider_name);
            Console.WriteLine("Стоимость закупки: " + purchase_price);
            Console.WriteLine("Стоимость продажи: " + selling_price);
            Console.WriteLine("Количество купленного товара: " + number_of_purchased_goods);
            Console.WriteLine("Количество проданного товара: " + number_of_goods_sold);
            Console.WriteLine("______________________________");
            Console.WriteLine("#############################");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Пожалуйста, введите параметры для товара");
                Console.WriteLine("Имя товара ? ");
                string name_ = Console.ReadLine();
                Console.WriteLine("Имя поставщика ? ");
                string prov_name = Console.ReadLine();
                Console.WriteLine("Стоимость покупки товара за одну единицу ? ");
                int purchase_price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Какое количество закупили ? ");
                int number_purchased = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Стоимость продажи товара за одну единицу ? ");
                int selling_price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Какое количество продали ? ");
                int number_sold = Convert.ToInt32(Console.ReadLine());

                Goods UserGood;
                UserGood = new Goods(name_, prov_name, purchase_price, selling_price, number_purchased, number_sold);

                UserGood.show_information();
                UserGood.get_just_profit();
                UserGood.get_just_revenue();
                Console.ReadKey();


            }
        }
    }
}