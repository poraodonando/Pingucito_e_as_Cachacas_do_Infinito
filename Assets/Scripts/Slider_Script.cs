using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_Script : MonoBehaviour
{
    public SliderJoint2D slider;
    public JointMotor2D tempo;
    public float vel;
    void Start()
    {
        tempo = slider.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.limitState==JointLimitState2D.LowerLimit)
        {
            tempo.motorSpeed = vel;
            slider.motor = tempo;
        }

        if(slider.limitState == JointLimitState2D.UpperLimit)
        {
            tempo.motorSpeed = -vel;
            slider.motor = tempo;
        }
    }
}
