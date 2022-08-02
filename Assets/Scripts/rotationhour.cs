using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationhour : MonoBehaviour
{
    //float rotationleft = 360;
    float rotationspeed = 0.5f;
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
