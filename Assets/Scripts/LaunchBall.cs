using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 2f;
    public Vector3 m_Direction = new Vector3(1f, 0f, 1f);

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(m_Direction * m_Thrust);
        }
    }
}
