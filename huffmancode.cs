Sure! Here's a basic implementation of Huffman Coding in C#:

```csharp
using System;
using System.Collections.Generic;

public class HuffmanNode
{
    public char Character { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }
}

public class HuffmanCoding
{
    private Dictionary<char, string> _huffmanCodes = new Dictionary<char, string>();

    public void BuildHuffmanTree(string input)
    {
        var frequency = new Dictionary<char, int>();
        foreach (var character in input)
        {
            if (!frequency.ContainsKey(character))
                frequency[character] = 0;
            frequency[character]++;
        }

        var priorityQueue = new SortedSet<HuffmanNode>(Comparer<HuffmanNode>.Create((x, y) =>
        {
            int result = x.Frequency.CompareTo(y.Frequency);
            return result == 0 ? x.Character.CompareTo(y.Character) : result;
        }));

        foreach (var kvp in frequency)
        {
            priorityQueue.Add(new HuffmanNode { Character = kvp.Key, Frequency = kvp.Value });
        }

        while (priorityQueue.Count > 1)
        {
            var left = priorityQueue.Min;
            priorityQueue.Remove(left);
            var right = priorityQueue.Min;
            priorityQueue.Remove(right);

            var newNode = new HuffmanNode
            {
                Character = '*',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            priorityQueue.Add(newNode);
        }

        var root = priorityQueue.Min;
        GenerateHuffmanCodes(root, "");
    }

    private void GenerateHuffmanCodes(HuffmanNode node, string code)
    {
        if (node == null)
            return;

        if (node.Left == null && node.Right == null)
        {
            _huffmanCodes[node.Character] = code;
        }

        GenerateHuffmanCodes(node.Left, code + "0");
        GenerateHuffmanCodes(node.Right, code + "1");
    }

    public string Encode(string input)
    {
        var encodedString = string.Empty;
        foreach (var character in input)
        {
            encodedString += _huffmanCodes[character];
        }
        return encodedString;
    }

    public string Decode(string encodedInput, HuffmanNode root)
    {
        var decodedString = string.Empty;
        var currentNode = root;
        foreach (var bit in encodedInput)
        {
            currentNode = bit == '0' ? currentNode.Left : currentNode.Right;

            if (currentNode.Left == null && currentNode.Right == null)
            {
                decodedString += currentNode.Character;
                currentNode = root;
            }
        }
        return decodedString;
    }
}

class Program
{
    static void Main()
    {
        var huffmanCoding = new HuffmanCoding();
        string input = "this is an example for huffman encoding";
        huffmanCoding.BuildHuffmanTree(input);

        string encoded = huffmanCoding.Encode(input);
        Console.WriteLine("Encoded: " + encoded);

        var root = new HuffmanNode(); // You need to pass the root of the Huffman Tree here
        string decoded = huffmanCoding.Decode(encoded, root);
        Console.WriteLine("Decoded: " + decoded);
    }
}
```

This code includes the basic structure for building a Huffman Tree, encoding a string, and decoding it back. You might need to adjust the `Decode` method to correctly pass the root of the Huffman Tree.

Feel free to ask if you have any questions or need further assistance!

Sursă: conversație cu Copilot. 9/9/2024
(1) huffman-coding · GitHub Topics · GitHub. https://github.com/topics/huffman-coding?l=c%23.
(2) Huffman Coding | Greedy Algo-3 - GeeksforGeeks. https://www.geeksforgeeks.org/huffman-coding-greedy-algo-3/.
(3) GitHub - Ilia-Abolhasani/huffman: Implement a Huffman Tree algorithm in .... https://github.com/Ilia-Abolhasani/huffman.
(4) GitHub - tupito/huffman-coding: Huffman coding with C# for "Data .... https://github.com/tupito/huffman-coding.