namespace Exercises
{
    public class ListNode
    {
        public string Data;
        public ListNode Next;

        public ListNode(string data, ListNode next) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class LinkedList {
        public ListNode Head;

        public LinkedList() {
            Head = null;
        }

        public void AddToEnd(string newData) {
            ListNode newNode = new ListNode(newData, null);
            
            if (Head == null) {
                Head = newNode;
                return;
            } 
            
            ListNode current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

                current.Next = newNode;
        }
        
        public ListNode GetNodeAt(int index) {
            int count = 0;

            if (index < 0) {
                return null;
            }
            
            ListNode current = Head;
            while (count < index) {
                if (current.Next != null) {
                    current = current.Next;
                } else {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find(string searchTerm) {
            ListNode current = Head;

            while (current != null) {
                if (current.Data == searchTerm) {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the number of nodes in the Linked List
        /// </summary>
        /// <returns>int: count</returns>
        public int Count() {
            return -1;
        }

        /// <summary>
        /// Adds a node to the start of the list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>success: true</returns>
        public bool AddToStart(string data) {
            return false;
        }

        /// <summary>
        /// add new node at index.  If index specified is greater than the size of the current list,
        /// adds nodes with null data in between.  Negative index will return false.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool AddNodeAt(string data, int index) {
            return false;
        }

        /// <summary>
        /// Delete node at index.  return false if node does not exist
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteNodeAt(int index) {
            return false;
        }
    }
}