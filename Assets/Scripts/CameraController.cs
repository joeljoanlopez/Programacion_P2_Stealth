using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _offset = new Vector3(0f, 0f, -10f);

    private float _smoothTime = 0.25f;
    private Vector3 _velocity = Vector3.zero;
    [SerializeField] private Transform _target;

    // Update is called once per frame
    private void Update()
    {
        Vector3 _targetPosition = _target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, _targetPosition, ref _velocity, _smoothTime);
    }
}