using UnityEngine;

public class Bike : MonoBehaviour
{
    public int speed;
    public float fuelCapacity;

    public void Accelerate()
    {
        Debug.Log("Bike is accelerating.");
    }

    public void Run()
    {
        Debug.Log("Bike is running.");
    }
}