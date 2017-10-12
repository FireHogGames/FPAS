using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    
    public void LoadGame(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    //resets all data
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
