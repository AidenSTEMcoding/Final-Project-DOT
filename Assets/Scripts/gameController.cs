using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string startscene;


    public void LoadLevel() {
        SceneManager.LoadScene(startscene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
