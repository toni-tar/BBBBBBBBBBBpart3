using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.Find("RoboShlepa").transform;
    }
    void Update()
    {
     transform.position=new Vector3(player.position.x,transform.position.y,transform.position.z);   
    }
}
