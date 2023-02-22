using System.Collections;

namespace Assignment1;

public class TodoCls
{
    private List<string> myList;

    public TodoCls()
    {
        this.myList = new List<string>();
    }

    public void ModifyList()
    {
        while (true)
        {
            WriteLine("Enter command (+ item, - item, -- to clear, or --- to break)):");
            WriteLine("Current List: " + string.Join(", ", this.myList));

            string? tmp = ReadLine();
            string[] task = tmp.Split(' ', 2);
            // WriteLine($"{task[0]} : {task[1]}");

            if (task[0].Equals("+"))
            {
                this.myList.Add(task[1]);
            }
            else if (task[0].Equals("-"))
            {
                this.myList.Remove(task[1]);
            }
            else if (task[0].Equals("--"))
            {
                this.myList.Clear();
            }
            else if (task[0].Equals("---"))
            {
                break;
            }
            else
            {
                WriteLine("please enter a valid command.");
            }
        }
    }
}