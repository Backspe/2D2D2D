using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class AnimalMaker : MonoBehaviour {
	public GameObject prefab_animal;//animal의 prefab (Animal 스크립트만 넣어져있는 게임오브젝트)
	public GameObject Test_prefab;

	//처음 만들 Animal의 core의 prefab과 위치벡터 v, rotation을 넣어준다.
	public GameObject MakeInitAnimal(GameObject prefab_core,Vector3 pos,Quaternion rot){
		GameObject _animal;
		Coord finder = new Coord(0,0);
		_animal=Instantiate(prefab_animal,pos,rot) as GameObject;
		if (_animal.GetComponent<Animal> ()) {
			_animal.GetComponent<Animal> ().InitAnimal();
			//Debug.Log (_animal.GetComponent<Animal> ().weightAll);
			_animal.GetComponent<Animal> ().CompList[finder]._prefab=Instantiate(prefab_core,pos,rot) as GameObject;
		}
		return _animal;
		//Animal _newAn = new Animal(x,y);
		//Debug.Log(((Core)_newAn.Comp_this).b_enabled);
		//Instantiate(_newCore,transform.position,transform.rotation);
	}
	void MakeTest(){
		//Animal _newAn = new Animal(0,0);
		//Debug.Log(((Core)_newAn.Comp_this[0,0]).b_enabled);
	}
	void MakePart(double x, double y, double rot, GameObject _newPart){

	}

	void DeletePart(GameObject _delPart){

	}
	void DeleteAnimal(GameObject _delAnimal){

	}
	void Start(){

		GameObject testobj = MakeInitAnimal (Test_prefab,Vector3.zero, Quaternion.identity);

	}
}
