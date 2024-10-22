//part 1:palindrome checker

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Input a string:");
//        string input = Console.ReadLine();

//        if (IsPalindrome(input))
//        {
//            Console.WriteLine(true);
//        }
//        else
//        {
//            Console.WriteLine(false);
//        }
//    }

//    static bool IsPalindrome(string str)
//    {
//        str = str.Replace(" ", "").ToLower();

//        int start = 0;
//        int end = str.Length - 1;

//        while (start < end)
//        {
//            if (str[start] != str[end])
//            {
//                return false;
//            }
//            start++;
//            end--;
//        }

//        return true;
//    }
//}

//part 2: a)LongestCommonConsecutiveSubsequence

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the first string: ");
//        string str1 = Console.ReadLine();


//        Console.Write("Enter the second string: ");
//        string str2 = Console.ReadLine();

//        int lcsLength = LongestCommonConsecutiveSubsequence(str1, str2);
//        Console.WriteLine($"Length of the LCS : {lcsLength}");
//    }

//    static int LongestCommonConsecutiveSubsequence(string s1, string s2)
//    {
//        int m = s1.Length;
//        int n = s2.Length;

//        int[,] dp = new int[m + 1, n + 1];
//        int maxLength = 0;
//        for (int i = 1; i <= m; i++)
//        {
//            for (int j = 1; j <= n; j++)
//            {
//                if (s1[i - 1] == s2[j - 1])
//                {
//                    dp[i, j] = dp[i - 1, j - 1] + 1;
//                    maxLength = Math.Max(maxLength, dp[i, j]);
//                }
//                else
//                {
//                    dp[i, j] = 0;
//                }
//            }
//        }

//        return maxLength;
//    }
//}

//part 2: b) shell sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 23, 2, 1, 73, 34, 54, 2, 3,48 };

//        Console.WriteLine("Original:");
//        PrintArray(arr);

//        ShellSort(arr);

//        Console.WriteLine("\nSorted:");
//        PrintArray(arr);
//    }

//    static void ShellSort(int[] arr)
//    {
//        int n = arr.Length;

//        for (int gap = n / 2; gap > 0; gap /= 2)
//        {
//            for (int i = gap; i < n; i++)
//            {
//                int temp = arr[i];
//                int j;

//                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
//                {
//                    arr[j] = arr[j - gap];
//                }

//                arr[j] = temp;
//            }
//        }
//    }

//    static void PrintArray(int[] arr)
//    {
//        foreach (int item in arr)
//        {
//            Console.Write(item + ",");
//        }
//        Console.WriteLine();
//    }
//}

//part 3 custom linked list


//using System;

//class CustomLinkedList
//{
//    private class Node
//    {
//        public int Value;
//        public Node Next;

//        public Node(int value)
//        {
//            Value = value;
//            Next = null;
//        }
//    }

//    private Node head;
//    private int count;

//    public CustomLinkedList()
//    {
//        head = null;
//        count = 0;
//    }

//    public void Add(int value)
//    {
//        Node newNode = new Node(value);
//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.Next != null)
//            {
//                current = current.Next;
//            }
//            current.Next = newNode;
//        }
//        count++;
//    }

//    public bool Remove(int value)
//    {
//        if (head == null) return false;

//        if (head.Value == value)
//        {
//            head = head.Next;
//            count--;
//            return true;
//        }

//        Node current = head;
//        while (current.Next != null)
//        {
//            if (current.Next.Value == value)
//            {
//                current.Next = current.Next.Next;
//                count--;
//                return true;
//            }
//            current = current.Next;
//        }
//        return false;
//    }

//    public int Count => count;

//    public void Clear()
//    {
//        head = null;
//        count = 0;
//    }

//    public void Display()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.Value + " ");
//            current = current.Next;
//        }
//        Console.WriteLine();
//    }


//}

//class Program
//{
//    static void Main()
//    {
//        CustomLinkedList list = new CustomLinkedList();
//        list.Add(10);
//        list.Add(20);
//        list.Add(30);

//        list.Display(); //10 20 30

//        list.Remove(10);
//        Console.WriteLine("Count: " + list.Count); //2
//        list.Display(); // 20 30
//        list.Clear();

//        Console.WriteLine("Count: " + list.Count); //0
//    }
//}


