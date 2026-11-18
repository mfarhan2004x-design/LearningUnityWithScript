using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour
{
    // if(Condition)  {Operation Completed}
    // else if(Condition)  {Operation Completed}
    // else  {Operation Completed}
    private bool isRainingNow = false;
    private bool isSunnyNow = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isRainingNow == true)
        {
            Debug.Log("It's raining now, take an umbrella");
        }
        else if(isSunnyNow == true)
        {
            Debug.Log("It's sunny now, wear sunglasses");
        }
        else
        {
            Debug.Log("It's not raining and sunny now, you can go outside");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
