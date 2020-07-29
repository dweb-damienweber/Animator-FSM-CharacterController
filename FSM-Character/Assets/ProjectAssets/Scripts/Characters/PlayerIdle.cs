using UnityEngine;

public class PlayerIdle : CharacterStateBase
{
    #region System methods

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (GetCharacter(animator).GetMovementInput() != Vector2.zero)
            animator.SetBool("IsWalking", true);
    }

    #endregion
}
