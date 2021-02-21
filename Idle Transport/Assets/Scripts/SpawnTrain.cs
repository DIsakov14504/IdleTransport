using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrain : MonoBehaviour
{
    public GameObject holder;
    public GameObject loco;
    public GameObject original;
    public PathCreation.PathCreator path;
    const int dst = 10;
    int count;
    public void Generate()
    {
        count = holder.transform.childCount;
        if (count < 36)
        {
            Vector3 point = loco.transform.position;
            float dist = path.path.GetClosestDistanceAlongPath(point) - dst * (count + 1);
            Instantiate(original, holder.transform);
            holder.transform.GetChild(count).GetComponent<Follower>().path = path;
            holder.transform.GetChild(count).GetComponent<Follower>().distance = dist;
            holder.transform.GetChild(count).GetComponent<Follower>().loco = loco;
        }
    }
}
