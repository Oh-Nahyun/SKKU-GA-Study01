using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    private void Start()
    {
        // 다형성 (폴리모피즐) (많을다 형태형 성질성)
        // 하나의 객체가 여러 타입(자료형)을 가질 수 있는 성질
        
        // Person person1 = new Person("박보검", 26, 179f, 80, false);
        // Cat cat1 = new Cat("삠삐", 30, 10);
        //
        // Person person2 = new Person("김태희", 21, 170f, 45, false);
        // Dog dog1 = new Dog("누리", 50, 15);
        //
        // Person person3 = new Person("이민호", 25, 178f, 70, true);
        // Dog dog2 = new Dog("덕자", 50, 10);
        
        // 즉, 강아지는 강아지이자 동물 타입도 될 수 있음
        
        Animal person1 = new Person("박보검", 26, 179f, 80, false);
        Animal cat1 = new Cat("삠삐", 30, 10);
        
        Animal person2 = new Person("김태희", 21, 170f, 45, false);
        Animal dog1 = new Dog("누리", 50, 15);
        
        Animal person3 = new Person("이민호", 25, 178f, 70, true);
        Animal dog2 = new Dog("덕자", 50, 10);
        
        Animal person4 = new Person("송혜교", 26, 173f, 64, false);
        Animal fish1 = new Fish("금", "빨간색");
        Animal fish2 = new Fish("붕", "주황색");
        
        // person1.Introduce();
        // cat1.Introduce();
        //
        // person2.Introduce();
        // dog1.Introduce();
        //
        // person3.Introduce();
        // dog2.Introduce();

        // 자료형[] 변수명 = new 자료형[크기] { 초기값 };
        // 클래스도 자료형이고 참조 타입이며 사용자 정의 자료형이라고 하기도 한다.
        Animal[] animals = new Animal[] {person1, cat1, person2, dog1, person3, dog2, person4, fish1, fish2};
        for (int i = 0; i < animals.Length; i++)
        {
            // 반복문을 이용하여 동물들을 순회하면서 Introduce 호출 가능
            animals[i].Introduce();
            
            // 동물이 사람 타입일 경우, 자기소개 후 땅바닥에 앉는다.
            if (animals[i] is Person) // is : 객체가 실제로 해당 타입인지 검사한 후 그 결과를 bool 반환
            {
                // 1. 명시적 형변환
                Person person = (Person)animals[i];
                person.SeatDown();
            }
                
            // 2. as 형변환 : 형변환을 시도해서 성공하면 성공 실패하면 null 반환
            Person personn = animals[i] as Person;
            if (personn != null) // null인지 아닌지로 사람인지 아닌지로 판단 가능
            {
                personn.SeatDown();
            }
        }
    }
}
