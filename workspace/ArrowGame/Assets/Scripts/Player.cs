using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float OriginHP = 10;
    public float HP;
    public float Speed = 0.01f;
    public float JumpSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        this.HP = this.OriginHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-this.Speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(this.Speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space)){
            transform.Translate(0, JumpSpeed,  0);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(other.name);
        if (other.tag == "Arrow"){
            this.HP -= 1;
            Debug.Log(HP);
        }

    }
}
