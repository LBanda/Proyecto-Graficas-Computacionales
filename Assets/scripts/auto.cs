using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 10;
    int index = 0;
    public bool isLoop = true;

        void Start () {

        }


        void Update () {

            Vector3 destination = waypoints[index].transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, speed * Time.deltaTime);
            transform.position = newPos;

            float distance = Vector3.Distance(transform.position, destination);
            if(distance <= 0.05){
                if(index < waypoints.Count-1){
                    index ++;
                }
                else{
                    if(isLoop){
                        index = 0;
                    }
                }
            }
        }
}
