using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private bool shouldCallAction = false;
    private bool isUpdating = false;
    // Start is called before the first frame update

    [SerializeField]
    List<TransformToggler> toggles = new List<TransformToggler>(); 
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
        if (!isUpdating) {
            isUpdating = true;
            foreach(TransformToggler child in toggles) {
                // Move shit around
                child.ToggleTransform();
            }
            StartCoroutine(WaitEvent(3));
        }
    }

    private IEnumerator WaitEvent(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        isUpdating = false;
    }
}