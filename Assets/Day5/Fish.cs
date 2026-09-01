using UnityEngine;

public class Fish : Animal
{
    private string _color;
    
    public Fish(string name, string color)
    {
        _name = name;
        _height = 2;
        _weight = 0.3;
        _color = color;
    }

    public override void Introduce()
    {
        Debug.Log($"뻐끔뻐끔- 내 이름은 {_name}이고, 내 비늘 색깔은 {_color}이야. 뻐끔뻐끔-");
    }
}