using UnityEngine;
using System;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {


	private string currentState; //현재 어느 창을 켜고 있나 
	//main, start, instruction, option 4종류 

	//버튼 눌렀을때 실행되는 코루틴 / 다른 씬으로 넘길때 동작
	//levelName이 quit일때는 게임 정지, 아니면 levelName 과 같은 이름의 씬으로 넘어간다.
	/*IEnumerator ButtonAction(string levelName){
	
		yield return new WaitForSeconds(0.3f);
		
		if(levelName != "quit"){
			Application.LoadLevel(levelName);
		} else {
			Application.Quit();
			Debug.Log ("quit");
		}
	}*/

	void Start () {
		currentState = "main";	
	}

	void NewSystemButton(){
		Application.LoadLevel("NewGame");
	}
	void ContinueSystemButton(){

	}
	void ExitButton(){
		Debug.Log ("quit");
		Application.Quit();
	}
	void OptionsButton(){
	}
	void GalleryButton(){
	}
	//버튼 표시, current 값에 currentState를 넣고 current의 변화에 따라 표시되는 버튼이 달라진다.
	void MainSelect(string current){
		
		// 메인화면
		if(current == "main"){
			/*GUI.BeginGroup (menuArea);
			
			GUI.Label(new Rect(0.05f*buttonAreaW,0*buttonAreaH,buttonW,2*buttonH), "2D Life Project");
			
			if(GUI.Button(new Rect(startButton),GUIContent.none,startStyle)){
				StartCoroutine ("ButtonAction","NewGame");
			}
			if(GUI.Button(new Rect(continueButton),GUIContent.none, continueStyle)){
				//StartCoroutine("ButtonAction","Gallery");
			}
			if(GUI.Button(new Rect(optionButton),GUIContent.none, optionStyle)){
				//StartCoroutine("ButtonAction","Option");
			}
			if(GUI.Button(new Rect(quitButton),GUIContent.none, quitStyle)){
				StartCoroutine("ButtonAction","quit");
			}
			if(GUI.Button(new Rect(galleryButton),GUIContent.none, galleryStyle)){
				
			}
			GUI.EndGroup ();
			// 버튼 영역 닫음
			*/
		} 
		/*else if(current == "start"){ // 게임 모드 설정 화면
			
			GUI.BeginGroup (menuArea);
			
			GUI.Label(new Rect(0.1f*buttonAreaW,0.1f*buttonAreaH,buttonW,2*buttonH), list[0].InnerText);
			
			if(GUI.Button(new Rect(startButton), "Normal Mode")){
				StartCoroutine("ButtonAction","game");
			}
			if(GUI.Button(new Rect(galleryButton), "Watching Mode")){
				//StartCoroutine("ButtonAction","game");
			}
			if(GUI.Button(new Rect(optionButton), "Mission")){
				//StartCoroutine("ButtonAction","game");
			}
			if(GUI.Button(new Rect(quitButton), "Back")){
				currentState = "main";
			}
			GUI.EndGroup ();
			// 버튼 영역 닫음
		}*/
	}
	
}
