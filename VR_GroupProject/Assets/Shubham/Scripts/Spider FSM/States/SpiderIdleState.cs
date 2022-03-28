// State #1

using UnityEngine;

public class SpiderIdleState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        spiderStateManager.currentStateNumber = 1;

        spiderStateManager.spiderMoodText.text = "";

        spiderStateManager.spiderMood.enabled = false;

        spiderStateManager.spiderAnimator.Play("Idle");
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }
}
