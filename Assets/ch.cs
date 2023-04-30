using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch : MonoBehaviour
{
    public GameObject cube14;

    public void Button228(){
 cube14.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

}