using UnityEngine;

namespace Game
{
    [RequireComponent (typeof (CharacterController))]
    public sealed class PlayerController : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private CharacterController _characterController;

        [Header("Values")]
        [SerializeField] private float _moveSpeed = 5.0f;
        [SerializeField] private float _sprintSpeed = 10.0f;
        [SerializeField] private float _jumpForce = 0.5f;
        [SerializeField] private float _gravity = -9.81f;

        private Vector3 _velocity;

        private void Update()
        {
            if (Time.timeScale == 0f)
            {
                return;
            }

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
            moveDirection *= (Input.GetKey(KeyCode.LeftShift) ? _sprintSpeed : _moveSpeed);

            _velocity.y += _gravity * Time.deltaTime;

            if (_characterController.isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                _velocity.y = Mathf.Sqrt(_jumpForce * -2f * _gravity);
            }

            _characterController.Move(moveDirection * Time.deltaTime);
            _characterController.Move(_velocity * Time.deltaTime);
        }
    }
}