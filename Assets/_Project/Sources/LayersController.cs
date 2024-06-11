using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LayersController : MonoBehaviour
{
    [SerializeField] private GameObject layer0;
    [SerializeField] private GameObject layer1;
    [SerializeField] private GameObject layer2;

    [SerializeField] private Transform CM_target;

    private float layer0Y = -3f;
    private float layer1Y = 0f;
    private float layer2Y = 3;
    private void Awake()
    {
        Assert.IsNotNull(layer0);
        Assert.IsNotNull(layer1);
        Assert.IsNotNull(layer2);
        Assert.IsNotNull(CM_target);
    }


    public void ShowLayer0()
    {
        layer1.SetActive(false);
        layer2.SetActive(false);
        CM_target.transform.position = NewTargetPosition(layer0Y);
    }
    
    public void ShowLayer1()
    {
        layer1.SetActive(true);
        layer2.SetActive(false);
        CM_target.transform.position = NewTargetPosition(layer1Y);
    }
    
    public void ShowLayer2()
    {
        layer1.SetActive(true);
        layer2.SetActive(true);
        CM_target.transform.position = NewTargetPosition(layer2Y);
    }

    private Vector3 NewTargetPosition(float yNewPosition)
    {
        return new Vector3(
            CM_target.position.x,
            yNewPosition,
            CM_target.position.z
            );
    }
}
