// State #5

using UnityEngine;

public class SpiderHappyState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        spiderStateManager.currentStateNumber = 5;

        spiderStateManager.spiderMoodText.text = "Happy!";

        spiderStateManager.spiderMood.enabled = true;
        spiderStateManager.spiderMood.sprite = spiderStateManager.moods[3];

        spiderStateManager.spiderAnimator.Play("Jump");
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }
}
