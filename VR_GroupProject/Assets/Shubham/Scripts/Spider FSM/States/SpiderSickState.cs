// State #3

using UnityEngine;

public class SpiderSickState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        spiderStateManager.currentStateNumber = 3;

        spiderStateManager.spiderMoodText.text = "Sick";

        spiderStateManager.spiderMood.enabled = true;
        spiderStateManager.spiderMood.sprite = spiderStateManager.moods[1];

        spiderStateManager.spiderAnimator.Play("LowerBUpdate");
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }

}
