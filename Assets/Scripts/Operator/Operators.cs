using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    // math operators: +, - , *, /, %
    // comparison operators: ==, !=, >, <, >=, <=
    // logical operators: &&, ||, !

    private int num1 = 3;
    private int num2 = 21;

    private int num3 = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ( !(num1 > num2) )
        {
            Debug.Log("Both Conditions are true!!");
        }
    }

   
}
