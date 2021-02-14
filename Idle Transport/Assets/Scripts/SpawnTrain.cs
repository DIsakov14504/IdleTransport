using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrain : MonoBehaviour
{
    GameObject holder;
    public GameObject loco;
    public GameObject original;
    public PathCreation.PathCreator path;
    const int dst = 15;
    int count;
    void Generate()
    {
        count = holder.transform.childCount;
        Vector3 point = loco.transform.position;
        float dist = path.path.GetClosestDistanceAlongPath(point) - dst * count;
        Quaternion rot = path.path.GetRotationAtDistance(dist);
        object obj = Instantiate(original, point, rot, holder.transform);
    }
    private void Update()
    {
        Generate();
    }
}
