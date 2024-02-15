using UnityEngine;

public class GizmoHandler : MonoBehaviour
{
    private float _visionRange;
    private float _visionAngle;
    private PathFollower _pathFollower;

    private void OnDrawGizmos()
    {
        //Draw Full circle gizmo
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _visionRange);

        //Draw Forward Gizmo
        Vector3 _forward = Vector3.Normalize(_pathFollower.CurrentWP.position - transform.position);

        //Draw Angle Gizmo
        Gizmos.color = Color.red;
        var _direction = Quaternion.AngleAxis(_visionAngle / 2, transform.forward) * _forward;
        Gizmos.DrawRay(transform.position, _direction * _visionRange);
        var _direction2 = Quaternion.AngleAxis(-_visionAngle / 2, transform.forward) * _forward;
        Gizmos.DrawRay(transform.position, _direction2 * _visionRange);
    }

    // Start is called before the first frame update
    private void Start()
    {
        _visionRange = GetComponent<VisionDetector>().VisionRange;
        _visionAngle = GetComponent<VisionDetector>().VisionAngle;
        _pathFollower = GetComponent<PathFollower>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}