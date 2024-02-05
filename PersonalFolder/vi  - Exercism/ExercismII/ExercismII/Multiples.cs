using System;
using System.Collections.Generic;
public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int result;
        int count = 2;
        int totalSum;

        List<int> listMultiple = new List<int>();
        List<int> listSort = new List<int>();
        List<int> listWODuplicates = new List<int>();
        foreach (int multiple in multiples)
        {
            if (multiple == 0)
            {
                listMultiple.Add(multiple);
                break;
            }

            result = multiple;
            while (result < max)
            {
                listMultiple.Add(result);
                result = multiple * count;
                count++;
            }
            count = 2;
        }
        listSort = SortList(listMultiple);
        listWODuplicates = RemoveDuplicates(listSort);
        totalSum = CalculateSum(listWODuplicates);

        return totalSum;
    }


    // Funcion que ordena la lista de menor a mayor
    public static List<int> SortList(List<int> list)
    {
        int aux;
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    aux = list[i];
                    list[i] = list[j];
                    list[j] = aux;
                }
            }
        }
        return list;
    }


    // Funcion que elimina los valores reptidos
    public static List<int> RemoveDuplicates(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    list.RemoveAt(j);
                    j--;
                }
            }
        }
        return list;
    }


    // Funcion que calcula el sumatorio de los elementos de la lista
    public static int CalculateSum(List<int> list)
    {
        int result = 0;
        foreach (int i in list)
        {
            result += i;
        }
        return result;
    }
}