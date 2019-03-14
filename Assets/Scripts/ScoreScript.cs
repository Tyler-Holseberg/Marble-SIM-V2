using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreScript : MonoBehaviour
{
    public int TracksUsed;
    public float TimePassed;
    public int MarblesScored;
    public bool ConditionMet;

    // Start is called before the first frame update
    void Start()
    {
        TracksUsed = 0;
        TimePassed = 0;
        MarblesScored = 0;
        ConditionMet = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(MarblesScored >= 1)
        {
            GetComponent<TextMesh>().text = GetScore().ToString();
        }
    }
    float GetScore()
    {
        float FinalScore=0;
        FinalScore += TracksUsed*25;
        FinalScore += MarblesScored * 100;
        FinalScore = FinalScore - TimePassed;
        return FinalScore;
    }
}
