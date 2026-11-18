using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// In this we are learning about the class and object in unity.
// class is a blueprint for an object and object is an instance of a class.
public class Game : MonoBehaviour
{
    public string randomName = "Faron";
    public int randomAge = 20;
    public float randomHeight = 5.9f;
    public bool canWalk = false;

    public Camera mainCamera;
    public HumanPlayer defaultHumanPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.backgroundColor = Color.red;
      
      // Debug.Log("Default Human Player:" + defaultHumanPlayer.name);

     HumanPlayer playerOne = new HumanPlayer();
        playerOne.name = "Farhan";
        playerOne.age = 20;
        playerOne.height = 5.9f;
        playerOne.skinColor = "Brown";

        playerOne.Walk();
        playerOne.Run();

     HumanPlayer playerTwo = new HumanPlayer();
        playerTwo.name = "Ali";
        playerTwo.age = 25;
        playerTwo.height = 6.1f;
        playerTwo.skinColor = "Fair";

        playerTwo.Walk();
        playerTwo.Run();

    }
}

//public class HumanPlayer : MonoBehaviour
//{
//    public string name;
//    public int age;
//    public float height;
//    public string skinColor;

//    public void Walk()
//    { Debug.Log(name + "Player is walking."); }


//    public void Run()
//    { Debug.Log(name + "Player is running."); }
//}