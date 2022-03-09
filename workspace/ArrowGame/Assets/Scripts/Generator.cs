using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject arrowPrefab;
    public float delta = 0f;        
    public float span = 1.0f;     
    public float arrowSpeed = 0.1f;
    public bool stop = false;

    // Update is called once per frame
    void Update()
    {
        if (! this.stop){
            this.delta += Time.deltaTime;
            if (this.delta > this.span){
                GameObject arrow = Instantiate<GameObject>(arrowPrefab);
                float px = Random.Range(-4f, 4f);
                arrow.transform.position = new Vector3(px, 8, 0);
                // arrow.speed = this.arrowSpeed;
                this.delta = 0;
            }        
        }
    }
}
