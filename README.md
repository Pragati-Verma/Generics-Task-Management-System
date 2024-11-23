# Generics-Task-Management-System

Step 1: Create the ITask Interface
Define a generic interface named ITask.
Add one method named Perform that returns a type T.
This interface will serve as the base for all tasks in your system, allowing you to define tasks that return different types of results depending on their specific implementation.


Step 2: Create the EmailTask Class
Implement the ITask<string> interface in a new class called EmailTask.
Include properties for Recipient and Message.
Implement the Perform method to simulate sending an email and return a confirmation message (simply return a string value that uses the Recipient and Message properties).


Step 3: Create the ReportTask Class
Implement the ITask<string> interface in a new class called ReportTask.
Include a property for ReportName.
Implement the Perform method to simulate generating a report and return a string status message.
These tasks represent specific operations in your system. Each class should handle a different type of task, demonstrating polymorphism and the flexibility of interfaces.


Step 4: Define the TaskProcessor Class
Create a generic class TaskProcessor with two type parameters: TTask and TResult.
Add a constraint to TTask to ensure it implements ITask<TResult>.
Include a constructor that accepts a parameter of type TTask.
Add a method Execute that calls the Perform method of the task and returns the result.
This class is responsible for executing any given task. The constraint ensures that only tasks implementing the correct interface can be processed, enforcing type safety and consistency.


Step 5: Write a Main Method to Use Your Classes
In your main program, create instances of EmailTask and ReportTask.
Instantiate TaskProcessor for each task type and execute them.
Output the results of each task to the console.

This part of the exercise helps you understand how to instantiate and work with generic classes and how to pass different types of tasks to a generic processor. It ties together all the concepts learned in the previous tasks.
