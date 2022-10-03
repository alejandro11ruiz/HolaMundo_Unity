using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 8.0f;
    public float RotationSpeed = 64.0f;
    public float JumpForce = 6.0f;

    private Rigidbody Physics;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Desplazamiento
        float desID = Input.GetAxis("Horizontal");
        float desAD = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(desID, 0.0f, desAD) * Time.deltaTime * Speed);

        //Rotaci�n
        float rotY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0,rotY*Time.deltaTime*RotationSpeed,0));

        //Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
    }
}
