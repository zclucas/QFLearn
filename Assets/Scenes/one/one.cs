using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
public class one : MonoBehaviour
{
    // Start is called before the first frame update
    public TodoList Model = new TodoList();
    void Start()
    {
        this.Identity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class TodoList
	{
        public List<TodoItem> mTodoItems;
	}
    public class TodoItem
	{
        public bool Completed;
        public string Content;
	}
}
