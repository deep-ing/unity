using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public int itemCount;
    public float jumpPower=10;
    bool isJumping;
    AudioSource audio;
    // public GameManagerLogic maneger;

    void Awake()
    {
        isJumping=false;
        rigid=GetComponent<Rigidbody>();
        audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping){
            isJumping = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Item"){
            itemCount ++;
            // audio.Play();
            other.gameObject.SetActive (false);
            // manager.GetItem(itemCount);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
          if(collision.gameObject.tag == "Floor")
            isJumping = false;
        // else if (collection.gameObject.tag == "Finish"){
        //     if (itemcount == manager.totalItemCount ){
        //         // SceneManager.LoadScene("Example1_"+(manager.stage+1).ToString());
        //         //Game Clear! 

        //     }
        //     else{
        //         SceneManager.LoadScene("Sence0");
        //         //Restart
        //     }
        // }
    }

}
