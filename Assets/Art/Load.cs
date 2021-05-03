using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{

//    [SerializeField] GameEvents events = null;
 public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "3D":
                SceneManager.LoadScene(0);
                break; 
            case "AR1":
                SceneManager.LoadScene(1);
                break;
        }
        

    }



}