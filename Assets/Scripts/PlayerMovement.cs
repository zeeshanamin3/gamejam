using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    bool isActionPressed = false;

    // TODO Make this generic
    TileActionTrigger touchingObject = null;

    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    public HashSet<string> keys = new HashSet<string>();

    // TODO: Make this generic
    [SerializeField]
    LibraryStageManager state_Manager = null;

    void Start ()
    {
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
        m_AudioSource = GetComponent<AudioSource> ();
        // keys.Add("LibraryKey");
    }

    void FixedUpdate ()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        bool fire = Input.GetButton("Jump");

        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize ();

        bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool ("IsWalking", isWalking);
        
        if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop ();
        }

        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation (desiredForward);

        // Action
        if (fire && touchingObject != null)
        {
            Debug.LogError("Action pressed.");
            touchingObject.TriggerStateChange();
        }
    }

    void OnAnimatorMove ()
    {
        m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation (m_Rotation);
    }

    public bool GetIsActionPressed()
    {
        return isActionPressed;
    }

    public TileActionTrigger GetIsCollidingWithAction()
    {
        Debug.LogError("Action turned on.");
        return touchingObject;
    }

    public void SetIsCollidingWithAction(Collider other) {
        Debug.LogError("Action turned off.");
        touchingObject = other.GetComponent<TileActionTrigger>();
    }

    public void AddKey(string key) {
        keys.Add(key);
    }
}