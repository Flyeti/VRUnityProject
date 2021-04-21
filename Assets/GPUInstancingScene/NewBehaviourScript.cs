using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] objects;

    void Start()
    {
        for(int i = 0; i < 1000; i++)
            Instantiate(objects[0], objects[0].transform.position, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
