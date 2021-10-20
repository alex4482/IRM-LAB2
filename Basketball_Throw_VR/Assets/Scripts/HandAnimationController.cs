using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class HandAnimationController : MonoBehaviour
{
    public Animator animator;
    public XRDeviceSimulator deviceSimulator;

    private void Update()
    {
        if(deviceSimulator.m_TriggerInput == true)
        {
            StartTrigger();
        }
        else
        {
            StopTrigger();
        }
    }

    public void StartTrigger()
    {
        animator.SetBool("Trigger", true);
    }

    public void StopTrigger()
    {
        animator.SetBool("Trigger", false);
    }

    public void StartGrab()
    {
        animator.SetBool("Grab", true);
    }

    public void StopGrab()
    {
        animator.SetBool("Grab", false);
    }
}
