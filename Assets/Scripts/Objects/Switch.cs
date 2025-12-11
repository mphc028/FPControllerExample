using UnityEngine;

public class Switch : InteractableObject
{
    private bool _enabled = true;
    [SerializeField] private GameObject _light;

    public override void Interact()
    {
        base.Interact();
        _enabled = !_enabled;
        _light.SetActive(_enabled);
    }
}
