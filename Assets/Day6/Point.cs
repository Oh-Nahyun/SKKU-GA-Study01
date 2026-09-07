// 구조체(struct)
// 클래스 -> 객체를 만들고 추상화 하는데 목적이 있고,
// 구조체 -> 다양한 데이터를 담기 위한 자료 구조로 사용한다. (타입이 다른 여러 데이터들을 하나로 묶는다.)
// - 클래스와 유사한 구조를 가지고 있다.
// - 클래스처럼 변수와 메서드를 가질 수 있다.

// 좌표 구조체
public struct Point // 벡터라고 생각을 해보자...
{
    // 변수
    public int X;
    public int Y;

    // 생성자 메서드
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    // 정적 메서드 : 객체를 생성하지 않고도 클래스.메서드명으로 호출 가능
    public static Point Zero()
    {
        return new Point(1, 1);
    }
}