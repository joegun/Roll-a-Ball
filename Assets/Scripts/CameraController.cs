using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    //float distance = 3.0f;
    //float height = 3.0f;
    //float damping = 5.0f;
    //bool smoothRotation = true;
    //float rotationDamping = 10.0f;

    //void Update()
    //{
    //    //var wantedPosition = player.transform.TransformPoint(0, height, -distance);
    //    //transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);

    //    if (smoothRotation)
    //    {
    //        var wantedRotation = Quaternion.LookRotation(player.transform.position - transform.position, player.transform.up);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
    //    }
    //    else transform.LookAt(player.transform, player.transform.up);
    //}


    void Start()
    {
        offset = transform.position - player.transform.position;
    //    //offset = new Vector3(0, -22, 10); // or whatever you need
    //    offset = new Vector3(0, 22, 20);    //just put the values that you want instead of y and z
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    //    //transform.rotation = player.transform.rotation;

    //    Vector3 flatSpeed = player.GetComponent<Rigidbody>().velocity;
    //    flatSpeed.y = 0;
    //    //stores the flat velocity of your player so it can put the camera always behind it

    //    Quaternion wantedRotation = new Quaternion();

    //    //if (flatSpeed != Vector3.zero)
    //    //{
    //        float targetAngle = Quaternion.LookRotation(flatSpeed).eulerAngles.y;
    //        wantedRotation = Quaternion.Euler(0, targetAngle, 0);
    //    //}

    //    transform.position = player.transform.position + (wantedRotation * offset);
    //    transform.LookAt(player.transform);
    }

    //void LateUpdate()
    //{
    //    //transform.position = player.transform.position + offset;
    //    //Vector3 lookVec = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    //    //Quaternion targetRotation = Quaternion.LookRotation(lookVec, Vector3.back);
    //    //transform.rotation = Quaternion.Lerp(player.transform.rotation, targetRotation, Time.time * 1.0f);
    //}
}
