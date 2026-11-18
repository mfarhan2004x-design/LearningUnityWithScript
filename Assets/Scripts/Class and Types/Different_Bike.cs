using UnityEngine;

public class Different_Bike : MonoBehaviour
{
}

public class  CD70: Bike
{
    public bool hasMirrors; 
}
public class CG125 : Bike
{
    public string kickType = "Long";
}
public class Suzuki150 : Bike
{
    public bool hasABS;
}

public class YamahaR15 : Bike
{
    public bool hasTurbo;
}