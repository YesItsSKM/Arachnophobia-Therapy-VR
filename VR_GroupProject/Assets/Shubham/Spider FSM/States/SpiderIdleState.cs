// State #1

using UnityEngine;

public class SpiderIdleState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        Debug.Log("Idle State Entered.");

        spiderStateManager.spiderMoodText.text = "Idle";
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }
}
