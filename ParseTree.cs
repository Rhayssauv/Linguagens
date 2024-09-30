using System;
using System.Collections.Generic;

public class ShuntingYard
{
    // Definimos a precedência dos operadores
    private static readonly Dictionary<string, int> Precedence = new Dictionary<string, int>
    {
        { "+", 1 },
        { "-", 1 },
        { "*", 2 },
        { "/", 2 }
    };

    // Método para converter expressão infixada para notação polonesa reversa (RPN)
    public static Queue<string> ConvertToRPN(string expression)
    {
        var output = new Queue<string>();
        var operators = new Stack<string>();
        var tokens = Tokenize(expression); // Tokenizamos a entrada para lidar melhor com a expressão

        foreach (var token in tokens)
        {
            // Se o token for um número, colocamos na saída (fila)
            if (int.TryParse(token, out _))
            {
                output.Enqueue(token);
            }
            // Se o token for um parêntese esquerdo, empilhamos
            else if (token == "(")
            {
                operators.Push(token);
            }
            // Se o token for um parêntese direito, desempilhamos até encontrar o parêntese esquerdo
            else if (token == ")")
            {
                while (operators.Peek() != "(")
                {
                    output.Enqueue(operators.Pop());
                }
                operators.Pop(); // Remove o parêntese esquerdo da pilha
            }
            // Se o token for um operador
            else
            {
                // Enquanto houver operadores com maior ou igual precedência no topo da pilha, desempilha
                while (operators.Count > 0 && Precedence.ContainsKey(operators.Peek()) && Precedence[operators.Peek()] >= Precedence[token])
                {
                    output.Enqueue(operators.Pop());
                }
                operators.Push(token); // Empilha o operador atual
            }
        }

        // Após percorrer todos os tokens, esvaziamos a pilha de operadores
        while (operators.Count > 0)
        {
            output.Enqueue(operators.Pop());
        }

        return output; // Retorna a fila com a expressão em RPN
    }

    // Função para tokenizar a expressão
    private static List<string> Tokenize(string expression)
    {
        var tokens = new List<string>();
        var currentToken = "";

        foreach (char c in expression)
        {
            if (char.IsWhiteSpace(c))
            {
                continue; // Ignora espaços
            }

            if (char.IsDigit(c))
            {
                currentToken += c; // Acumula o número
            }
            else
            {
                if (!string.IsNullOrEmpty(currentToken))
                {
                    tokens.Add(currentToken); // Adiciona o número acumulado
                    currentToken = "";
                }

                tokens.Add(c.ToString()); // Adiciona o operador ou parêntese
            }
        }

        if (!string.IsNullOrEmpty(currentToken))
        {
            tokens.Add(currentToken); // Adiciona o último número, se houver
        }

        return tokens;
    }
}

public class RPNCalculator
{
    // Método para avaliar uma expressão em notação polonesa reversa (RPN)
    public static int EvaluateRPN(Queue<string> rpnQueue)
    {
        var stack = new Stack<int>();

        while (rpnQueue.Count > 0)
        {
            var token = rpnQueue.Dequeue();

            // Se for um número, empilha
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            // Se for um operador, realiza a operação entre os dois últimos números empilhados
            else
            {
                int right = stack.Pop();
                int left = stack.Pop();
                switch (token)
                {
                    case "+":
                        stack.Push(left + right);
                        break;
                    case "-":
                        stack.Push(left - right);
                        break;
                    case "*":
                        stack.Push(left * right);
                        break;
                    case "/":
                        stack.Push(left / right);
                        break;
                }
            }
        }

        return stack.Pop(); // Retorna o resultado final
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma expressão matemática:");
        string input = Console.ReadLine();  // Pega a expressão do usuário

        try
        {
            var rpnQueue = ShuntingYard.ConvertToRPN(input);  // Converte para RPN
            int result = RPNCalculator.EvaluateRPN(rpnQueue);  // Avalia a expressão RPN
            Console.WriteLine($"Resultado: {result}");  // Exibe o resultado
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na avaliação da expressão: {ex.Message}");
        }
    }
}
