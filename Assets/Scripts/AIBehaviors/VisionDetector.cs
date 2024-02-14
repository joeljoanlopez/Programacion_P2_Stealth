using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionDetector : MonoBehaviour
{
    [SerializeField] private float _visionRange;
    [SerializeField] private float _visionAngle;

    public float VisionRange
    { get { return _visionRange; } }

    public float VisionAngle
    { get { return _visionAngle; } }

    private Transform _target;

    public bool IsPlayerClose(Transform transform)
    {
        var dist = Vector3.Distance(transform.position, _target.position);
        return (dist < _visionRange);
    }
}