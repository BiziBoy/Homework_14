using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//написать методы удаления элемента из начала, конеца и по указанному индексу 
namespace Homework_13
{
  class Program
  {
    static void deleteLast(ref int[] array)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      array = new int[array.Length - 1];
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = currArray[i];
      }
    }

    static void deleteFirst(ref int[] array)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      array = new int[array.Length - 1];
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = currArray[i + 1];
      }

    }

    static void deleteByIndex(ref int[] array, int index)
    {
      if (index == 0)
      {
        deleteFirst(ref array);
      }
      else if (index == array.Length - 1)
      {
        deleteLast(ref array);
      }
      else
      {
        int[] currArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
          currArray[i] = array[i];
        }
        array = new int[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
          array[i] = currArray[i];
        }
        for (int i = index ; i < array.Length ; i++)
        {
          array[i] = currArray[i + 1];
        }
      }
    }

    static void Main(string[] args)
    {
      int[] myArrray = new int[] { 1, 2, 3, 4 };
      foreach (var item in myArrray)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
      Console.Write("Введите какой элемент удалить из массива(первый/ последний/ по индексу): ");
      string identificator = Console.ReadLine();
      if (identificator == "первый")
      {
        deleteFirst(ref myArrray);
      }
      else if (identificator == "последний")
      {
        deleteLast(ref myArrray);
      }
      else if (identificator == "по индексу")
      {
        Console.Write("Введите индекс элемента для удаления: ");
        deleteByIndex(ref myArrray, int.Parse(Console.ReadLine()));
      }
      foreach (var item in myArrray)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
      Console.ReadLine();
    }
  }
}
