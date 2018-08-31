namespace SimpleLists
{
     public class QueueNode
    {
        public string Data { get; set; }
        public QueueNode Next { get; set; }
        public QueueNode(string data)
        {
            Data = data;
        }
    }
}
