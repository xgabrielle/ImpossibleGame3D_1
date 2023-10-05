using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
  IEnumerator OnCollisionEnter(Collision other)
  {
    
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene("EndScene");
  }
}
