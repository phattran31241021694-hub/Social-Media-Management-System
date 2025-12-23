using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm2;

namespace WinForm2
{
    public class Post
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string PostId { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }
        public int Scores { get; set; }
        public Post(string id, string content, string postid, DateTime datetime, int likes = 0, int scores = 0)
        {
            Id = id;
            Content = content;
            PostId = postid;
            Date = datetime;
            Likes = likes;
            Scores = scores;
        }
        public Post Clone()
        {
            return new Post(Id, Content, PostId, Date, Likes, Scores);
        }
        public override string ToString()
        {
            return $"{Id}|{PostId}|{Date:dd--MM--yyyy}|{Likes}likes|{Content}";
        }
    }
    public class Node
    {
        public Post Data;
        public Node Next;
        public Node(Post p)
        {
            Data = p;
            Next = null;
        }
    }
    public class SingleLinkedList
    {
        public Node Head;
        public Node Tail;
        private int lastPostNumber = 0;
        public SingleLinkedList() { Head = Tail = null; }
        private bool IsEmpty() { return Head == null; }
        public void AddLast(Post p)
        {
            Node node = new Node(p);
            if (IsEmpty()) { Head = Tail = node; }
            else 
            { 
                Tail.Next = node;
                Tail = node; 
            }
        }
        public SingleLinkedList Clone()
        {
            SingleLinkedList clone = new SingleLinkedList();
            Node cur = Head;
            while (cur != null) { clone.AddLast(cur.Data.Clone()); cur = cur.Next; }
            return clone;
        }
        public int Count()
        {
            int n = 0;
            Node cur = Head;
            while (cur != null) { n++; cur = cur.Next; }
            return n;
        }
        public SingleLinkedList FindID(string id)
        {
            SingleLinkedList result = new SingleLinkedList();
            Node cur = Head;
            while (cur != null)
            {
                if (string.Equals(cur.Data.Id, id, StringComparison.OrdinalIgnoreCase))
                    result.AddLast(cur.Data.Clone());
                cur = cur.Next;
            }
            return result;
        }
        public void LastPostNumber()
        {
            Node cur = Head;
            while (cur != null)
            {
                if (!string.IsNullOrEmpty(cur.Data.PostId) )
                {
                    string numPart = cur.Data.PostId;
                    if (int.TryParse(numPart, out int n))
                    {
                        if (n > lastPostNumber)
                            lastPostNumber = n;
                    }
                }
                cur = cur.Next;
            }
        }
        public string GeneratePostId()
        {
            lastPostNumber++;
            return $"{lastPostNumber:00000}";
        }
        public Node FindPostId(string postid)
        {
            Node cur = Head;
            while (cur != null&& !string.Equals(cur.Data.PostId, postid, StringComparison.OrdinalIgnoreCase))
            {
                cur = cur.Next;
            }
            return cur;
        }
        public bool RemoveByPostId(string postid)
        {
            if (IsEmpty()) return false;
            if (Head.Data.PostId == postid)
            {
                Head = Head.Next;
                if (Head == null)
                    Tail = null;
                return true;
            }
            Node prev = Head;
            Node cur = Head.Next;
            while (cur != null)
            {
                if (cur.Data.PostId == postid)
                {
                    prev.Next = cur.Next;
                    if (cur == Tail)
                        Tail = prev;
                    return true;
                }
                prev = cur;
                cur = cur.Next;
            }
            return false;
        }
        public SingleLinkedList FilterByDateTimeRange(DateTime fromDate, DateTime toDate)
        {
            SingleLinkedList result = new SingleLinkedList();
            Node cur = Head;
            fromDate = fromDate.Date;
            toDate = toDate.Date;
            while (cur != null)
            {
                DateTime d = cur.Data.Date.Date;
                if (d >= fromDate && d <= toDate)
                    result.AddLast(cur.Data.Clone());
                cur = cur.Next;
            }
            return result;
        }
        private int CountMatch(string content, string keyword)
        {
            int count = 0;
            int index = 0;
            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(keyword)) return 0;
            while ((index = content.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += keyword.Length;
            }
            return count;
        }
        public SingleLinkedList FilterByKeyWordSort(string keyword)
        {
            SingleLinkedList result = new SingleLinkedList();
            Node cur = Head;
            while (cur != null)
            {
                if (cur.Data.Content != null)
                {
                    int score = CountMatch(cur.Data.Content, keyword);
                    if (score > 0)
                    {
                        Post clonePost = cur.Data.Clone();
                        clonePost.Scores = score;
                        result.AddLast(clonePost);
                    }

                }
                cur = cur.Next;
            }
            result.SortScores();
            return result;
        }
        private Node GetMiddle(Node head)
        {
            if (head == null) return null;
            Node slow = head;
            Node fast = head.Next;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            return slow;
        }
        private Node MergeSortInternal(Node head, Comparison<Post> cmp)
        {
            if (head == null || head.Next == null)
                return head;
            Node middle = GetMiddle(head);
            Node rightHead = middle.Next;
            middle.Next = null;
            Node left = MergeSortInternal(head, cmp);
            Node right = MergeSortInternal(rightHead, cmp);
            return Merge(left, right, cmp);
        }
        private Node Merge(Node a, Node b, Comparison<Post> cmp)
        {
            if (a == null) return b;
            if (b == null) return a;
            Node result;
            if (cmp(a.Data, b.Data) <= 0)
            {
                result = a;
                result.Next = Merge(a.Next, b, cmp);
            }
            else
            {
                result = b;
                result.Next = Merge(a, b.Next, cmp);
            }
            return result;
        }
        public void MergeSort(Comparison<Post> cmp)
        {
            if (Head == null || Head.Next == null)
                return;
            this.Head = MergeSortInternal(this.Head, cmp);
            Node cur = Head;
            Tail = cur;
            while (cur != null && cur.Next != null)
            {
                cur = cur.Next;
                Tail = cur;
            }
        }
        public SingleLinkedList SortDate()
        {
            SingleLinkedList Sort = this.Clone();
            Sort.MergeSort((a, b) => b.Date.CompareTo(a.Date));
            return Sort;
        }
        public SingleLinkedList SortLike()
        {
            SingleLinkedList Sort = this.Clone();
            Sort.MergeSort((a, b) => b.Likes.CompareTo(a.Likes));
            return Sort;
        }
        public void SortScores()
        {
            MergeSort((a, b) => b.Scores.CompareTo(a.Scores));
        }
        public StatsList MonthStatistic(int year)
        {
            StatsList stats = new StatsList();

            // Tạo sẵn 12 tháng
            for (int m = 1; m <= 12; m++)
                stats.AddLast(new DateStats(m, year));

            Node cur = Head;
            while (cur != null)
            {
                if (cur.Data.Date.Year == year)
                {
                    int month = cur.Data.Date.Month;
                    DateStats ds = stats.Find(month, year);
                    ds.PostCount++;
                    ds.PostLikes += cur.Data.Likes;
                }
                cur = cur.Next;
            }
            return stats;
        }
        public List<Post> ToList()
        {
            List<Post> list = new List<Post>();
            Node cur = Head;
            while (cur != null)
            {
                list.Add(cur.Data);
                cur = cur.Next;
            }
            return list;
        }
    }
    public class DateStats
    {
        public int Year;
        public int Month;
        public int PostCount;
        public int PostLikes;
        public DateStats(int month,int year)
        {
            Year = year;
            Month = month;
            PostCount = 0;
            PostLikes = 0;
        }
        public override string ToString()
        {
            return $"{Month}/{Year} - Posts: {PostCount}, Likes: {PostLikes}";
        }
    }
    public class StatsNode
    {
        public DateStats Data;
        public StatsNode Next;
        public StatsNode(DateStats d)
        {
            Data = d;
            Next = null;
        }
    }
    public class StatsList
    {
        public StatsNode Head, Tail;
        public void AddLast(DateStats d)
        {
            StatsNode n = new StatsNode(d);
            if (Head == null) Head = Tail = n;
            else
            {
                Tail.Next = n;
                Tail = n;
            }
        }
        public DateStats Find(int month,int year)
        {
            StatsNode cur = Head;
            while (cur != null)
            {
                if (cur.Data.Year == year && cur.Data.Month == month)
                    return cur.Data;
                cur = cur.Next;
            }
            return null;
        }
    }
    public static class SamplePostGenerator
    {
        private static readonly string[] Authors =
        {
            "My", "Thư", "Phi", "Dung", "Phát", "Linh", "Minh"
        };

        private static readonly string[] Topics =
        {
            "C# WinForms",
            "Data Structure",
            "Single Linked List",
            "SQL Server",
            "OOP in C#",
            "Chart Visualization",
            "Algorithm"
        };

        private static readonly string[] Contents =
        {
            "Học code ",
            "Tìm hiểu ",
            "Thực hành ",
            "Ứng dụng ",
            "Tối ưu hóa "
        };

        public static SingleLinkedList Generate(int year)
        {
            SingleLinkedList list = new SingleLinkedList();
            Random rnd = new Random();

            int postCounter = 1;

            for (int month = 1; month <= 12; month++)
            {
                int postsInMonth = rnd.Next(10, 900); // 10-100 bài / tháng

                for (int i = 0; i < postsInMonth; i++)
                {
                    string author = Authors[rnd.Next(Authors.Length)];
                    string topic = Topics[rnd.Next(Topics.Length)];
                    string content = Contents[rnd.Next(Contents.Length)] + topic;
                    int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                    DateTime date = new DateTime(year, month, day);

                    int likes = rnd.Next(0, 500);

                    Post p = new Post(author,content+topic,list.GeneratePostId(),date,likes);

                    list.AddLast(p);
                }
            }

            return list;
        }
    }
}
namespace WinForm2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
