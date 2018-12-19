using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    //private Animator anim;
    private Rigidbody myrigi;

    // Use this for initialization
    void Start()
    {
        //anim = GetComponent<Animator>();
        myrigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //To move in vertically.
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 5, Space.World);
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 5, Space.World);
            transform.eulerAngles = new Vector3(0, 0, 0);

        }

        //To move in horizontally.
        if (Input.GetAxis("Horizontal") > 0)

        {
            transform.Translate(Vector3.left * Time.deltaTime * 5, Space.World);
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5, Space.World);
            transform.eulerAngles = new Vector3(0, 0, 0);

        }

    }
}
