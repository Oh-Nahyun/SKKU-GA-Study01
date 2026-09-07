using UnityEngine;

public class StaticExample : MonoBehaviour
{
    private void Start()
    {
        Animal cat1 = new Cat("야옹이1", 30f, 7);
        Animal cat2 = new Cat("야옹이2", 30f, 7);
        Animal cat3 = new Cat("야옹이3", 30f, 7);
        
        //Debug.Log(cat._name); // new 연산자를 통해 메모리에 클래스의 객체가 생성되면 그 객체의 속성에 접근
        Debug.Log(Cat.Count); // 3마리
        
        // static은 유틸리티 관련 함수를 만드는데 유용하게 사용한다.
        // Vector, String, Mathf, Input, Physics, Singleton
    }
}
