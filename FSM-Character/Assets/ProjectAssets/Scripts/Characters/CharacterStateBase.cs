using UnityEngine;

public class CharacterStateBase : StateMachineBehaviour
{
    #region Methods

    public Character GetCharacter(Animator animator)
    {
        if (_character == null)
            _character = animator.GetComponent<Character>();

        return _character;
    }

    #endregion

    
    #region Private fields

    private Character _character;

    #endregion
}
