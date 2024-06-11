using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro;

public class UserDataBase : MonoBehaviour
{
    [SerializeField] private User[] users;
    [SerializeField] private TextMeshProUGUI _login;

    private void Awake()
    {
        throw new NotImplementedException();
    }

    public void CheckSignIn()
    {
        
    }
}
