using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformToggler : MonoBehaviour
{
    // [SerializeField]
    Vector3 transform1;
    
    [SerializeField]
    Vector3 transform2;
    [SerializeField]
    Vector3 rotate;

    private bool toggleTransform = false;
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = transform1;
        transform1 = transform.position;
    }

    // // Update is called once per frame
    // void Update()
    // {
    // //    transform.Rotate(0, 0.3f, 0, Space.Self ); 
    // //    transform.SetPositionAndRotation(transform.position, new Quaternion(0, 0.3f, 0, 0));
    // }

    public void ToggleTransform() {
        // if (toggleTransform) {
        //     transform.position = transform1;
        // } else {
        //     transform.position = transform2;
        // }
        transform.Rotate(rotate, Space.Self);
        toggleTransform = !toggleTransform;
    }
}
