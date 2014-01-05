using UnityEngine;
using System.Collections;


public class MainFrame : MonoBehaviour {
	//각각이 Main Frmae 내의 텍스쳐들 
	//Strat 내에서 위치를 지정해준다.
	public Texture edge_ne;
	public Texture edge_nw;
	public Texture edge_se;
	public Texture frame_e;
	public Texture frame_s1;
	public Texture frame_s2;
	public Texture frame_w;

	void OnGUI(){
		GUI.DrawTexture(new Rect(Screen.width-78*Screen.width/1920,0,78*Screen.width/1920,48*Screen.height/1280),edge_ne,ScaleMode.StretchToFill);
		GUI.DrawTexture(new Rect(0,0,83*Screen.width/1960,48*Screen.height/1280),edge_nw,ScaleMode.StretchToFill);
		GUI.DrawTexture(new Rect((1920-44)*Screen.width/1920,(1280-218-48)*Screen.height/1280,45*Screen.width/1920,51*Screen.height/1280),edge_se,ScaleMode.StretchToFill);
		
		GUI.DrawTexture(new Rect(285*Screen.width/1920,(1280-67)*Screen.height/1280,624*Screen.width/1920,34*Screen.height/1280),frame_s1,ScaleMode.StretchToFill);
		GUI.DrawTexture(new Rect((1920-47-965)*Screen.width/1920,(1280-218-32)*Screen.height/1280,969*Screen.width/1920,218*Screen.height/1280),frame_s2,ScaleMode.StretchToFill);

		GUI.BeginGroup (new Rect(0,48*Screen.height/1280,35*Screen.width/1920,(1280-(113+47))*Screen.height/1280));
		GUI.DrawTexture(new Rect(0,0,35*Screen.width/1920,1120*Screen.height/1280),frame_w,ScaleMode.StretchToFill);
		GUI.EndGroup ();
		
		GUI.BeginGroup (new Rect(Screen.width-31*Screen.width/1920,48*Screen.height/1280,30*Screen.width/1920,(1280-(48+218)-47)*Screen.height/1280));
		GUI.DrawTexture(new Rect(0,0,30*Screen.width/1920,(1280-40-216-47)*Screen.height/1280),frame_e,ScaleMode.StretchToFill);
		GUI.EndGroup ();
	}
	
}
