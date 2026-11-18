using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{
    // Farhan Faron Ferzen Fvernz
    private string myName = "Ferzen";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (myName == "Farhan")
        {
            Debug.Log("Hello, and Welcome Farhan");
        }
        else if (myName == "Faron")
        {
            Debug.Log("Hello, and Welcome Faron");
        }
        else if (myName == "Ferzen")
        {
            Debug.Log("Hello, and Welcome Ferzen");
        }
        else if (myName == "Fvernz")
        {
            Debug.Log("Hello, and Welcome Fvernz");
        }

        // We Use Switch Statements to make the code more readable and efficient and also when we have multiple conditions to check for a single variable.
        // Switch Statements are used to check for multiple conditions for a single variable and execute the code block for the matching condition.
        // Switch Statements are used when there is more than one else if condition to check for a single variable. It is more efficient than using multiple if else statements.

        switch (myName)
        {
            case "Farhan":
                Debug.Log("Hello, and Welcome Farhan");
                break;
            case "Faron":
                Debug.Log("Hello, and Welcome Faron");
                break;
            case "Ferzen":
                Debug.Log("Hello, and Welcome Ferzen");
                break;
            case "Fvernz":
                Debug.Log("Hello, and Welcome Fvernz");
                break;
            default:
                Debug.Log("Invalid Person");
                break;
        }

    }
}
