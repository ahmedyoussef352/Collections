namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List
             * List<string> names = [];
            //names.Add("Alice");
            //names.AddRange(["Bob", "Charlie", "David"]);
            //names.Insert(1, "Eve");
            //names.Remove("Charlie");
            //bool has = names.Contains("Alice");
            //Console.WriteLine(has);
            //int index = names.IndexOf("David");
            //Console.WriteLine(index);

            //names.Sort();
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}*/

            // Sorted List
            SortedList<string, int> marks = new()
            {
                ["Mohamed"] = 50,
                ["Ali"] = 80,
                ["Ahmed"] = 90
            };

            //foreach (var item in marks)
            //{
            //    Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            //}
            //Console.WriteLine(marks.Keys[0]);

            //if (marks.ContainsKey("Ali"))
            //{
            //    Console.WriteLine(marks["Ali"]);
            //}
            //marks.Add("Sarah", 85);

            //Dictionary<int, string> students = new()
            //{
            //    [101] = "Alice",
            //    [102] = "Bob",
            //    [103] = "Charlie"
            //};

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"key is {item.Key}," +
            //        $" value is {item.Value}");
            //}
            //students[103] = "David";
            //if (students.ContainsKey(104))
            //{

            //}
            //else
            //{
            //    students.Add(104, "Eve");

            //}
            /* HashSet
            //List<int> numbers = [1, 2, 3, 2, 1, 4];
            //numbers.Add(8);
            //numbers.ToHashSet().ToList().ForEach(Console.WriteLine);*/
            //Queue<int> queue = new();
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            //Console.WriteLine($"Peek: {queue.Peek()}");


            //Console.WriteLine("List of items in the queue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}




            //Stack<int> stack = new();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine(stack.Peek());
            //// Console.WriteLine(stack.Pop());
            //Console.WriteLine("stack");
            //foreach (var item in stack)
            //{

            //    Console.WriteLine(item);
            //}







            List<int> studentGrade = [85, 92, 78, 95, 88, 70, 100, 65];
            /*Q1
           
            Console.WriteLine("Student count: " + studentGrade.Count);
            //1print first grade
            Console.WriteLine("First grade: " + studentGrade[0]);
            Console.WriteLine("Last grade: " + studentGrade[studentGrade.Count - 1]);

             2
            // studentGrade.Sort();
            //Console.WriteLine("Sorted grades:");
            //foreach (var item in studentGrade)
            //{
            //    Console.WriteLine("Grade: " + item);
            //} 

            //3
            //Console.WriteLine(studentGrade.Find(grade => grade >= 90));/

            //4
            //Console.WriteLine(studentGrade.Find(grade => grade >= 90));//

            //5
            //studentGrade.FindAll(grade => grade < 75)
               .ForEach(grade => Console.WriteLine("Failing grade: " + grade));//

            //6
            //studentGrade.RemoveAll(grade => grade < 75);
            Console.WriteLine("Grades after removing those less than 75:");
            studentGrade.Sort();
            foreach (var item in studentGrade)
            {
                Console.WriteLine("Grade: " + item);
            }//

            //7
           // Console.WriteLine(studentGrade.Exists(grade => grade == 100));
            //8
            //List<string> strings = [];
            //studentGrade.Clear();
            //studentGrade[0] = strings[0];
            //
            //
            //
            //*/

            /* Q2
             * 
             * SortedList<string, int> playerScore = new()
            //{
            //    ["Ahmed"] = 50,
            //    ["Sara"] = 200,
            //    ["Ali"] = 800



            //};

            //playerScore.Add("Mona", 350);
            //playerScore.OrderBy(x => x.Value).ToList()
            //    .ForEach(x => Console.WriteLine($"Player: {x.Key}, Score: {x.Value}"));
            ////3
            //var topPlayer = playerScore.FirstOrDefault(x => x.Value == playerScore.Values.Max(), new KeyValuePair<string, int>("Not Found", 0));
            //Console.WriteLine($"Top Player: {topPlayer.Key}, Score: {topPlayer.Value}");
            ////4
            //bool Exist500 = playerScore.ContainsValue(500);
            //Console.WriteLine("Check if score 500 exists");

            ////5
            //var playerWithScore999 = playerScore.FirstOrDefault(x => x.Value == 999, new KeyValuePair<string, int>("Not Found", 0));
            //if (playerWithScore999.Key != "Not Found")
            //{
            //    Console.WriteLine($"Player with score 999 is {playerWithScore999}");
            //}
            //else
            //{
            //    Console.WriteLine("Player with score 999 not found");
            //}

            ////6
            //var traget = playerScore.FirstOrDefault(x => x.Value == 200);
            //Console.WriteLine(traget.Key);
            //if (traget.Key != null)
            //{
            //    playerScore.Remove(traget.Key);

            //}
            //Console.WriteLine("--- Updated Player List ---");
            //foreach (var entry in playerScore)
            //{
            //    Console.WriteLine($"Player: {entry.Key}, Score: {entry.Value}");
            //}*/

            /* Q3
            //SortedList<string, int> contacts = new()
            //{
            //    ["Mohamed"] = 1234567890,
            //    ["Ali"] = 25625522,
            //    ["Ahmed"] = 555555
            //};
            //2
            //contacts.Add("Ahmed", 555555);
            ////3
            //contacts.TryAdd<string, int>("Sarah", 285111);

            //foreach (var item in contacts)
            //{
            //    Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            //}
            //5
            // Console.WriteLine(contacts.ContainsKey("Omar"));

            //6 Get a contact with a fallback of "Not Found"

            //if (contacts.TryGetValue("Omar", out int value))
            //{
            //    Console.WriteLine($"Omar's contact is {value}");
            //}
            //else
            //{
            //    Console.WriteLine("Omar's contact is Not Found");
            //}

            //7 Print all Keys on one line, then all Values on another line
            //Console.Write("Keys: ");
            //foreach (var key in contacts.Keys)
            //{
            //    Console.Write(key + " ");
            //}
            //Console.WriteLine();

            //Console.Write("Values: ");
            //foreach (var value in contacts.Values)
            //{
            //    Console.Write(value + " ");
            //}
            //Console.WriteLine();*/

            /*Q5
            Queue<string> messageQueue = new();
            messageQueue.Enqueue("Report.pdf");
            messageQueue.Enqueue("Invoice.pdf");
            messageQueue.Enqueue("Letter.docx");
            messageQueue.Enqueue("Resume.pdf");
            messageQueue.Enqueue("Photo.jpg");

            Console.WriteLine(messageQueue.Count());
            Console.WriteLine(messageQueue.Peek());
            messageQueue.Dequeue();

            while (messageQueue.Count > 0)
            {
                string currentMessage = messageQueue.Dequeue();
                Console.WriteLine($"Printing:{currentMessage}");
            }

            // 5. تجربة TryDequeue على الـ Queue وهي فارغة
            Console.WriteLine("\n--- Testing TryDequeue on Empty Queue ---");
            bool success = messageQueue.TryDequeue(out string result);

            Console.WriteLine($"TryDequeue Success? {success}");
            Console.WriteLine($"Result Value: \"{result}\" (null)");*/

            /*Q6
            Stack<string> BrowserHistory
 = new();
            BrowserHistory.Push("google.com");

            BrowserHistory.Push("github.com");
            BrowserHistory.Push("stackoverflow.com");
            BrowserHistory.Push("youtube.com");
            BrowserHistory.Push("claude.ai");

            Console.WriteLine(BrowserHistory.Peek());

            for (int i = 0; i < 3; i++)
            {
                string left = BrowserHistory.Pop();
                Console.WriteLine(left);
            }


            Console.WriteLine(BrowserHistory.Peek());
            if (BrowserHistory.TryPop(out string result))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("--- Testing TryPop on Empty Stack ---");
            bool success = BrowserHistory.TryPop(out string page);

            Console.WriteLine($"TryPop Success? {success}");
            Console.WriteLine($"Result Value: \"{page}\" (null)");*/
        }

    }
}


