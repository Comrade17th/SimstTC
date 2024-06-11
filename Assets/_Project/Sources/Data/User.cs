using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class User
{
    public string login;
    public string password;
    public string name;
    public string forname;
    public string role;

    public User(string _login, string _password, string _name, string _forname)
    {
        login = _login;
        password = _password;
        name = _name;
        forname = _forname;
        role = $"User";
    }
}
