using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 3f)
        {
            Destroy(gameObject);
            time = 0;
        }
    }
}
