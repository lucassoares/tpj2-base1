using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inpu : MonoBehaviour
{
    public static KeyCode pulo;
    public static KeyCode frente;
    public static KeyCode tras;
    public static KeyCode agachar;

    public static bool GetPulo()
    {
        return Input.GetKey(pulo);
    }
    public static bool GetFrente()
    {
        return Input.GetKey(frente);
    }
    public static bool GetTras()
    {
        return Input.GetKey(tras);
    }
    public static bool GetAgachar()
    {
        return Input.GetKey(agachar);
    }

}
