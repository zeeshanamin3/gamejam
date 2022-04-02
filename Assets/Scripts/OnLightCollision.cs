using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLightCollision : MonoBehaviour
{
    public Transform player;

    bool isPlayerInLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            isPlayerInLight = true;
            Debug.Log("Player entered light cone");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            isPlayerInLight = false;
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (isPlayerInLight)
    //     {
    //         Debug.Log("Player entered light cone");
    //     }
    // }
}
