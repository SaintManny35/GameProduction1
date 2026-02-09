using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed = 3.0f; // Speed of platform
    public int startingPoint;
    public Transform[] points;

    private int i;
    public bool vertical; // Determines whether the platform will move along the x or y axis.

    new Rigidbody2D rigidbody2D;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = points[startingPoint].position; // Setting the position of the platform to the position of one
                                                             // points using index "startingPoint"
    }

    // Update is called once per frame
    void Update()
    {
        
        // checking the distance of the platform and the point
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++; // increase the index
            if (i == points.Length) // check if the platform was on the last point after the index increase
            {
                i = 0; // reset the index
            }
        }

        // moving the platform to the point position with the index "i"
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.position.y > transform.position.y)
        {
        collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }

}

