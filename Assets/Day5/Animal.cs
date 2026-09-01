using UnityEngine;

// 추상 클래스 : new 연산자를 이용해서 객체를 못만든다. (abstract)
public abstract class Animal
{
    // protected : 외부에서는 접근 분가하지만, 내부 혹은 자식 클래스에서는 접근 가능
    protected string _name = string.Empty; // = ""
    protected float _height = 0f;
    protected double _weight = 0f;

    // virtual : 하위 클래스에서 재정의 가능함을 알려주는 키워드
    
    // 추상 메서드 : 구현이 없는 메소드이므로 하위 클래스에서 무조건 구현을 해야 하는 클래스 (abstract)
    public abstract void Introduce();

    public void Run()
    {
        Debug.Log($"[{_name} 뛰는 중!] 속도 : {100 - (_height / _weight)}");
    }
}