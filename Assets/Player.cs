using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CapsuleCollider CapC;
    // Start is called before the first frame update
    void Start()
    {
        CapC = GetComponent<CapsuleCollider>();
    }
    void OnTriggerEnter(Collider CapC)
    {
        if(CapC.gameObject.tag == "Coin")
        {
            CapC.gameObject.SetActive(false);
        }
       /* if (CapC.GameObject.CompareTag("Enemy"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            SceneManager.LoadScene("gameoversence");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 7.0f;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
       
    }
}
