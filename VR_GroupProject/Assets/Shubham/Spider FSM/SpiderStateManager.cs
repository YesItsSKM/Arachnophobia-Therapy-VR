using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpiderStateManager : MonoBehaviour
{
    public HandAnimation player;

    [SerializeField] SpiderBaseState currentState;
    
    public SpiderIdleState idleState = new SpiderIdleState();       // 1
    public SpiderSadState sadState = new SpiderSadState();          // 2
    public SpiderHappyState happyState = new SpiderHappyState();    // 3

    public int nextState = 1;                                       // idle
    public float moodChangeFrequency = 5f;

    public TextMeshProUGUI spiderMoodText;


    // Start is called before the first frame update
    void Start()
    {
        spiderMoodText = FindObjectOfType<TextMeshProUGUI>();

        //spiderMoodText.text = "Happy!";

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
        nextState = Mathf.FloorToInt(Random.Range(1f, 4f));

        if(nextState == 4)
        {
            nextState = 3;
        }

        // print("nextState: " + nextState);

        switch (nextState)
        {
            case 1:
                SwitchStates(idleState);
                break;

            case 2:
                SwitchStates(sadState);
                break;

            case 3:
                SwitchStates(happyState);
                break;

            default:
                break;
        }
    }
}
