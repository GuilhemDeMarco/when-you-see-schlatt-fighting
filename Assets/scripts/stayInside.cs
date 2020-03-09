using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayInside : MonoBehaviour
{
    public float limitHorizontal = 10f;
    public float limitVertical = 10f;
    
    // Update is called once per frame
    void Update()
    {
        float limitUp = limitVertical / 2;
        float limitDown = -(limitVertical / 2);
        float limitRight = limitHorizontal / 2;
        float limitLeft = -(limitHorizontal / 2);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, limitLeft, limitRight), Mathf.Clamp(transform.position.y, limitDown,limitUp));
    }
    
}
