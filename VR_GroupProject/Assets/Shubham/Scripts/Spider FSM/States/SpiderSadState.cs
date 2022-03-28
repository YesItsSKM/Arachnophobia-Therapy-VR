// State #4

using UnityEngine;

public class SpiderSadState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        spiderStateManager.currentStateNumber = 4;

        spiderStateManager.spiderMoodText.text = "Sad";

        spiderStateManager.spiderMood.enabled = true;
        spiderStateManager.spiderMood.sprite = spiderStateManager.moods[2];

        spiderStateManager.spiderAnimator.Play("LowerBUpdate");
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {
        /*
        if (spiderStateManager.player.leftController.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerValue) && triggerValue)
        {
            spiderStateManager.SwitchStates(spiderStateManager.happyState);
        }

        if (spiderStateManager.player.rightController.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerVal) && triggerVal)
        {
            spiderStateManager.SwitchStates(spiderStateManager.happyState);
        }
        */
    }

}