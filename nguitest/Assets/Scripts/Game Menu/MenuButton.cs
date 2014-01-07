using UnityEngine;
using System.Collections;


public class MenuButton: MonoBehaviour {
	public static bool menuEnabled;//메뉴 표시 상태 
	public static bool returnEnabled;//리턴메뉴 표시 상태

	public GameObject _menuFrame;
	public GameObject _returnFrame;
	void Start () {
		menuEnabled = false;
	}
	void ReturnMenuClick(){
		if(returnEnabled){
			Application.LoadLevel("MainMenu");
		}else{
			menuEnabled = false;
			returnEnabled = true;
			NGUITools.SetActive(_menuFrame,false);
			NGUITools.SetActive(_returnFrame,true);
			//UIImageButton _rFRS = _returnFrame.FindChild("ReturnSystem").GetComponent<UIImageButton>();
		}
	}
	void ModifyingClick(){

	}
	void OptionsClick(){
	}
	void SaveAndLoadClick(){
	}
	void MenuButtonClick(){//커서 눌르고 뗐을때 
		if(menuEnabled){	 
			menuEnabled = false;
			NGUITools.SetActive(_menuFrame,false);
		} else{
			menuEnabled = true;
			NGUITools.SetActive(_menuFrame,true);
			//_menuFrame.Find("ReturnMenu").GetComponent<UIImageButton>().OnHover(false);
		}
		if(returnEnabled){
			returnEnabled = false;
			NGUITools.SetActive(_returnFrame,false);
		}
	}

	public static void Enabler(bool enb){
			menuEnabled = enb;	
	}
}
