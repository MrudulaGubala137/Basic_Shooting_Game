using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreManager score;
   public float time;

    private void Update()
    {
      time=time+Time.deltaTime;
        if(time>3f)
        {
            Destroy(gameObject);
            time=0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Destroy(collision.gameObject);
            score = GameObject.Find("ScoreBoard").GetComponent<ScoreManager>();
            score.ScoreCalculator(10);
        }
 
    }
   
}