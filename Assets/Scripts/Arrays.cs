using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string studentName = "Farhan";
    public string[] studentsName;
    public string[] newStudentsName = new string[] { "Farhan", "Faron", "Ferzen", "Fvernz", "Fahad" };
    public int[] studentAge = new int[] { 20, 21, 22, 23, 24 };


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Student Name: " + newStudentsName[1]);
        Debug.Log("Student Age: " + studentAge[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
