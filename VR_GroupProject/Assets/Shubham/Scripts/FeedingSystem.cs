using UnityEngine;

public class FeedingSystem : MonoBehaviour
{
    public SpiderStateManager spiderState;

    void OnTriggerEnter(Collider collision)
    {
        //print(collision.transform.name);

        if (collision.transform.CompareTag("Edible"))
        {
            //print(collision.transform.name + " " + collision.transform.tag);

            Destroy(collision.transform.gameObject, 0.1f);

            spiderState.SwitchStates(spiderState.happyState);
        }
    }
}
