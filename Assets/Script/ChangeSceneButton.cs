using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public string sceneName; // The name of the scene to change to

    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}