using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
        const float CREATE_INTERVAL = 2.3f;
        float mCreatTime = 0;
        float mTotalTIme = 0;

        float mNextCreateInterval = CREATE_INTERVAL;

        int mPhase = 1;

        public GameObject Coin;

        private void Update()
        {
            mTotalTIme += Time.deltaTime;
            mCreatTime += Time.deltaTime;
            if (mCreatTime > mNextCreateInterval)
            {
                mCreatTime = 0; ;
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
