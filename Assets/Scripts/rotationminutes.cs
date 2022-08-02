using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationminutes : MonoBehaviour
{
    //float rotationleft = 360;
    float rotationspeed = 12f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        float rotation = rotationspeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotation);
    }


}

