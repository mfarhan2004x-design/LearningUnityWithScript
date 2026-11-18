using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPlayer : MonoBehaviour
{
    public string name;
    public int age;
    public float height;
    public string skinColor;

    public void Walk()
    { Debug.Log(name + "Player is walking."); }


    public void Run()
    { Debug.Log(name + "Player is running."); }
}