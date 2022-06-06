using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    GameObject clonedestory;
    public float GRAVITY = 7.0f;

    private float mVelocity = 1.0f;

    void OntriggerEnter(Collider col)
    {

      
    }
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
        if (transform.position.y < 1.3f)
        {
            clonedestory = GameObject.Find("ball(Clone)"); //이름으로 찾기
            Destroy(clonedestory); //찾은 이름 파괴
        }
    }

}