//Alteração realizada por Felipe Maia Lopes Sinoti
//Outra alteração realizada por Felipe Maia Lopes Sinoti”

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var i = 3;           // i é implicitamente do tipo int
var s = "sausage";   // s é implicitamente do tipo string

var rectMatrix = new int[,]    // rectMatrix é implicitamente do tipo int[,]
{
  {0,1,2},
  {3,4,5},
  {6,7,8}
};

var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };   // Compilador infere o tipo char[]
var x = new[] { 1, 10000000000 };           // Legal - todos os elementos são convertidos para o tipo long

Console.WriteLine("MATRIX: " + rectMatrix); //Feito por Gustavo Feliciano