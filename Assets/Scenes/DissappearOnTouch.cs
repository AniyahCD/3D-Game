using UnityEngine;

public class DissappearOnTouch : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            audioSource.Play();
        }
    }
}
