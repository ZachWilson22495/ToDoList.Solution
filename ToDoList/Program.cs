using System;
using System.Collections.Generic;
using ToDoList.Models;

public class Program
{
  private static bool isFirstTime = true;
  public static void Main()
  {
    if(isFirstTime)
    {
      Console.WriteLine("Welcome to your To Do List!");
      isFirstTime = false;
    }
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");

    string userInput = Console.ReadLine();

    if(userInput == "Add" || userInput == "add")
    {
      Console.WriteLine("Please enter a description for the new item");
      Item newItem = new Item(Console.ReadLine());
      Console.WriteLine(newItem.Description + " has been added to your list");
      Main();
    }
    else if (userInput == "View" || userInput == "view")
    {
      if(Item.GetAll().Count == 0)
      {
        Console.WriteLine("... the list is empty...");
      }
      else 
      {
        foreach(Item item in Item.GetAll())
        {
          Console.WriteLine(item.Description);
        }
      }
       Main();
    }
    else
    {
      Console.WriteLine("Please enter a valid selection");
      Main();
    }
    
  }
}