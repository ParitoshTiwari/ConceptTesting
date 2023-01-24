// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System;
using System.Runtime.InteropServices;
using TestingConcepts;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;
using System.Linq;

public class Program
{
    public static void Main()
    {
        LinearDataStructures d = new LinearDataStructures();
        #region Linear Data Structure

        #region Static Linear Data Structure - Array
        /// The arrays can be used in various places where we need to store the data of similar data type
        d.ArrayMethods();
        #endregion

        #region Dynamic Linear Data Structure
        #region Uses and Calling of Queue
        /// To Test Queue
        /// FCFS ( first come first serve) scheduling, example: FIFO queue
        /// Spooling in printers
        /// Buffer for devices like keyboard
        /// CPU Scheduling
        /// Memory management
        /// Queues in routers/ switches 
        /// Mail Queues
        /// Variations: (Deque, Priority Queue, Doubly Ended Priority Queue )
        /// Applied as waiting lists for a single shared resource like CPU, Disk, and Printer.
        /// Applied as buffers on MP3 players and portable CD players.
        /// Applied on Operating system to handle the interruption.
        /// Applied to add song at the end or to play from the front.
        /// Applied on WhatsApp when we send messages to our friends and they don’t have an internet connection then these messages are queued on the server of WhatsApp.
        /// Traffic software(Each  light get on one by one after every time of interval of time.)
        d.QueueMethods();
        #endregion
        #region Uses and Calling of Stack
        /// CD / DVD stand.
        /// Stack of books in a book shop.
        /// Undo and Redo mechanism in text editors.
        /// The history of a web browser is stored in the form of a stack.
        /// Call logs, E-mails, and Google photos in any gallery are also stored in form of a stack.
        /// YouTube downloads and Notifications are also shown in LIFO format(the latest appears first).
        /// Stack helps in managing data that follows the LIFO technique.
        /// Stacks are be used for systematic Memory Management.
        /// It is used in many virtual machines like JVM. When a function is called, the local variables and other function parameters are stored in the stack and automatically destroyed once returned from the function. Hence, efficient function management.
        /// Stacks are more secure and reliable as they do not get corrupted easily.
        /// Stack allows control over memory allocation and deallocation.
        /// Stack cleans up the objects automatically.
        d.StackMethods();
        #endregion
        #region Uses and Calling of LinkedList
        /// Dynamic data structure: A linked list is a dynamic arrangement so it can grow and shrink at runtime by allocating and deallocating memory. So there is no need to give the initial size of the linked list.
        /// No memory wastage: In the Linked list, efficient memory utilization can be achieved since the size of the linked list increase or decrease at run time so there is no memory wastage and there is no need to pre-allocate the memory.
        /// Implementation: Linear data structures like stacks and queues are often easily implemented using a linked list.
        /// Insertion and Deletion Operations: Insertion and deletion operations are quite easier in the linked list.There is no need to shift elements after the insertion or deletion of an element only the address present in the next pointer needs to be updated.
        d.LinkedListMethods();

        #endregion
        #endregion



        #endregion

        #region Non-Linear Data Structure

        #endregion

        #region Input for leetCode
        int[][] a = new int[][] { new int[] { 7, 3 }, new int[] { 1, 3 }, new int[] { 5, 6 }, new int[] { 2, 1 }, new int[] { 1, 6 }, new int[] { 3, 7 },
            new int[] { 7, 2 }, new int[] { 1, 2 }, new int[] { 7, 6 }, new int[] { 6, 3 }, new int[] { 3, 6 }, new int[] { 5, 7 }, new int[] { 5, 3 },
            new int[] { 6, 4 }, new int[] { 5, 4 }, new int[] { 2, 6 }, new int[] { 7, 1 }, new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 6, 5 },
            new int[] { 3, 5 }, new int[] { 3, 4 }, new int[] { 3, 1 }, new int[] { 7, 4 }, new int[] { 5, 2 }, new int[] { 2, 4 } };
        Console.WriteLine(FindJudge(7, a)); 
        #endregion
    }

    public int Test { get; set; }

    #region TestCodeForLeetCode
    public static int FindJudge(int n, int[][] trust)
    {
        int j = 0;
        int count = 0;

        var elements = trust.ToList();
        List<int> oneList = new List<int>();
        foreach (var item in elements)
        {
            oneList.Add(item[0]);
            oneList.Add(item[1]);
        }

        var unique = oneList.Distinct().ToList();

        for (int i = 0; i < elements.Count; i++)
        {
            j = trust[i][1];
            count = 0;
            for (int k = 0; k < trust.Length; k++)
            {
                if (j == trust[k][0])
                {
                    count++;
                }
            }
            if (count == 0)
            {

                var removal = elements.Where(item => item.Contains(j)).ToList();
                List<int> ints = new List<int>();
                foreach (var item in removal)
                {
                    ints.Add(item[0]);
                    ints.Add(item[1]);
                }

                var dist = ints.Distinct().ToList();
                bool isEqual = unique.OrderBy(x => x).SequenceEqual(dist.OrderBy(x => x));
                if (isEqual)
                {
                    return j;
                }
                else
                {
                    return -1;
                }
            }
        }

        return -1;
    } 
    #endregion
}