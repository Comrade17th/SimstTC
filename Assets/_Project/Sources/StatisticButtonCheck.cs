using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class StatisticButtonCheck : MonoBehaviour
{
    [SerializeField] private UserDataBase _database;

    private void Awake()
    {
        Assert.IsNotNull(_database);

        if (_database.AuthorizedUser.role == "Admin")
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
