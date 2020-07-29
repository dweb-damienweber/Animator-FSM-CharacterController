using UnityEngine;

public class PlayerWalk : CharacterStateBase
{
    #region System methods

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (GetCharacter(animator).GetMovementInput() == Vector2.zero)
        {
            animator.SetBool("IsWalking", false);
            return;
        }

        Transform characterTransform = GetCharacter(animator).GetTransform();
        Vector2 moveInput = GetCharacter(animator).GetMovementInput();

        characterTransform.eulerAngles = Vector3.up * Mathf.Atan2(moveInput.x, moveInput.y) * Mathf.Rad2Deg;
        characterTransform.Translate(Vector3.forward * GetCharacter(animator).GetWalkSpeed() * Time.deltaTime);
    }

    #endregion
}
