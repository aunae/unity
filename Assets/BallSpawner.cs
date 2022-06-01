using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    const float CREATE_INTERVAL = 1.5f;
    float mCreatTime = 0;
    float mTotalTIme = 0;

    float mNextCreateInterval = CREATE_INTERVAL;

    int mPhase = 1;

    public GameObject ball;

    private void Update()
    {
        mTotalTIme += Time.deltaTime;
        mCreatTime += Time.deltaTime;
        if (mCreatTime > mNextCreateInterval)
        {
            mCreatTime = 0; ;
            creatBall();
        }
    }

    private void creatBall()
    {
        float x = Random.Range(-9f, 9f);
        float z = Random.Range(-9f, 9f);
        createObject(ball, new Vector3(x, this.transform.position.y, z), Quaternion.identity);
    }

    private GameObject createObject(GameObject original, Vector3 position, Quaternion rotation)
    {
        return (GameObject)Instantiate(original, position, rotation);
    }
}