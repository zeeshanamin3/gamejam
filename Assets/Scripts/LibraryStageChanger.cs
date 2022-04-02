using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryStageChanger : MonoBehaviour
{
    private bool shouldCallAction = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider other)
    {
        PlayerMovement movement = other.GetComponent<PlayerMovement>();
        movement.SetIsCollidingWithAction(GetComponent<Collider>());
    }

    void OnTriggerExit(Collider other) {
        PlayerMovement movement = other.GetComponent<PlayerMovement>();
        movement.SetIsCollidingWithAction(null);
    }

    public void TriggerStateChange() {
        
        // foreach(TransformToggler child in GetComponentInChildren<TransformToggler>()) {
        //     // Move shit around
        //     // child.Rotate(new Vector3(0,180,0));

        // }
    }

    // private v
}
