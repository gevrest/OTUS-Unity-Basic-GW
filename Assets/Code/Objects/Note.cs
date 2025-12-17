using UnityEngine;

namespace Game
{
    public sealed class Note : InteractableObject
    {
        [SerializeField] private NoteContent _noteContent;

        public override void Interact()
        {
            _noteContent.Open();
        }
    }
}