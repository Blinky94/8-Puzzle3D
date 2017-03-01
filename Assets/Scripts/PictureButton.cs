using UnityEngine;
using System.Collections;

public class PictureButton : MonoBehaviour 
{
	
    Texture image;
    GUIContent content ;
 
 void Start()
 {
     //image = (Texture)Resources.Load("Pause.jpg");
    // content.image = image;
 }
 
 void OnGUI()
 {
    // GUI.Button(Rect(0, 0, 128, 128), content);
 }

}
