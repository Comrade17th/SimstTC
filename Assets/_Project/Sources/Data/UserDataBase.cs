using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro;
using Unity.VisualScripting;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UserDataBase : MonoBehaviour
{
    [SerializeField] private List<User> users;
    
    [SerializeField] private TextMeshProUGUI _login;
    [SerializeField] private TMP_InputField _password;

    [SerializeField] public User AuthorizedUser;

    [SerializeField] private GameObject _hatter;
    [SerializeField] private Text _hatterLabel;
    [SerializeField] private MainMenuWindow _mainMenuWindow;
    [SerializeField] private Window _wrongInput;

    [SerializeField] private Window _signInWindow;
    [SerializeField] private Window _registerWindow;
    
    [SerializeField] private TMP_InputField _regLogin;
    [SerializeField] private TMP_InputField _regPassword;
    [SerializeField] private TMP_InputField _regName;
    [SerializeField] private TMP_InputField _regForame;
    
    

    private void Awake()
    {
        Assert.IsNotNull(_login);
        Assert.IsNotNull(_password);
        Assert.IsNotNull(_hatterLabel);
        Assert.IsNotNull(_mainMenuWindow);
        Assert.IsNotNull(_signInWindow);
        
        Assert.IsNotNull(_regLogin);
        Assert.IsNotNull(_regPassword);
        Assert.IsNotNull(_regName);
        Assert.IsNotNull(_regForame);
    }

    public void CheckSignIn()
    {
        if (IsCorrectUser())
        {
            Authorize();
        }
        else
        {
            _wrongInput.Open();
        }
    }

    public void Authorize()
    {
        _hatterLabel.text = $"{AuthorizedUser.forname} " +
                            $"{AuthorizedUser.name} " +
                            $"{AuthorizedUser.role}";

        _hatter.SetActive(true);
        _mainMenuWindow.Open();
        _signInWindow.Close();
    }

    public void Register()
    {
        User user = new User(
            _regLogin.text,
            _regPassword.text,
            _regName.text,
            _regForame.text
            );
        
        users.Add(user);
        AuthorizedUser = user;
        Authorize();
    }

    private bool IsCorrectUser()
    {
        string login = _login.text;
        string password = _password.text;
        
        bool isCorrect = false;

        foreach (User user in users)
        {
            Debug.Log($"Input ({login}) ({password}) data ({user.login}) ({user.password}) RES: {user.login == login} {user.password == password}");
            
            if (user.login == login ||
                user.password == password)
            {
                AuthorizedUser = user;
                isCorrect = true;
                break;
            }
        }
        
        return isCorrect;
    }
}
