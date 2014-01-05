using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]


public class ReturnButton: MonoBehaviour {
	public AudioClip clickSound;
	public Texture2D hover;//마우스가 위에 있을때 표시하는 그림
	public Texture2D normal;//평상시 버튼 그림 
	
	IEnumerator ButtonAction(string levelName){
		audio.PlayOneShot(clickSound);
		yield return new WaitForSeconds(0.1f);
		Application.LoadLevel(levelName);
	}
	
	void Start () {
		transform.position = new Vector3(0,0,1);
		transform.localScale = Vector3.zero;
		guiTexture.texture = normal;
		guiTexture.pixelInset = new Rect(Screen.width*20/1920,Screen.height*20/1280,Screen.width*107/1920,Screen.height*107/1280);
		//텍스쳐의 크기 위치 지정 
	}
	
	void OnMouseEnter(){//마우스가 위에 떠있을때 
		guiTexture.texture = hover;
	}
	void OnMouseExit(){//커서가 밖으로 나갈때 
		guiTexture.texture = normal;
	}
	void OnMouseUp(){//커서 눌르고 뗐을때 
		StartCoroutine ("ButtonAction","game");
	}

}
