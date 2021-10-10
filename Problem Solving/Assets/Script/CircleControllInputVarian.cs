using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControllInputVarian : MonoBehaviour
{

    public float speed = 10.4f;

    private bool IsMoving = false;
    Vector3 followPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ballFollow();
        }
        ballMove();

    }
    void ballMove()
    {
        //bergerak dengan imputan keyboard wasd
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
        IsMoving = false;
    }

    void ballFollow()
    {
        //bergerang dengan mengikuti cursor
        followPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        followPosition.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, followPosition, speed * Time.deltaTime);
        if(transform.position == followPosition)
        {
            IsMoving = true;
        }

    }

    
}
