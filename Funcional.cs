List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
var quadrados = numeros.Select(x => x * x);
foreach (var num in quadrados) {
    Console.WriteLine(num);  // 1, 4, 9, 16, 25
}
