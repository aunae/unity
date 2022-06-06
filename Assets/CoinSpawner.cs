using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
        const float CREATE_INTERVAL = 2.3f;
        float CreatTime = 0;
        float TotalTIme = 0;

        float NextCreateInterval = CREATE_INTERVAL;

        int Phase = 1;

        public GameObject Coin;

        private void Update()
        {
            TotalTIme += Time.deltaTime;
            CreatTime += Time.deltaTime;
            if (CreatTime > NextCreateInterval)
            {
                CreatTime = 0; ;
                creatCoin();
            }
        }

        private void creatCoin()
        {
            float x = Random.Range(-9f, 9f);
            float z = Random.Range(-9f, 9f);
            createObject(Coin, new Vector3(x, this.transform.position.y, z), Quaternion.Euler(-90,0,0));
        }

        private GameObject createObject(GameObject original, Vector3 position, Quaternion rotation)
        {
            return (GameObject)Instantiate(original, position, rotation);
        }
    }
