using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorThatOpens : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void Destroy() {
        this.gameObject.SetActive(false);
    }
}
