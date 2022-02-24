using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject  tempBullet;

            tempBullet= Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            tempBullet.transform.position=transform.position;
           // Camera camera=GetComponentInChildren<Camera>();

            tempBullet.GetComponent<Rigidbody>().velocity = Camera.main.transform.rotation*Vector3.forward*speed;

        }

    }
}
