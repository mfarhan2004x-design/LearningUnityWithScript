using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable_property : MonoBehaviour
{
    int _marks = 100;  // private variable: start with underscore followed by variable name 
    public int Marks // public property: start with capital letter followed by variable name
    {
        get 
        { 
        //    return _marks; 
            return _marks * 2;
        } // getter method to access the private variable
        set {
            if (value >= 0)
            { _marks = value; }
        } // setter method to modify the private variable
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i <100; i++)
        {
         //   Marks = Marks - 1;
            Debug.Log("Marks:" + Marks);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
