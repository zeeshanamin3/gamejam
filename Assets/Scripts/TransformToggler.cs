using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformToggler : MonoBehaviour
{
    [SerializeField]
    Vector3 transform1;
    
    [SerializeField]
    Vector3 transform2;

    private bool toggleTransform = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform1;
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void ToggleTransform() {
        if (toggleTransform) {
            transform.position = transform1;
        } else {
            transform.position = transform2;
        }
        toggleTransform = !toggleTransform;
    }
}
