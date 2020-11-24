using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public AudioSource audio;
    public GameObject SoonGonnaBeSlave;
    public Rigidbody rb;
    public Light lamp;
    public Camera cam;


    void Start()
    {
        audio.mute = true;
        SoonGonnaBeSlave.name = "Slave";
        rb.drag = 15;
        lamp.intensity = 30;
        lamp.cookieSize = 300;
        cam.depth = 123.45f;
    }

    void Update()
    {
    }
}
