using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsernameHolder : MonoBehaviour
{
    public static UsernameHolder Instance;
    public string username;

    void Start()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);    
    }
}
