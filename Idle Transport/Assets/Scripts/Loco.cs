using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;


public class Loco : MonoBehaviour
{
    public PathCreation.PathCreator path;
    public float speed;
    public float distance;
    public GameObject holder;
    public Text text;
    int dst = 10;
    int count;
    public float sumDistance = 0;
    public float locoDistance = 2000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sumDistance += speed * Time.deltaTime;
        distance += speed * Time.deltaTime;
        transform.position = path.path.GetPointAtDistance(distance) + new Vector3(0, 1, 0);
        transform.rotation = path.path.GetRotationAtDistance(distance);
        count = holder.transform.childCount;
        if (distance >= 550)
        {
            distance = 0;
            int money = Convert.ToInt32(text.GetComponent<Text>().text);
            money += Convert.ToInt32(sumDistance / (locoDistance / 100));
            money += holder.transform.childCount * 50;
            text.GetComponent<Text>().text = Convert.ToString(money);
        }
        if (distance < 50 && distance > 20 || distance < 200 && distance > 170 || distance < 345 && distance > 315 || distance < 440 && distance > 410)
        {
            if (speed > 10)
            {
                speed -= 0.2f;
            }
        }
        else if(distance > 480 + dst * count && distance < 510 + dst * count || distance > 95 + dst * count && distance < 125 + dst * count || distance > 225 + dst * count && distance < 255 + dst * count || distance > 360 + dst * count && distance < 390 + dst * count)
        {
            if (speed < 25)
            {
                speed += 0.2f;
            }
        }
        if (sumDistance >= locoDistance)
        {
            Destroy(holder);
            Destroy(gameObject);
        }
    }
}
