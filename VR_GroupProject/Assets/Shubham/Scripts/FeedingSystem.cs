using UnityEngine;

public class FeedingSystem : MonoBehaviour
{
    public SpiderStateManager spiderState;

    void OnTriggerEnter(Collider collision)
    {
        if (spiderState.currentStateNumber == 2 && (collision.transform.CompareTag("Edible")))
        {
            Destroy(collision.transform.gameObject, 0.1f);

            spiderState.SwitchStates(spiderState.happyState);
        }

        else if (spiderState.currentStateNumber == 3 && (collision.transform.CompareTag("Pills")))
        {
            Destroy(collision.transform.gameObject, 0.1f);

            spiderState.SwitchStates(spiderState.happyState);
        }
    }
}
