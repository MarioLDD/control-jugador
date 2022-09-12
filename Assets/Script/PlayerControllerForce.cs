using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerForce : MonoBehaviour
{
    public float force = 400f;
    public float rotacionSpeed = 100f;
    private float rotacionInput;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        rotacionInput = Input.GetAxis("Mouse X");

        Vector3 vector = new Vector3(horizontalInput, 0.5f, forwardInput);
        rb.AddForce(vector * force * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime * rotacionSpeed * rotacionInput);

    }
}
