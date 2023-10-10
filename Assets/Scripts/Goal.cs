using System.Collections;
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
