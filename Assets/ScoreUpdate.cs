using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    public static int Score = 0;
    // Start is called before the first frame update
    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100),"Score:"+ Score.ToString());
       
    }
}
