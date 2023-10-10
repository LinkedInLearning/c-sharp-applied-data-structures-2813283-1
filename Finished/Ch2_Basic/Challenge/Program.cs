// Example file for C# Applied Data Structures by Joe Marini
// Solution for Programming Challenge

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Test Code
            ShoppingList list = new ();
            list.AddItem("Milk", 2.25, 1);
            list.AddItem("Sugar", 1.75, 2);
            list.AddItem("Bread", 3.25, 1);
            list.AddItem("Butter", 4.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();

            list.RemoveItem("Bread");
            list.RemoveItem("Sugar");
            list.AddItem("Cookies", 0.50, 4);
            list.AddItem("Oranges", 0.65, 5);
            list.AddItem("Chicken", 8.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();
        }
    }

    public class ShoppingItem {
        public String itemName;
        public double price;
        public int quantity;
    }

    public class ShoppingList {
        List<ShoppingItem> shoppingList = new List<ShoppingItem>(20);

        public void AddItem(string ItemName, double Price, int Quantity) {
            shoppingList.Add(new ShoppingItem() {itemName = ItemName, price = Price, quantity = Quantity});
        }

        public void RemoveItem(string ItemName) {
            ShoppingItem FoundItem = null;
            foreach (ShoppingItem i in shoppingList) {
                if (i.itemName == ItemName) {
                    FoundItem = i;
                    break;
                }
            }
            if (FoundItem != null) {
                if (FoundItem.quantity > 1) {
                    FoundItem.quantity--;
                }
                else shoppingList.Remove(FoundItem);
            }
        }

        public int GetCount() {
            int count = 0;
            foreach (ShoppingItem i in shoppingList) {
                count += i.quantity;
            }
            return count;
        }

        public void PrintList() {
            foreach (var item in shoppingList) {
                Console.WriteLine($"Item: {item.itemName,10}, Price: {item.price:C}, Quantity: {item.quantity}");
            }
        }
    }
}
