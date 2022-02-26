using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item: MonoBehaviour
{
    public float rotateSpeed;

    void Update()
    {
        // local 좌표계
        // transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // global 좌표계
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}