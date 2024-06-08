using UnityEngine;

public class StartGameScreen : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W))
        {
            HidePanel();
        }
    }

    private void HidePanel()
    {
        panel.SetActive(false);  
    }
}
