using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncouplingFromTheRope : MonoBehaviour
{
    private HingeJoint2D _joint2D;

    private void Start()
    {
        _joint2D = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            _joint2D.enabled = false;
        }
    }
}
