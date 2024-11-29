using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterShip : MonoBehaviour
{
    Rigidbody starFighterRB;

    public float verticalMove = 10f;
    public float horizontalMove = 10f;
    public float mouseInputX;
    public float mouseInputY;
    public float rollInput = 5;

    [SerializeField]
    float speedMult = 1;
    [SerializeField]
    float speedMultAngle = 0.5f;
    [SerializeField]
    float speedRollMultAngle = 0.05f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        starFighterRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");
        rollInput = Input.GetAxis("Roll");

        mouseInputX = Input.GetAxis("Mouse X");
        mouseInputY = Input.GetAxis("Mouse Y");

    }

     void FixedUpdate()
    {
         starFighterRB.AddForce(starFighterRB.transform.TransformDirection(Vector3.forward) *verticalMove * speedMult,ForceMode.VelocityChange);  
    }
}
