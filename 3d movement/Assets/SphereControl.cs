using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody thisRigid;
    public Camera camera;

    public float speed;
    public Vector2 torque;
    
    public 
    
    void Start()
    {
        thisRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
