using UnityEngine;
using System.Collections;

public class GameMenuGUI : MonoBehaviour {
	public static bool frameEnabled;//현재 메뉴창이 띄워져 있는지 판별 
	
	private static string currentState; //현재 어느 창을 켜고 있나 
	//main, option, environment, return(돌아감 확인) 3종류 
	//return에선 진짜로 돌아갈건지 확인한다.

	//이놈의 enabled를 수정함

	public static void EnablerFrame(bool enb){
		currentState = "main";
	 	frameEnabled = enb;
	}
	
	void Start () {
		//버튼 영역 설정
		frameEnabled = false;//프레임이 열려있는지 확인
		currentState = "main";//현재 프레임 상태 	
	}
	
	//버튼 표시, current 값에 currentState를 넣고 current의 변화에 따라 표시되는 버튼이 달라진다.
	void MainSelect(string current){


		// 메인화면
		/*if(current == "main"){
			GUI.BeginGroup (menuArea);
			
			GUI.DrawTexture(new Rect(0,buttonAreaH*27/609,buttonAreaW,buttonAreaH*582/609),menuFrameImage);
			GUI.DrawTexture (new Rect(0.5f*buttonAreaW*(467-217)/474,0*buttonAreaH/609,buttonAreaW*218/474,buttonAreaH*62/609),menuTitleImage);
			
			if(GUI.Button(new Rect(saveButton), GUIContent.none,saveButtonStyle)){
				
			}
			if(GUI.Button(new Rect(modifyButton), GUIContent.none,modifyButtonStyle)){
				//StartCoroutine("ButtonAction","environment");
			}
			if(GUI.Button(new Rect(optionButton), GUIContent.none,optionButtonStyle)){
				//StartCoroutine("ButtonAction","option");
			}
			if(GUI.Button(new Rect(resumeButton), GUIContent.none,resumeButtonStyle)){
				frameEnabled = false;
				MenuButton.Enabler (false);
			}
			if(GUI.Button(new Rect(returnButton), GUIContent.none,returnButtonStyle)){
				currentState = "return";
			}
			GUI.EndGroup ();
			// 버튼 영역 닫음
			
		} else if (current == "return"){
			GUI.BeginGroup (returnArea);
			
			GUI.DrawTexture(new Rect(0,buttonAreaH*27/609,buttonAreaW,buttonAreaH*368/609),menuFrameHalfImage);
			GUI.DrawTexture (new Rect(0.5f*buttonAreaW*(467-217)/474,0*buttonAreaH/609,buttonAreaW*218/474,buttonAreaH*62/609),menuTitleImage);
			
			
			GUI.Label(new Rect(25*buttonAreaW/474,70*buttonAreaH/609,buttonW,buttonH*2),"Are you really want to\n return to main menu?",textStyle);
			
			if(GUI.Button(new Rect(18.5f*buttonAreaW/474,184*buttonAreaH/609,buttonW,buttonH), GUIContent.none,returnButtonStyle)){
				StartCoroutine("ButtonAction","MainMenu");
			}
			if(GUI.Button(new Rect(18.5f*buttonAreaW/474,282*buttonAreaH/609,buttonW,buttonH), GUIContent.none,resumeButtonStyle)){
				currentState = "main";
				frameEnabled = false;
				MenuButton.Enabler (false);
			}
			GUI.EndGroup ();
		}*/
	}

	
}
