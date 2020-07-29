using UnityEngine;

public class Character : MonoBehaviour
{
    #region System methods

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        CheckInputs();
    }

    #endregion


    #region Methods

    private void CheckInputs()
    {
        _movementInput.x = Input.GetAxisRaw("Horizontal");
        _movementInput.y = Input.GetAxisRaw("Vertical");
        _movementInput.Normalize();
    }

    public Transform GetTransform() => _transform;
    public Vector2 GetMovementInput() => _movementInput;
    public float GetWalkSpeed() => _walkSpeed;

    #endregion


    #region Private fields

    private Transform _transform;
    private Vector2 _movementInput;
    private float _walkSpeed = 3f;

    #endregion
}
