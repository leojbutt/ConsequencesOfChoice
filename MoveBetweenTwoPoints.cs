using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackForward : MonoBehaviour
{

    public float start;
    public float end;
    public float length;
    public float speed;

    //Define start and end points
    void Start()
    {
        start = transform.position.x;
        end = start + length;
    }

    //Move transform between these points 
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, end - start) + start, transform.position.y, transform.position.z);
    }
}
