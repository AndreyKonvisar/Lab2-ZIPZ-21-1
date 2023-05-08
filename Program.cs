namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Reporting reporting = new Reporting();
            Grivnya saltPrice = new Grivnya(10,20);
            Dolar plasticPrice = new Dolar(5,10);
            Product salt = new Product("сіль", saltPrice);
            Product plastic = new Product("пластмаса", plasticPrice);

            Grivnya decreaseMoney = new Grivnya(2,30);

            //перевірка роботи функції зменшення ціни
            salt.ProductPrice.GetMoneyAltogether();
            salt.decreasePrice(decreaseMoney, salt);
            salt.ProductPrice.GetMoneyAltogether();

            WareHouse saltWarehouse = new WareHouse("Сольвий", "кг", "12.10.2022", 0, salt);
            WareHouse plastWarehouse = new WareHouse("Пластиковий", "м", "02.11.2022", 4, plastic);

            //перевірка додавання та віднімання продуктів зі складу 
            saltWarehouse.removeProduct(salt);
            saltWarehouse.addProduct(salt);
            saltWarehouse.removeProduct(salt);
            plastWarehouse.addProduct(plastic);

            //результат перевірки залишків на складі
            reporting.GetWarehouseBalances(saltWarehouse);
            reporting.GetWarehouseBalances(plastWarehouse);
            




        }
    }
}