// State #3

using UnityEngine;

public class SpiderHappyState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        Debug.Log("Happy State Entered.");

        spiderStateManager.spiderMoodText.text = "Happy!";

        spiderStateManager.spiderMood.sprite = spiderStateManager.moods[2];

        spiderStateManager.spiderAnimator.Play("Jump");
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }
}
