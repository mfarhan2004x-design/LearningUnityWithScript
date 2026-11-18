using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bike general_bike = new Bike();
        general_bike.speed = 60;
        general_bike.fuelCapacity = 4.5f;
        general_bike.Accelerate();
        general_bike.Run();

        Debug.Log("General Bike Speed" + general_bike.speed + " Fuel Capacity: " + general_bike.fuelCapacity);

        CG125 cg125 = new CG125();

        cg125.kickType = "Short";
        
        cg125.speed = 100;
        cg125.fuelCapacity = 5.0f;
        cg125.Accelerate();
        cg125.Run();
        Debug.Log("CG125 Speed" + cg125.speed + " Fuel Capacity: " + cg125.fuelCapacity);

        YamahaR15 yamahaR15 = new YamahaR15();

        yamahaR15.hasTurbo = true;
        
        yamahaR15.speed = 150;
        yamahaR15.fuelCapacity = 15.0f;
        yamahaR15.Accelerate();
        yamahaR15.Run();
        Debug.Log("Yamaha R15 Speed" + yamahaR15.speed + " Fuel Capacity: " + yamahaR15.fuelCapacity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
