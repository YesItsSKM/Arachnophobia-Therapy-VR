using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FeedingSystem : MonoBehaviour
{
    public SpiderStateManager spiderState;

   // public XRBaseController xRController;

    void OnTriggerEnter(Collider collision)
    {
        if (spiderState.currentStateNumber == 2 && (collision.transform.CompareTag("Edible")))
        {
            Destroy(collision.transform.gameObject, 0.1f);

            spiderState.SwitchStates(spiderState.happyState);

            //xRController.SendHapticImpulse(0.7f, 2f);
        }

        else if (spiderState.currentStateNumber == 3 && (collision.transform.CompareTag("Pills")))
        {
            Destroy(collision.transform.gameObject, 0.1f);

            spiderState.SwitchStates(spiderState.happyState);

            //xRController.SendHapticImpulse(0.7f, 2f);
        }
    }
}
