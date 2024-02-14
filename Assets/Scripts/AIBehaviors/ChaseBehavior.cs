using UnityEngine;

public class ChaseBehavior : StateMachineBehaviour
{
    [SerializeField] private float _speed = 0.0f;

    private float _visionRange;
    private float _visionAngle;
    private Transform _target;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _visionRange = animator.GetComponent<VisionDetector>().VisionRange;
        _target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("_isChasing", IsPlayerClose(animator.transform));

        Vector2 _dir = _target.position - animator.transform.position;
        animator.transform.position += (Vector3)_dir.normalized * _speed * Time.deltaTime;
    }

    private bool IsPlayerClose(Transform transform)
    {
        bool _isPlayerSeen = false;
        var dist = Vector3.Distance(transform.position, _target.position);

        return _isPlayerSeen;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}