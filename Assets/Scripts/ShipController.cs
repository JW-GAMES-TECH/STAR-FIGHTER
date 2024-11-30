using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float flightSpeed = 50;
    public float rotateSpeed = 10;
    public float upDownSpeed = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.forward * flightSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        //transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal"));
        transform.Rotate(Vector3.up * rotateSpeed* Time.deltaTime * Input.GetAxis("Horizontal"));
        transform.Rotate(Vector3.right * upDownSpeed * Time.deltaTime * Input.GetAxis("Up/Down"));




    }
}
