using UnityEngine;
using System.Collections;


public class NewGameGUI : MonoBehaviour {

	private int mapNumber; // 몇번째 맵의 칸을 선택했나 (왼쪽 위부터 1~9)
	private string currentState; //현재 어느 창을 켜고 있나 
	//main, option 2종류


	void Start () {
		currentState = "main";
		mapNumber =1;
	}
	void Maps(GameObject map){
		mapNumber = int.Parse(map.tag);
		Debug.Log (mapNumber);
	}
	void GameStart(){
		Application.LoadLevel("GamePlay");
	}
}
