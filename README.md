# Object Oriented Projects

 # The Characteristics of OOP
In this section you are going to look at the some fundamental concepts and terms common to all OOP
languages. Don't worry about how these concepts get implemented in any particular programming
language; that will come later. My goal is to merely familiarize you with the concepts and relate them to
your everyday experiences in such a way that they make more sense later when you look at OOP design
and implementation.
# Objects
As I noted earlier, we live in an object-oriented world. You are an object. You interact with other objects.
In fact, you are an object with data such as height and hair color. You also have methods that you
perform or are performed on you, such as eating and walking.
So what are objects? In OOP terms, an object is a structure for incorporating data and the
procedures for working with that data. For example, if you were interested in tracking data associated
with products in inventory, you would create a product object that is responsible for maintaining and
working with the data pertaining to the products. If you wanted to have printing capabilities in your
application, you would work with a printer object that is responsible for the data and methods used to
interact with your printers.
# Abstraction
When you interact with objects in the world, you are often only concerned with a subset of their
properties. Without this ability to abstract or filter out the extraneous properties of objects, you would
find it hard to process the plethora of information bombarding you and concentrate on the task at hand.
As a result of abstraction, when two different people interact with the same object, they often deal
with a different subset of attributes. When I drive my car, for example, I need to know the speed of the
car and the direction it is going. Because the car is an automatic, I do not need to know the RPMs of the 
engine, so I filter this information out. On the other hand, this information would be critical to a racecar
driver, who would not filter it out.
When constructing objects in OOP applications, it is important to incorporate this concept of
abstraction. If you were building a shipping application, you would construct a product object with
attributes such as size and weight. The color of the item would be extraneous information and filtered
out. On the other hand, when constructing an order-entry application, the color could be important and
would be included as an attribute of the product object.
# Encapsulation
Another important feature of OOP is encapsulation. Encapsulation is the process in which no direct
access is granted to the data; instead, it is hidden. If you want to gain access to the data, you have to
interact with the object responsible for the data. In the previous inventory example, if you wanted to
view or update information on the products, you would have to work through the product object. To
read the data, you would send the product object a message. The product object would then read the
value and send back a message telling you what the value is. The product object defines what operations
can be performed on the product data. If you send a message to modify the data and the product object
determines it is a valid request, it will perform the operation for you and send a message back with the
result.You experience encapsulation in your daily life all the time. Think about a human resources
department. They encapsulate (hide) the information about employees. They determine how this data
can be used and manipulated. Any request for the employee data or request to update the data has to be
routed through them. Another example is network security. Any request for the security information or a
change to a security policy must be made through a network security administrator. The security data is
encapsulated from the users of the network.
By encapsulating data you make the data of your system more secure and reliable. You know how
the data is being accessed and what operations are being performed on the data. This makes program
maintenance much easier and also greatly simplifies the debugging process. You can also modify the
methods used to work on the data, and if you do not alter how the method is requested and the type of
response sent back, then you do not have to alter the other objects using the method. Think about when
you send a letter in the mail. You make a request to the post office to deliver the letter. How the post
office accomplishes this is not exposed to you. If it changes the route it uses to mail the letter, it does not
affect how you initiate the sending of the letter. You do not have to know the post office’s internal
procedures used to deliver the letter.
# Polymorphism
Polymorphism is the ability of two different objects to respond to the same request message in their own
unique way. For example, I could train my dog to respond to the command bark and my bird to respond
to the command chirp. On the other hand, I could train them to both respond to the command speak.
Through polymorphism I know that the dog will respond with a bark and the bird will respond with a
chirp.
How does this relate to OOP? You can create objects that respond to the same message in their own
unique implementations. For example, you could send a print message to a printer object that would
print the text on a printer, and you could send the same message to a screen object that would print the
text to a window on your computer screen.
Another good example of polymorphism is the use of words in the English language. Words have
many different meanings, but through the context of the sentence you can deduce which meaning is
intended. You know that someone who says “Give me a break!” is not asking you to break his leg! 
In OOP you implement this type of polymorphism through a process called overloading. You can
implement different methods of an object that have the same name. The object can then tell which
method to implement depending on the context (in other words, the number and type of arguments
passed) of the message. For example, you could create two methods of an inventory object to look up the
price of a product. Both these methods would be named getPrice. Another object could call this method
and either pass the name of the product or the product ID. The inventory object could tell which
getPrice method to run by whether a string value or an integer value was passed with the request.
# Inheritance
Most objects are classified according to hierarchies. For example, you can classify all dogs together as
having certain common characteristics such as having four legs and fur. Their breeds further classify
them into subgroups with common attributes such as size and demeanor. You also classify objects
according to their function. For example, there are commercial vehicles and recreational vehicles. There
are trucks and passenger cars. You classify cars according to their make and model. To make sense of the
world, you need to use object hierarchies and classifications.
You use inheritance in OOP to classify the objects in your programs according to common
characteristics and function. This makes working with the objects easier and more intuitive. It also
makes programming easier because it enables you to combine general characteristics into a parent
object and inherit these characteristics in the child objects. For example, you can define an employee
object that defines all the general characteristics of employees in your company. You can then define a
manager object that inherits the characteristics of the employee object but also adds characteristics
unique to managers in your company. The manager object will automatically reflect any changes in the
implementation of the employee object.
# Aggregation
Aggregation is when an object consists of a composite of other objects that work together. For example,
your lawn mower object is a composite of the wheel objects, the engine object, the blade object, and so
on. In fact, the engine object is a composite of many other objects. There are many examples of
aggregation in the world around us. The ability to use aggregation in OOP is a powerful feature that
enables you to accurately model and implement business processes in your programs. 
