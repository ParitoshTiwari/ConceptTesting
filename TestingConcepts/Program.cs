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

        d.LinkedListMethods();

        #endregion
        #endregion



        #endregion
    }
}