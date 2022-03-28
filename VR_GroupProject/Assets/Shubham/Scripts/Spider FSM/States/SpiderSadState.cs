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
        if (Physics.CheckSphere(spiderStateManager.gameObject.transform.position, spiderStateManager.pettingRange, spiderStateManager.whatIsPlayerHands))
        {
            spiderStateManager.SwitchStates(spiderStateManager.lovedState);
        }
    }

}
