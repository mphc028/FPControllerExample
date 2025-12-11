using UnityEngine;

public class Door : InteractableObject
{
    private bool _open = true;
    [SerializeField] private Animator _doorAnimator; 

    public override void Interact()
    {
        base.Interact();
        _open = !_open;
        _doorAnimator.SetBool("isOpen", _open);
    }
}
