using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BolenBul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Example usage
        GenerateAndPrintMultiples(13, 161);
    }

    void GenerateAndPrintMultiples(int start, int end)
    {
        // Create an array with +1 increment between the two numbers
        int[] numbersArray = CreateArray(start, end);

        // Print the array
        Debug.Log("Generated Array:");
        Debug.Log(string.Join(", ", numbersArray));

        // Calculate and print multiples
        PrintMultiples(numbersArray, 2);
        PrintMultiples(numbersArray, 3);
        PrintMultiples(numbersArray, 4);
        PrintMultiples(numbersArray, 5);
    }

    int[] CreateArray(int num1, int num2)
    {
        // Create an array with +1 increment between the two numbers
        int[] numbersArray = new int[Mathf.Abs(num1 - num2) + 1];
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = num1 + i;
        }
        return numbersArray;
    }

    void PrintMultiples(int[] numbers, int multiplier)
    {
        string multiplesString = $"Multiples of {multiplier}: ";
        foreach (var number in numbers)
        {
            if (number % multiplier == 0)
            {
                multiplesString += $"{number} ";
            }
        }
        Debug.Log(multiplesString);
    }
}
