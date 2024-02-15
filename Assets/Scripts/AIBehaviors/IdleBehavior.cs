using UnityEngine;

public class IdleBehavior : StateMachineBehaviour
{
    [SerializeField] private float _idleTime = 0.0f;

    private VisionDetector _visionDetector;
    private float _timer;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _visionDetector = animator.GetComponent<VisionDetector>();
        _timer = 0.0f;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("_isChasing", _visionDetector.IsTargetInAngle(animator.transform));
        animator.SetBool("_isPatrolling", IsTimeUp());
    }

    private bool IsTimeUp()
    {
        _timer += Time.deltaTime;
        return _timer > _idleTime;
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