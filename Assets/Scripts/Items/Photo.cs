using UnityEngine;
using UnityEngine.UI;

public class Photo : MonoBehaviour
{

    [SerializeField] Sprite imageSprite;
    [SerializeField] Image picture;

    private void Awake()
    {
        picture.sprite = imageSprite;
    }

    public void OnActivate()
    {
        MouseLook.instance.Pause();
        AudioManager.instance.Play("Photo");
    }

    public void Back()
    {
        MouseLook.instance.Unpause();
    }

}
