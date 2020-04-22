using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperscript : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    public int axisValue = 1;

    HingeJoint hinge;
    public string inputName;


    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }


    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        Debug.Log(Input.GetAxisRaw("Horizontal"));
        if(Input.GetAxisRaw("Horizontal")== axisValue)
        //if(Input.GetButton(inputName))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
