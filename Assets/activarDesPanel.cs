using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarDesPanel : MonoBehaviour
{
 public GameObject Panel;

 public void activarPanel(){
    Panel.SetActive(true);
 }

  public void desactivarPanel(){
    Panel.SetActive(false);
 }
}
