// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System;
using System.Runtime.InteropServices;
using TestingConcepts;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

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
        d.StackMethods();
        #endregion
        #region Uses and Calling of LinkedList
        #endregion
        #endregion



        #endregion
    }
}