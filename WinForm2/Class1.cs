using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm2
{
    public class TimeLog
    {
        public string AlgorithmName { get; set; }
        public double ExecutionTimeMs { get; set; }
        public string DataId { get; set; }
        public int Count = 0;
        public DateTime LogTime { get; set; }

        public TimeLog(string name, double time, string dataid,int count=0)
        {
            AlgorithmName = name;
            ExecutionTimeMs = time;
            DataId = dataid;
            LogTime = DateTime.Now;
            Count = count;
        }

        public override string ToString()
        {
            return $"{AlgorithmName} ({DataId} items): {ExecutionTimeMs:F4} ms";
        }
    }
    public class TimeLogNode
    {
        public TimeLog Data;
        public TimeLogNode Next;
        public TimeLogNode(TimeLog data) { Data = data; Next = null; }
    }

    public class TimeLogList
    {
        public TimeLogNode Head, Tail;
        int lastNumber = 0;
        public string GenerateDataId()
        {
            lastNumber++;
            return $"H{lastNumber:0000}";
        }
        public void AddLog(TimeLog log) 
        { 
            TimeLogNode newNode = new TimeLogNode(log);
            if (Head == null) 
                Head = Tail = newNode;
            else 
            { Tail.Next = newNode;
              Tail = newNode; 
            }
        }
        public TimeLogList GroupByAlgorithm()
        {
            TimeLogList result = new TimeLogList();

            TimeLogNode cur = Head;
            while (cur != null)
            {
                TimeLog log = cur.Data;
                TimeLogNode r = result.Head;
                bool found = false;

                while (r != null)
                {
                    if (r.Data.AlgorithmName == log.AlgorithmName)
                    {
                        r.Data.ExecutionTimeMs += log.ExecutionTimeMs;
                        r.Data.DataId = log.DataId;
                        r.Data.LogTime = DateTime.Now;
                        r.Data.Count++;
                        found = true;
                        break;
                    }
                    r = r.Next;
                }
                if (!found)
                {
                    result.AddLog(new TimeLog(
                        log.AlgorithmName,
                        log.ExecutionTimeMs,
                        log.DataId,
                        log.Count++
                    ));
                }

                cur = cur.Next;
            }

            return result;
        }
        public List<TimeLog> ToList()
        {
            List<TimeLog> list = new List<TimeLog>();
            TimeLogNode cur = Head;
            while (cur != null)
            {
                list.Add(cur.Data);
                cur = cur.Next;
            }
            return list;
        }
    }
}
