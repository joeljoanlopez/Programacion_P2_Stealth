using UnityEngine;

public class PatrolBehavior : StateMachineBehaviour
{
    private VisionDetector _visionDetector;
    private PathFollower _pathFollower;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _visionDetector = animator.GetComponent<VisionDetector>();
        _pathFollower = animator.GetComponent<PathFollower>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _pathFollower.Move();

        animator.SetBool("_isPatrolling", !_pathFollower.ArrivedAtWP());
        animator.SetBool("_isChasing", _visionDetector.IsTargetClose(animator.transform));
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _pathFollower.NextWP();
    }

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