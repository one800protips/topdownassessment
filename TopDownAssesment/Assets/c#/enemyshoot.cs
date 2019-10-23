using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletlifetime = 1.0f;
    public float shootdelay = 1.0f;
    float timer = 0;
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootdelay)
        {
            timer += Time.deltaTime;
            timer = 0;
            GameObject enemybullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 playerposition = player.position;
            Vector2 shootDir = new Vector2(playerposition.x - transform.position.x,
                playerposition.y - transform.position.y);
            shootDir.Normalize();
            enemybullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(enemybullet, bulletlifetime);
        }

      
    }
}
