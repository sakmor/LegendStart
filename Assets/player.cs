using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0.01f;
    public float jump = 60;
    private Rigidbody Rigidbody;
    void Start()
    {
        Debug.Log("Hello");
        Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey("w"))
        {
            float LastY = Rigidbody.velocity.y; //先把目前Y軸速度紀錄下來 (下墜值)
            Rigidbody.velocity = gameObject.transform.forward * speed; //覆蓋速度，使Player往前
            Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, LastY, Rigidbody.velocity.z);//還原下墜值，使Player下墜
        }
        if (Input.GetKey("s"))
        {
            float LastY = Rigidbody.velocity.y; //先把目前Y軸速度紀錄下來 (下墜值)
            Rigidbody.velocity = gameObject.transform.forward * -speed; //覆蓋速度，使Player往前
            Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, LastY, Rigidbody.velocity.z);//還原下墜值，使Player下墜
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
        }
    }
}
