using UnityEngine;

public class FakeMatrix: MonoBehaviour
{
    private void Awake()
    {
        AudioManager.instance.Play("Main Menu");
    }

    public void TestAction()
    {
        DialogueManager.instance.Play("Amogus");
        Debug.Log("I am a fake matrix!");
    }
}
