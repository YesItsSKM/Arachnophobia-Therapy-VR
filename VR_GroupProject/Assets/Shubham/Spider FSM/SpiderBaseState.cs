using UnityEngine;

public abstract class SpiderBaseState
{
    public abstract void EnterState(SpiderStateManager spiderStateManager);
    public abstract void UpdateState(SpiderStateManager spiderStateManager);
}
