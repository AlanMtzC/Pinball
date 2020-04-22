using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperscript : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;


    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }


    void Update()
    {
        if(Input.GetAxis(inputName) == 1)
        {

        }
    }
}
