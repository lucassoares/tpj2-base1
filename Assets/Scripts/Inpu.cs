using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inpu : MonoBehaviour
{
    public KeyCode Pulo;
    public KeyCode Frente;
    public KeyCode Tras;
    public KeyCode Agachar;
    public static bool isJumping;


    void Update()
    {
        if (Input.GetKeyDown(Pulo))
        {
            
        }
        if (Input.GetKeyDown(Frente))
        {

        }
        if (Input.GetKeyDown(Tras))
        {

        }
        if (Input.GetKey(Agachar))
        {
            isJumping = true;
        }

        
    }
    
}
