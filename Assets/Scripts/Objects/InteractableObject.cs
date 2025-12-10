using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private GameObject _light;
    private bool _enabled = true;

    public void Interact()
    {
        _enabled = !_enabled;
        _light.SetActive(_enabled);
        Debug.Log("InteractableObject Interacted!");
    }
}
