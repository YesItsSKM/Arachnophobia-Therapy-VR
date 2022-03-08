// State #3

using UnityEngine;

public class SpiderHappyState : SpiderBaseState
{

    public override void EnterState(SpiderStateManager spiderStateManager)
    {
        Debug.Log("Happy State Entered.");

        spiderStateManager.spiderMoodText.text = "Happy!";
    }

    public override void UpdateState(SpiderStateManager spiderStateManager)
    {

    }
}
