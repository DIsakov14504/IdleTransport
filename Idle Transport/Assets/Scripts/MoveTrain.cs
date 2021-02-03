using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrain : MonoBehaviour
{
    GameObject train;
    float speed = -0.5f;
    float angle = 90f;
    float r = 15.5f;
    bool inCircle = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == new Vector3(-50, 2.3f, 3.2f)) inCircle = true;
        if (transform.position == new Vector3(-50, 2.3f, -28f))
        {
            inCircle = false;
            speed = 0.5f;
        }
        if (inCircle)
        {
            angle += 1.5f;
            var x = -50 + r * (Mathf.Cos(Mathf.PI * angle / 180));
            var z = -12.5f + r * (Mathf.Sin(Mathf.PI * angle / 180));
            transform.position = new Vector3(x, 2.3f, z);
            transform.Rotate(new Vector3(0, -1.5f, 0));
        }
        else
        {
            transform.position += new Vector3(speed, 0, 0);
        }
    }
}
