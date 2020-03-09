using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject prefab;
    public float time = 2.0f;
    public float repeatRate = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("testt", time, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void testt()
    {
        Debug.Log("test");
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
