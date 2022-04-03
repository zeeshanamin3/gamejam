using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBallTrigger : MonoBehaviour
{
    private bool isUpdating = false;
    // Start is called before the first frame update

    [SerializeField]
    Transform player = null;
    [SerializeField]
    LaunchBall ballLauncher = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            Debug.Log("Player Entered");
            // Instantiate
            ballLauncher.Fire();
        }
    }

    void OnTriggerExit(Collider other) {
        // PlayerMovement movement = other.GetComponent<PlayerMovement>();
        // movement.SetIsCollidingWithAction(null);
    }

    public void TriggerStateChange() {
        // if (!isUpdating) {
        //     isUpdating = true;
        //     foreach(TransformToggler child in toggles) {
        //         // Move shit around
        //         child.ToggleTransform();
        //     }
        //     StartCoroutine(WaitEvent(3));
        // }
    }

    private IEnumerator WaitEvent(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        isUpdating = false;
    }
}
