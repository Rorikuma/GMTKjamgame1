using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    float followSpeed = 0.5f;
    float xOffset = 0;
    float yOffset = 17;
    float zOffset = 0;

    GameObject player;

    Vector3 refVect;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x + xOffset, 
            player.transform.position.y + yOffset, player.transform.position.z + zOffset);
        //transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref refVect, followSpeed);
    }
}
