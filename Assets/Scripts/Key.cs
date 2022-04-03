using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    string key;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void OnTriggerEnter(Collider other) {
        PlayerMovement movement = other.GetComponent<PlayerMovement>();
        movement.AddKey(key);
        this.gameObject.SetActive(false);
    }
}
