using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawner : MonoBehaviour
{
        public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
//        Vector3 spawnPos = GetComponent<Transform>().position;
//        Instantiate(ballPrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){

        Vector3 spawnPos = GetComponent<Transform>().position;
        Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        }
    }
}
