using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public PathCreation.PathCreator path;
    public float speed = 5;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distance += speed * Time.deltaTime;
        transform.position = path.path.GetPointAtDistance(distance) + new Vector3(0, 1, 0);
        transform.rotation = path.path.GetRotationAtDistance(distance);
    }
}
