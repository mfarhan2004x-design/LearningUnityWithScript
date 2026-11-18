using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    int totalSum1;
    int totalSum2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //  PrintNumbers("Farhan", 20);
        //  PrintNumbers("Ali", 21);
        //  PrintNumbers("Ahmed", 19);
        totalSum1 = Sum(10, 20);
       // Debug.Log("Total Sum is: " + totalSum1);
       totalSum2 = totalSum1 + 100;
        Debug.Log("Total Sum is: " + totalSum2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private int Sum(int sum1, int sum2)
    {
        int tempValue = 0;

        tempValue = sum1 + sum2;

        return tempValue;
    }
    private void PrintNumbers(string studentName, int age)
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(studentName + (" Age: " + age.ToString()) + " Number Printing is " + i.ToString());
        }
    }

}