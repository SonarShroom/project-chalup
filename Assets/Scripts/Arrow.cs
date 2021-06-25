using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody RB;
    public bool hiting;
    public float speed;
    public float Damage;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (hiting == false)
        { RB.velocity = transform.forward * speed * Time.deltaTime; }
 

    }
    private void OnCollisionEnter(Collision collision)
    {
        hiting = true;
        RB.velocity = new Vector3(0,0,0);

        RB.isKinematic = true;

    }
}
