using UnityEngine;

namespace Game
{
    public sealed class RaycastInteractor : MonoBehaviour
    {
        [SerializeField] private Transform _rayPoint;

        private void Update()
        {
            if (Physics.Raycast(_rayPoint.position, _rayPoint.forward, out var hitInfo))
            {
                if (hitInfo.collider is IInteractable interactable)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                        interactable.Interact();
                }
            }
        }
    }
}