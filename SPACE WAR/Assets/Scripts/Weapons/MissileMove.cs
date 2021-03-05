using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : BulletMove
{
    public float rotateSpeed = 3f;
    private Transform player;

    private WaitForSeconds physicsTimeStep;

    // Start is called before the first frame update
    void Awake()
    {
        myRb = GetComponent<Rigidbody>();
        physicsTimeStep = new WaitForSeconds(Time.fixedDeltaTime);
    }

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
