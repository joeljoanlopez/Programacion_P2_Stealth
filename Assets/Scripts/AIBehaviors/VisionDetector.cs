using UnityEngine;

public class VisionDetector : MonoBehaviour
{
    [SerializeField] private float _visionRange;
    [SerializeField] private float _visionAngle;
    [SerializeField] private LayerMask _visibleLayers;
    [SerializeField] private Transform _target;
    private Vector3 _forward;
    private Vector3 _targetDirection;
    private RaycastHit2D _hit;

    private PathFollower _pathFollower;

    public float VisionRange
    { get { return _visionRange; } }

    public float VisionAngle
    { get { return _visionAngle; } }

    public Transform Target
    { get { return _target; } }

    public Vector3 Forward
    { get { return _forward; } }

    private void Start()
    {
        _pathFollower = GetComponent<PathFollower>();
    }

    private void Update()
    {
        _forward = Vector3.Normalize(_pathFollower.CurrentWP.position - transform.position);
        _targetDirection = _target.position - transform.position;
    }

    public bool IsTargetClose()
    {
        var dist = Vector3.Distance(transform.position, _target.position);
        return (dist < _visionRange) && IsTargetSeeable();
    }

    public bool IsTargetInAngle()
    {
        var angle = GetAngle();
        return angle < _visionAngle / 2 && angle != 0;
    }

    private float GetAngle()
    {
        float angle = Vector2.Angle(_forward, _targetDirection);
        return angle;
    }

    private bool IsTargetSeeable()
    {
        _hit = Physics2D.Raycast(
            transform.position,
            _targetDirection,
            _visionRange,
            _visibleLayers
            );
        Debug.DrawRay(transform.position, _targetDirection, Color.yellow);
        return (_hit.collider.transform == _target);
    }
}