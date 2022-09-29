using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsController : MonoBehaviour
{
    public Transform armRotation;
    public float min = -30;
    public float max = 30;

    float elevation = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotacionInput = Input.GetAxis("Mouse Y");
        elevation = Mathf.Clamp(elevation + rotacionInput, min, max);
        armRotation.localRotation = Quaternion.Euler(-elevation, 0, 0);

    }
}
