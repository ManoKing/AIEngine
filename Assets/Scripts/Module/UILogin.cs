using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILogin : MonoBehaviour
{
    public Button login;
    void Start()
    {
        login.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Home");
        });
    }
}
