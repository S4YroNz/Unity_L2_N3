using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionWithRopes : MonoBehaviour
{
    private HingeJoint2D _joint;
    private Transform _transform;

    private void Start()
    {
        _joint = GetComponent<HingeJoint2D>();
        _transform = GetComponent<Transform>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Segment8")
        { 
            _joint.enabled = true;
            _joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
            _joint.anchor = _transform.InverseTransformPoint(collision.contacts[0].point);
        }
    }
}
