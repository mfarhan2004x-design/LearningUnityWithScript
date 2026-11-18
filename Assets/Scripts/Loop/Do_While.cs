using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_While : MonoBehaviour
{
    bool canFire = false;
    double playerHealth = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        do
        {
            canFire = true;
            Debug.Log("Player can fire" + playerHealth.ToString());
            playerHealth--;
        } while (playerHealth > 0);
         
        while (playerHealth > 0)
        {
            canFire = true;
           Debug.Log("Player can fire" + playerHealth.ToString());
            playerHealth--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0 && canFire == true)
        {
            Debug.Log("Player is Dead");
            canFire = false;
        }

    }
}
