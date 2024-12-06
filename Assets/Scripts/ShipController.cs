using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipController : MonoBehaviour
{
    public float flightSpeed = 50;
    public float rotateSpeed = 20;
    public float upDownSpeed = 10;
    public float turningSpeed = 10;
    public float boostSpeed = 80;

    

    

   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * flightSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Translate(Vector3.forward * boostSpeed * Time.deltaTime * Input.GetAxis("Boost"));

        //transform.Translate(Vector3.forward * turningSpeed * Time.deltaTime * Input.GetAxis("Turn"));
        transform.Rotate(Vector3.up * turningSpeed* Time.deltaTime * Input.GetAxis("Horizontal"));
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime * Input.GetAxis("Turn"));
        transform.Rotate(Vector3.right * upDownSpeed * Time.deltaTime * Input.GetAxis("Up/Down"));



        //transform.Translate(Vector3.forward * flightSpeed * Time.deltaTime);

    }


    

}
