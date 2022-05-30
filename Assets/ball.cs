using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float GRAVITY = 7.0f;

    private float mVelocity = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current = this.transform.position;

        mVelocity += GRAVITY * Time.deltaTime;

        current.y -= mVelocity * Time.deltaTime;
        this.transform.position = current;
       /* if(transform.position.y < 0.3f)
        {
            Destroy(gameObject);
        }*/
    }
}