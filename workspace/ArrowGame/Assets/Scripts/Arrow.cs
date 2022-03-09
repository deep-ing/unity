using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed=0f;

    public Arrow(float speed){
        this.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -this.speed,0);
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Arrow is collide!");     
        Destroy(this.gameObject);
    }
}
