using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpiderStateManager : MonoBehaviour
{
    public HandAnimation player;
    public LayerMask whatIsPlayerHands;

    SpiderBaseState currentState;
    
    public SpiderIdleState idleState = new SpiderIdleState();           // 1

    public SpiderHungryState hungryState = new SpiderHungryState();     // 2
    public SpiderSickState sickState = new SpiderSickState();           // 3
    public SpiderSadState sadState = new SpiderSadState();              // 4

    public SpiderHappyState happyState = new SpiderHappyState();        // 5
    public SpiderLovedState lovedState = new SpiderLovedState();        // 6


    public int currentStateNumber;
    int nextState = 1;                                           // idle
    public float moodChangeFrequency = 5f;

    public TextMeshProUGUI spiderMoodText;

    public Image spiderMood;
    public Sprite[] moods;

    public float pettingRange;

    public Animator spiderAnimator;


    // Start is called before the first frame update
    void Start()
    {
        currentState = idleState;

        currentState.EnterState(this);

        InvokeRepeating("GenerateNextState", moodChangeFrequency, moodChangeFrequency);

    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }


    public void SwitchStates(SpiderBaseState state) 
    {
        currentState = state;
        currentState.EnterState(this);
    }

    void GenerateNextState()
    {
        nextState = Mathf.FloorToInt(Random.Range(1f, 5f));

        if(nextState == 5)
        {
            nextState = 4;
        }

        if (nextState == 1 && (currentStateNumber == 5 || currentStateNumber == 6))
        {
            nextState = 1;
        }
        else
        {
            ;
        }

        switch (nextState)
        {
            case 1:
                SwitchStates(idleState);
                break;

            case 2:
                SwitchStates(hungryState);
                break;

            case 3:
                SwitchStates(sickState);
                break;

            case 4:
                SwitchStates(sadState);
                break;

            default:
                break;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, pettingRange);
    }
}
