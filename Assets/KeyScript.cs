using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public DoorManager DoorManager;
    public AudioClip audioClip;
    public void TakeKey()
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        DoorManager.haveKey = true;
        Destroy(gameObject);
    }
}
