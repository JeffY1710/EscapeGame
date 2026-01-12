using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;
public class DoorManager : MonoBehaviour
{
    public void OpenDoor(Transform objectPos)
    {
        objectPos.DORotate(new Vector3(0, -90f, 0), duration: 0.5f);
    }

    public void CloseDoor(Transform objectPos)
    {
        objectPos.DORotate(new Vector3(0, 0, 0), duration: 0.5f);
    }
}
