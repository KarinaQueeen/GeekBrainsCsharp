// Программа увеличивает первую из двух координат в 10 раз

string text = "(1,2) (2,3) (4,5) (6,7)"
             .Replace ("(", "")                                                  // убрать скобки
             .Replace (")", "")                                       
             ;
Console.WriteLine (text);

var data = text.Split(" ")                                                      // разделить элементы пробелом
               .Select (item => item.Split(','))                                // разделить элементы запятой
               .Select (e => (x: int.Parse (e[0]), y: int.Parse(e[1])))         // сделать выборку, где первое число будет координатой x, воторое y
               .Select (point => (point.x * 10, point.y))                       // увеличиваем у выведеных пар первую координату на 10
               .ToArray();                                                      // превратить в массив

for (int i = 0; i < data.Length; i++)
{
    Console.Write (data [i]);
}