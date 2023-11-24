using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TabelaYazi : MonoBehaviour
{
    public Text text;
    public Image image;
    public AudioSource audio;
    public string characterTag = "Karakter";
    public float activationTime = 3f;
    private bool restartRequested = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == characterTag && !restartRequested)
        {
            if (text != null)
            {
                text.enabled = true;
            }
            if (image != null)
            {
                image.enabled = true;
            }
            if (audio != null)
            {
                audio.Play();
            }
            restartRequested = true;
            StartCoroutine(DeactivateUI());
        }
    }

    IEnumerator DeactivateUI()
    {
        yield return new WaitForSeconds(activationTime);
        if (text != null)
        {
            text.enabled = false;
        }
        if (image != null)
        {
            image.enabled = false;
        }
    }
}
