using UnityEngine;

namespace Game
{
    [RequireComponent (typeof (Collider))]
    public class TrainDestroyer : MonoBehaviour
    {
        [SerializeField] private GameObject _train;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(_train);
            }
        }
    }
}