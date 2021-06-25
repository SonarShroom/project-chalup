using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{

    public float Speed;
    private CharacterController controller;
    Vector3 velocity;

    //Gravity
    public float weight;
    public bool isGrounded;
    public Transform groundcheck;
    public LayerMask groundmask;
    public float grounddistance = 0.4f;
    public float Jumpheight;



    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }






    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);


        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = Mathf.Sqrt(Jumpheight * 2f * weight);

            }

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * Speed * Time.deltaTime);



        velocity.y -= weight * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);





    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(groundcheck.transform.position, grounddistance);
    }

}
