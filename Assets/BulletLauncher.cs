using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemyPrefab;
    public int speed;
    public float time;
    
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
        time=time+Time.deltaTime;
        if(time>=4.0f)
        {
            float x = Random.Range(-10.0f, 10.0f);
            float y= Random.Range(0.5f, 1.5f);
            float z = Random.Range(-10.0f, 10.0f);
            Instantiate(enemyPrefab, new Vector3(x, y, z),Quaternion.identity);
            time = 0.0f;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
