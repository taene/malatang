using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform tr;
    private float moveSpeed = 5.0f;
    private float turnSpeed = 400.0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        moveDir = moveDir.normalized;

        //tr.position += moveDir * moveSpeed * Time.deltaTime;
        tr.Translate(moveDir * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * r * turnSpeed * Time.deltaTime);
    }
}
