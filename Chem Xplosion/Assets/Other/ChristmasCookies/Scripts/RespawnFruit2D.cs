using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFruit2D : MonoBehaviour {
    public float velocityY = 10;
    public float width = 1;
    public float maxTimeRespawn = 3;

    public GameObject[] Fruits;


    public void Update()
    {
        if (Time.time > maxTimeRespawn)
        {
            GameObject Fruit = (GameObject)Instantiate(Fruits[Random.Range(0, Fruits.Length)], 
                                                        transform.position + new Vector3(Random.Range(-width, width), 0, 0), 
                                                        new Quaternion(Random.value, Random.value, -Random.value, 0));
            if (Fruit.GetComponent<Rigidbody2D>())
            {
                Fruit.GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocityY);
                Fruit.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-15, 15));
            }

            float size = Random.value;
            Fruit.transform.localScale += new Vector3(size, size, size); 

            Destroy(Fruit, 5);
            maxTimeRespawn = Time.time + Random.Range(0, 3);
        }
    }
}
