using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI input;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        UsernameHolder.Instance.username = input.text;
    }
}
