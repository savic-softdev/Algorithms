//Implement the following operations of a stack using queues.

//push(x) -- Push element x onto stack.
//pop() -- Removes the element on top of the stack.
//top() -- Get the top element.
//empty() -- Return whether the stack is empty.

public class Stack {
		Queue<int> q1 = new Queue<int>();
		Queue<int> q2 = new Queue<int>();

		// Push element x onto stack.
		public void Push(int x)
		{
			q1.Enqueue(x);
		}

		// Removes the element on top of the stack.
		public void Pop()
		{
			if (q1.Count() == 0) return;

			while(q1.Count() > 1)
				q2.Enqueue(q1.Dequeue());

			q1.Dequeue();
			SwitchQueues();
		}

		// Get the top element.
		public int Top()
		{
			if (q1.Count() == 0) return 0;

			while (q1.Count() > 1)
				q2.Enqueue(q1.Dequeue());

			int ret = q1.Dequeue();
			q2.Enqueue(ret);
			SwitchQueues();
			return ret;
		}

		// Return whether the stack is empty.
		public bool Empty()
		{
			return q1.Count() == 0;
		}

		private void SwitchQueues()
		{
			var temp = q1;
			q1 = q2;
			q2 = temp;
		}
}