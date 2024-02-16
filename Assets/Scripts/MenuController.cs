using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Gameplay");
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    private void OnGUI()
    {

        GUI.Label(new Rect(200, 10, 200, 20), ("Press enter to start"));
        GUI.Label(new Rect(100, 10, 200, 20), ("Press esc to exit"));

    }
}