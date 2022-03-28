// State #6

using UnityEngine;

public class SpiderLovedState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        spiderStateManager.currentStateNumber = 6;

        spiderStateManager.spiderMoodText.text = "Loved!";

        spiderStateManager.spiderMood.enabled = true;
        spiderStateManager.spiderMood.sprite = spiderStateManager.moods[4];

        spiderStateManager.spiderAnimator.Play("Jump");
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }
}
