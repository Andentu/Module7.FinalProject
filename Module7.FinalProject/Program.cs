// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

//Инициализация переменных
Laptop laptop = new Laptop();
TV tv = new TV();
Smartphone smartphone = new Smartphone();
Headphones headphones = new Headphones();

//Начальные значения для каждого товара на данный момент
laptop.SetValues(50, 10, 0, 0);
tv.SetValues(20, 10, 0, 0);
smartphone.SetValues(100, 30, 0, 0);
headphones.SetValues(300, 50, 0, 0);

HomeDelivery HomeDelivery = new HomeDelivery();

enum Products {Laptop, TV, Smartphone, Headphones}
abstract class ElectronicGoods //Абстрактный класс товаров
{
    protected uint StockAmount;
    protected uint ShopAmount;
    protected uint PickPointAmount;
    protected uint InHomeDeliveryAmount;

    public void SetValues(uint StockAmount, uint ShopAmount, uint PickPointAmount, uint InHomeDeliveryAmount)
    {
        this.StockAmount = StockAmount;
        this.ShopAmount = ShopAmount;
        this.PickPointAmount = PickPointAmount;
        this.InHomeDeliveryAmount = InHomeDeliveryAmount;
    }
    public void GetValues () // Внутренний проверочный метод
    {
        Console.WriteLine(StockAmount.ToString() + " " + ShopAmount.ToString() + " " 
            + PickPointAmount.ToString() + " " + InHomeDeliveryAmount.ToString());

    }
}
class Laptop : ElectronicGoods //Классы наследники (товары)
{
   
}
class TV : ElectronicGoods
{
    
}
class Smartphone : ElectronicGoods
{
    
}
class Headphones : ElectronicGoods
{
    
}

abstract class Delivery
{ 
   public string Address;

}

class HomeDelivery : Delivery
{
    /* ... */
    

}

class PickPointDelivery : Delivery
{
    /* ... */
}

class ShopDelivery : Delivery
{
    /* ... */
}

class Order<TDelivery,TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
    public Products ProductsList;
    public void ChooseProduct ()
    {
        Console.WriteLine("Выберите товар из:" + ProductsList);
        Console.Write("Введите выбранный товар: ");
    
    }
    
    static uint CorrectNumber(ref uint number) // Метод проверяет корректность введенных чисел
    {
        bool result = uint.TryParse(Console.ReadLine(), out number);
        if (result != true || number <= 0)
        {
            Console.WriteLine("Введите корректное число больше 0: ");
            CorrectNumber(ref number);
        }
        return number;


    }

    // ... Другие поля
}
  
     
  

    
// class ProductData //Хранит числовые данные о количестве и местонахождении товара. Использует ProductTypes
// {

    
    
    // Количество товара на складе 
    // Количество товара в точке выдачи (Заказанное, просроченное)
    // Количество товара в магазине (Розничное, заказанное, просроченное - переходит в розничное, если проходит проверку
    // на необходимый объем в магазине
    // Проверка на количество товара и корректировка чисел
    //}


class ShowProduct // Класс показывает клиенту виды товаров, а также их количество в определенных точках
{
    // Берет данные из ProductData и показывает сколько есть в точках
    // Показывает сколько есть в магазине 
    // Показывает, сколько есть на складе
    // Спрашивает, куда нужно доставить и в каком количестве
    // Делает проверку на наличие и если все верно - передает заказ в класс Order
}
