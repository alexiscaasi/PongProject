using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public bool isGoal1;
    public uint score1 = 0;
    public uint score2 = 0;

    void OnTriggerEnter(Collider other)
        {
            if(isGoal1){
                score1 += 1;
                Debug.Log($"Player2 Scored! Total Score: {score1} - {score2}");
            }
            else{
                score2 += 2;
                Debug.Log($"Player1 Scored! Total Score:{score2} - {score1}");
            }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
