// State #2

using UnityEngine;

public class SpiderHungryState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        spiderStateManager.currentStateNumber = 2;

        spiderStateManager.spiderMoodText.text = "Hungry";

        spiderStateManager.spiderMood.enabled = true;
        spiderStateManager.spiderMood.sprite = spiderStateManager.moods[0];

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
