# Object Oriented Programming Explained

## Encapsulation and Abstraction

**Encapsulation** is when an object keeps its state private. To put it more simply, an object is created with variables and those variables can't be affected from outside the class.

**Abstraction** is when "complex" code is hidden to the user. It allows the user to change variables and other aspects much easier as all they have to do for example is call a function. 

Below is an example of **Encapsulation** and **Abstraction**:
The `Person` class has private variables that can't be directly affected from outside the class.
The `getName`, `getJob` and `changeJob` methods allow the variables to be accesessed and changed.


![](https://github.com/mnichols17/421_OOPExplained/blob/master/media/e%26a.jpg)

## Inheritance

**Inheritance** is when one class (a child class) shares parameters and methods with another class (the parent class). The parent class doesn't have access to the variables/methods of the child class though.
This is so that if you have multiple classes that share properties, you don't have to repeat yourself and keep making similar classes.

Below is an example of **Inheritance**:
The `Teacher` class is seperate from the `Person` class but inherits all the variables that a `Person` object has (Name, Age and Gender).
The `Teacher` class has its own variables that can't be accesses from the `Person` class and belong soley to the `Teacher` class.



![](https://github.com/mnichols17/421_OOPExplained/blob/master/media/inheritance.jpg)

## Polymorphism

**Polymorhpism** is Greek for "many shapes". 
Polymorphism allows classes to share methods but the behavior of the method is determined by the type or ammount of parameters the class/method recieves. 
It has a relationship with inheritance as it can making inheritance much easier for similar but different objects.

Below is an example of **Polymorphism**:
The `Shape` class has 2 Perimeter methods but each one takes a different number of parameters. Depending on how many parameters are sent to the Perimeter method, determines what method will be used.



![](https://github.com/mnichols17/421_OOPExplained/blob/master/media/poly.jpg)

### Travis Passing


![](https://github.com/mnichols17/421_OOPExplained/blob/master/media/travisPassing.jpg)
