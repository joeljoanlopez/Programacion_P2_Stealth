using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionDetector : MonoBehaviour
{
    [SerializeField] private float _visionRange;
    [SerializeField] private float _visionAngle;
    [SerializeField] private Transform _target;

    [SerializeField] private bool _inAngle;

    public float VisionRange
    { get { return _visionRange; } }

    public float VisionAngle
    { get { return _visionAngle; } }

    public Transform Target
    { get { return _target; } }

    public bool IsTargetClose(Transform target)
    {
        var dist = Vector3.Distance(target.position, _target.position);
        return (dist < _visionRange);
    }

    public bool IsTargetInAngle(Transform target)
    {
        var angle = GetAngle(target);
        return angle < _visionAngle / 2;
    }

    private float GetAngle(Transform target)
    {
        Vector2 _targetDirection = target.position - transform.position;
        float angle = Vector2.Angle(_targetDirection, transform.right);
        return angle;
    }
}