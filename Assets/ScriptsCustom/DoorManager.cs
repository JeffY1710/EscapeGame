using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;
using System.Diagnostics;
public class DoorManager : MonoBehaviour
{
    [SerializeField] AudioClip sound;
    [SerializeField] XRSimpleInteractable interactable;
    public bool haveKey { get; set; }

    private void OnEnable()
    {
        interactable.selectEntered.AddListener(OpenIronDoor);
    }

    public void OpenIronDoor(SelectEnterEventArgs selectEnterEventArgs)
    {
        if (haveKey)
        {
            OpenDoor(transform);
        }
    }
    public void OpenDoor(Transform objectPos)
    {
        objectPos.DORotate(new Vector3(0, -90f, 0), duration: 0.5f);
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }

    public void CloseDoor(Transform objectPos)
    {
        objectPos.DORotate(new Vector3(0, 0, 0), duration: 0.5f);
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
