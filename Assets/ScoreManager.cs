using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score ;
    // Start is called before the first frame update
    public void ScoreCalculator(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("score:"+score);

    }
}
