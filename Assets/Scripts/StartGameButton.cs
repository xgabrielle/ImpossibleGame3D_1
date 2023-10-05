using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    private void FixedUpdate()
    {
        //transform.rotation(2, 1, 1);
    }

    public void HoverStart()
    {
        transform.localScale = Vector3.one * 1.1f;
    }
    public void HoverEnd()
    {
        transform.localScale = Vector3.one;
    }
    public void ClickStart()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.magenta;
        mr. material.SetColor("EmissinColor", Color.magenta);
        
    }
    public void ClickEnd()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.yellow+Color.red;
        mr.material.SetColor("EmissonColor", Color.yellow+Color.red);
    }
    public void Click()
    {
        SceneManager.LoadScene("GameScene");
    }

    bool isTouchingGround()
    {
        int layermask = LayerMask.NameToLayer("Ground");
        Physics.CheckBox(transform.position, transform.lossyScale / 2,
            transform.rotation,layermask);
        return true;
    }
    
}
