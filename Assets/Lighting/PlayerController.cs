using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 80;
        speed = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * x * turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * y * speed * Time.deltaTime);
    }
}
