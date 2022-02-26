using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playerTransform;
    Vector3 Offset;

    void Awake()
    {
        playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
        Offset= transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Offset + playerTransform.position;
    }
}
