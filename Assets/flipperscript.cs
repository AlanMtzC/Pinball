using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperscript : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;

    public string inputName;


    void Start()
    {
        
    }


    void Update()
    {
        if(input.GetAxis(inputName) == 1)
        {

        }
    }
}
