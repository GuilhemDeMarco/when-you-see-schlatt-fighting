using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeController : MonoBehaviour
{
    public stayInside stayInside;
    public float test = 7f;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeBoxSize(test);
    }
    public void ChangeBoxSize(float newSize)
    {
        stayInside.limitHorizontal = newSize;
        stayInside.limitVertical = newSize;

        this.transform.GetChild(0).gameObject.transform.localScale = new Vector3(newSize * 10 + 10 + 5, newSize * 10 + 10 + 5, 1);//;
        this.transform.GetChild(1).gameObject.transform.localScale = new Vector3(newSize * 10 + 10, newSize * 10 + 10, 1);//;

    }
}
