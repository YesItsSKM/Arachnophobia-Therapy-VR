// State #2

using UnityEngine;
using UnityEngine.XR;

public class SpiderSadState : SpiderBaseState
{
    

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        Debug.Log("Sad State Entered.");

        spiderStateManager.spiderMoodText.text = "Sad";
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {
        if (spiderStateManager.player.leftController.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerValue) && triggerValue)
        {
            spiderStateManager.SwitchStates(spiderStateManager.happyState);
        }

        if (spiderStateManager.player.rightController.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerVal) && triggerVal)
        {
            spiderStateManager.SwitchStates(spiderStateManager.happyState);
        }
    }

}
