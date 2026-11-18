using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{

    public string[] studentsName = new string[] { "Farhan", "Faron", "Ferzen", "Fvernz", "Fahad" };
    public int[] studentsAge = new int[] { 20, 21, 22, 23, 24 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     //   foreach (string name in studentsName)
     //   {
     //       Debug.Log("Student Name: " + name);
     //   }
     //   foreach (int age in studentsAge)
     //   {
     //       Debug.Log("Student Age: " + age);
     //   }
    
        for (int i = 0; i < studentsName.Length; i++)
        {
            Debug.Log("Student Name: " + studentsName[i]);
        }


    }
    // We have only work on for loop and foreach loop in this script. We have not worked on while loop and do while loop in this script. We will work on while loop and do while loop in the next script.

    // Update is called once per frame
    void Update()
    {
        
    }
}
