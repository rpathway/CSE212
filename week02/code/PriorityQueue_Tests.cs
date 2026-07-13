using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add one item to the queue and remove it
    // Expected Result: The same item should be returned
    // Defect(s) Found: Dequeue failed because the item was not removed correctly
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Apple", result);
    }

    [TestMethod]
    // Scenario: Add multiple items with different priorities
    // Expected Result: Items should be removed from highest priority to lowest priority
    // Defect(s) Found: Dequeue failed because it didn't always select the highest priority item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 10);
        priorityQueue.Enqueue("Medium", 5);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority
    // Expected Result: Items should be removed in FIFO
    // Defect(s) Found: Equal priorities were not handled correctly
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Remove an item from an empty queue
    // Expected Result: Exception should be thrown
    // Defect(s) Found: None found
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );
    }
}