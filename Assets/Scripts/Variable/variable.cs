using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    // string = text;
    // int = number;
    // float = decimal number;
    // bool = true or false;
    // char = single character;
    // double = decimal number with more precision;

    private string myName = "My Name is Farhan";
    private int myAge = 20;
    private float myHeight = 5.9f;
    private double myWeight = 80.5;
    private bool isStudent = true;
    private char myInitial = 'F';

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myName);
    }
}
