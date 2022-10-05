using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitLevel()
    {
        Application.Quit();
    }
}
