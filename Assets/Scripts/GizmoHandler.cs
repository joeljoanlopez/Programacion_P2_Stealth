using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GizmoHandler : MonoBehaviour
{
    [SerializeField] private float _visionRange;

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _visionRange);
    }

    // Start is called before the first frame update
    private void Start()
    {
        _visionRange = GetComponent<VisionDetector>().VisionRange;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}