using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    const float CREATE_INTERVAL = 1.5f;
    float CreatTime = 0;
    float TotalTIme = 0;

    float NextCreateInterval = CREATE_INTERVAL;

    int Phase = 1;

    public GameObject ball;

    private void Update()
    {
        TotalTIme += Time.deltaTime;
        CreatTime += Time.deltaTime;
        if (CreatTime > NextCreateInterval)
        {
            CreatTime = 0; ;
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