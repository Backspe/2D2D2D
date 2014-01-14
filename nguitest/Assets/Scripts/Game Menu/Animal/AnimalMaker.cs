using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/*
Comp_Coord<T>는 각각의 AnimalComponent가 있는 삼각형꼴 좌표평면상의 좌표와
AnimalComponent 자체가 포함되어있다. 
T에는 AnimalComponent를 넣으면 되고 다시 쓸때는 다운캐스팅해서 쓰면 된다.
이를 저장하는 방법은 HashSet을 사용한 리스트로 작성하였다.
*/

public class Comp_Coord : System.IEquatable<Comp_Coord>{
	private int X;
	private int Y;//삼각형꼴 좌표평면 상에서의 좌표를 말한다 
	public int x {
		get{ return X; }
		set{ X=x;}
	}
	public int y {
		get{ return Y;}
		set{ Y = y;}
	}
	public Comp_Coord (int _x,int _y){
		this.X = _x;
		this.Y = _y;
	}

	public bool Equals (Comp_Coord obj)//두개가 같은 좌표에 있는지 판별하는 메소드
	{
		return ((obj.x == this.x) && (obj.y == this.y));
	}

	public override int GetHashCode(){
		return x.GetHashCode () ^ y.GetHashCode ();
	}
}

public class Animal{
	public HashSet<Comp_Coord> CompCoords; // 이 해시셋 안에 좌표가 놓여있음. 좌표 중복을 막기 위해 해시셋 이용
	public Dictionary<Comp_Coord,AnimalComponents> CompList;//Comp_Coord에 따른 AnimalComponent를 넣는다.

	public float weightAll; // 각 부분의 무게와 내구도의 합
	public float shieldAll;

	public double position_x;
	public double position_y;
	public double rotation;

	public Animal() : this(0,0){}

	public Animal(double x, double y){
		this.position_x = x;
		this.position_y = y;
		Core core = new Core (0,0);//초기엔 0,0좌표에 코어를 넣어준다. 

		CompCoords= new HashSet<Comp_Coord>();
		CompCoords.Add (new Comp_Coord(0,0));//해시셋에 좌표 넣음

		CompList = new Dictionary<Comp_Coord, AnimalComponents> ();
		CompList.Add (new Comp_Coord (0, 0), core);//딕셔너리에 초기 코어 좌표와 코어를 넣는다.
	}
}

public class AnimalComponents { // Core,Part,Body 등 생물체를 이루는 구성요소
	public GameObject prefab_comp;
	//이 성분이 갖는 prefab (구성 요소의 그림이 들어간다.)

	public float weight; //각 부분의 무게, 내구도
	public float shield;

	public const double edge_len = 60.0; 
	// 삼각형의 한변의 길이. position =(edge_len* 떨어진 삼각형의 좌표) 로 사용하기 위한 수이다.

	public AnimalComponents nextComp_a;
	// 위쪽으로부터 시계방향으로 a,b,c 부분의 변애 있는 요소를 말한다  
	// 파츠인 경우에는 붙이는 부분에 있는 요소를 말한다.

	public bool a_enabled; 
	// a변에 파츠나 바디가 연결되어 있으면 false / 아니면 true
	// 즉 a 변에 무언가를 붙일 수 있는지를 의미한다.

	public double position_x;//코어로부터 상대적 위치
	public double position_y;
	public double rotation; 
	/*	코어로부터 상대적 회전각 
		삼각형이면 코어랑 같은 회전각일때 0 으로 반시계방향으로 돌면서 degree 각도로 증가
		파츠 평면이면 코어가 위쪽을 바라보는 정삼각형인 상태에서 파츠가 위쪽을 바라보면 0도
		이 역시 반시계 방향으로 돌면서 degree가 증가
	*/

}

public class Core : AnimalComponents {
	public bool b_enabled;
	public bool c_enabled;

	public AnimalComponents nextComp_b;
	public AnimalComponents nextComp_c; //각 설명은 위쪽 참조

	public Core() : this(0,0){}
	public Core(double x, double y){
		this.position_x = x;
		this.position_y = y;
		this.a_enabled = true;
		this.b_enabled = true;
		this.c_enabled = true;
		//this.prefab_comp = _prefab;
	}
}

public class Part : AnimalComponents {

	public Part() : this(0,0){}
	public Part(double x, double y){
		this.position_x = x;
		this.position_y = y;
		this.a_enabled = true;
	}

}

public class Body : AnimalComponents {
	public bool b_enabled;
	public bool c_enabled;

	public AnimalComponents nextComp_b;
	public AnimalComponents nextComp_c;

	public Body():this(0,0){}
	public Body(double x, double y){
		this.position_x = x;
		this.position_y = y;
		this.a_enabled = true;
		this.b_enabled = true;
		this.c_enabled = true;
	}
}

public class AnimalMaker : MonoBehaviour {

	void MakeAnimal(double x, double y, double rot, GameObject _newCore){
		//Animal _newAn = new Animal(x,y);
		//Debug.Log(((Core)_newAn.Comp_this).b_enabled);
		//Instantiate(_newCore,transform.position,transform.rotation);
	}
	void MakeTest(){
		Animal _newAn = new Animal(0,0);
		//Debug.Log(((Core)_newAn.Comp_this[0,0]).b_enabled);
	}
	void MakePart(double x, double y, double rot, GameObject _newPart){

	}

	void DeletePart(GameObject _delPart){

	}
	void DeleteAnimal(GameObject _delAnimal){

	}
}
