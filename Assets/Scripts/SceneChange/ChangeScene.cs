using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToImp1()
    {
        SceneManager.LoadScene("Imp1");
    }

    public void GoToImp2()
    {
        SceneManager.LoadScene("Imp2");
    }

    public void GoToMix()
    {
        SceneManager.LoadScene("ImpMix");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
