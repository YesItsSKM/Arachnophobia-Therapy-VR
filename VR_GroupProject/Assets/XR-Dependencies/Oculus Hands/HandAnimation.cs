using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandAnimation : MonoBehaviour
{
    public Animator leftHandAnimator, rightHandAnimator;
    public InputDevice leftController, rightController;

    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        leftController = devices[0];
        rightController = devices[1];
    }
    void Update()
    {
        AnimateHands();
    }

    private void AnimateHands()
    {
        if (leftController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            leftHandAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            leftHandAnimator.SetFloat("Trigger", 0f);
        }

        if (leftController.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            leftHandAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            leftHandAnimator.SetFloat("Grip", 0f);
        }



        if (rightController.TryGetFeatureValue(CommonUsages.trigger, out float rTriggerValue))
        {
            rightHandAnimator.SetFloat("Trigger", rTriggerValue);
        }
        else
        {
            rightHandAnimator.SetFloat("Trigger", 0f);
        }

        if (rightController.TryGetFeatureValue(CommonUsages.grip, out float rGripValue))
        {
            rightHandAnimator.SetFloat("Grip", rGripValue);
        }
        else
        {
            rightHandAnimator.SetFloat("Grip", 0f);
        }
    }
}
