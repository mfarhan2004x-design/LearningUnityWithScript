using UnityEngine;

public class UnityTypesVsCustomTypes : MonoBehaviour
{
    public HumanPlayerI human;

    public Camera main_camera;

    public 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        human.Walk();

        main_camera.backgroundColor = Color.yellow;
   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
