using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform tf;
    public MeshRenderer mr;
    public CapsuleCollider cc;
    public Rigidbody rb;
    public MeshFilter mf;
    public Player play;
    public GameObject cube;
    public Material mat;
    public Mesh m;
    public int testvar;
    private int x;

    


    void Start()
    {
       testvar = 15;
       rb.useGravity = false;
    }

    public void ButtonClicked()
    {
        rb.mass = 15;
        rb.useGravity = true;
        tf.position = new Vector3(1f, 2f, 1f);
        cc.radius = 4f;
        mf.mesh = m;
        play.testvar = 30;
    }

    void Update()
    {
        
    }
}
