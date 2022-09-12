using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTrans : MonoBehaviour
{
    public float speed =8f;
    private float horizontalInput;
    private float forwardInput;

    public float rotacionSpeed = 100f;
    private float rotacionInput;

    public float thrust = 6f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        rotacionInput = Input.GetAxis("Mouse X");

        Vector3 direccion = new Vector3(horizontalInput, 0, forwardInput);
        direccion = Vector3.ClampMagnitude(direccion, 1);

        transform.Translate(direccion * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime * rotacionSpeed * rotacionInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
    }
}


