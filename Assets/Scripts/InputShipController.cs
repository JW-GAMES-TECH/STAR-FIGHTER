using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class InputShipController : MonoBehaviour
{
    [Header("=== Ship Movement Settings ===")]
    public float flightSpeed = 50;
    public float rotateSpeed = 20;
    public float upDownSpeed = 10;
    public float turningSpeed = 10;
    public float boostSpeed = 80;

    public Rigidbody rb;


    //Input Values
    private float Move;
    private float Turn;


    //ShipController shipScript;
    private Vector2 _input;


    [System.Serializable]
    public class InputSettings
    {
        public string FowardInput = "Vertical";
        public string strafeInput = "Horizontal";
        public string boostInput = "Boost";

    }






    private void Awake()
    {


    }

    // Start is called before the first frame update
    void Start()
    {
        //shipScript = GetComponent<ShipController>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();

    }

   void HandleMovement()
    {



    }


    public void OnMove(InputAction.CallbackContext context)
    {
        //_input = context.ReadValue<Vector2>();
        //Debug.Log(_input);

        Move = context.ReadValue<float>();



    }

    public void OnTurn(InputAction.CallbackContext context)
    {
        Turn = context.ReadValue<float>();
    }







    //public void Boost(InputAction.CallbackContext context)
    //{
    // _input = context.ReadValue<Vector2>();
    //}

    #region Input Methods














    #endregion

}
