## Introduction to Interfaces

Interfaces, which are sets of actions and values that describe how a class can be used. This lets the computer check that we are using each type legally, thus preventing a whole group of type errors!

---
## Build an Interface

We will be designing a new set of transportation machines that satisfy the requirements of BOTH car designers and the highway patrol. First the highway patrol tells us: “Every automobile on the road must have these properties and methods accessible to us:”

- speed
- license plate number
- number of wheels
- ability to honk

The patrol needs this information to write speeding tickets and prevent bad behavior on the highway.

The patrol needs this information to write speeding tickets and prevent bad behavior on the highway.

In other words, the patrol makes these requirements so that it can interact with automobiles in a certain way. In C#, this group of interactions is called an `interface`. The `interface` is a set of properties, methods, and other members. They are declared with a signature but their behaviors are not defined. A class implements an `interface` if it defines those properties, methods, and other members.


or example, if the patrol requires automobiles to have a license plate, then the `IAutomobile interface` contains a LicensePlate property. A class implements this `interface` if it defines a `LicensePlate property`.

The skeleton of an interface looks a bit like a class:

```
interface IAutomobile
{
}
```

Every interface should have a name starting with `“I”`. This is a useful reminder to other developers and our future selves that this is an interface, not a class. We can add members, like properties and methods, to the interface. Here’s an example of a fake property and method:

An interface is a set of actions and values, but it doesn’t specify how they work.


```
interface IAutomobile
{
  string Id { get; }
  void Vroom();
}
```
---
## Implementing an Interface

As we design our automobile-like classes, we’ll need to implement this `IAutomobile` interface. In C#, we must first clearly announce that a class implements an interface using the colon syntax:

```
class Sedan : IAutomobile
{
}
```

This empty Sedan class “promises” to implement the `IAutomobile interface`. In other words, it must have the properties and methods the highway patrol asked for (Speed, LicensePlate, Wheels, and Honk()).If we don’t, we get a type error. Remember that these members must be `public`

```
class Sedan : IAutomobile
{
  public string LicensePlate
  { get; }
 
  // and so on...
}

```
---
## What Interfaces Cannot Do
In fact, `interfaces` cannot specify two types of members that are commonly found in classes:

- Constructors
- Fields

---
## Implementing an Interface Again

 There can be multiple classes that implement an interface.Even though `Sedan` and` Truck` are different types, we can assume that they behave similarly because they share an interface.

 ---
 ## Finish Truck Class
The car designers have asked that trucks act a bit differently from sedans. `Trucks` need a new property called `Weight`. Whenever a truck is constructed, its number of wheels will depend on its weight. For example, a heavier truck might need 12 instead of 8 wheels to support itself.

Just like sedans, trucks will also `SpeedUp()` and `SlowDown()`.

```
using System;

namespace LearnInterfaces
{
    class Truck : IAutomobile
    {
        //constructor
        public Truck(double speed, double weight)
        {
            this.Speed = speed;
            this.Weight = weight;
            LicensePlate = Tools.GenerateLicensePlate();
            if (weight < 400)
            {
                this.Wheels = 8;
            }
            else
            {
                this.Wheels = 12;
            }
        }

        //implement the interface
        public string LicensePlate { get; }

        public double Speed { get; set; }

        public int Wheels { get; }

        public double Weight { get; }

        //methods
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5; //need set() interfeace
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
    }
}

```

---
## Testing Interfaces

Now we have a `Sedan` class and `Truck` class that implement the IAutomobile interface. Though they have some different behaviors, they both have the properties and method defined in the interface:

- double Speed
- string LicensePlate
- int Wheels
- void Honk()

At this point we can be confident that we won’t cause any errors if we try to access these members in either the `Sedan` or `Truck` class.

---
## Review
- Learned that interfaces are useful to guarantee certain functionality across multiple classes
- Built an interface using the `interface` keyword
- Defined properties and methods (but not constructors or fields) in the interface
- Built classes that implemented the interface
- Added members to the classes that weren’t specified in the interface


As a last note: a class can **implement multiple interfaces**. For example, `Sedan` could implement `IAutomobile` and a new `IRecyclable` interface. It would be useful to separate interfaces if they aren’t related, i.e. not all automobiles are recyclable.

We have duplicated code, like `SpeedUp()` and `SlowDown()`, in two classes, and we know that duplicated code is hard to maintain. Is there a way to avoid duplication?

**The answer has to do with inheritance**. The concept won’t be covered in this lesson, but now you have one good reason to learn it.

---
## Introduction to Inheritance
Duplicated code leads to errors. Say you have two classes` Sedan` and `Truck`. They’re different types, but they share a few properties and methods, like `SpeedUp()` and `SlowDown()`. If one of those members (say it’s `SpeedUp()`) has to change, then we would have to change the code in every location where `SpeedUp()` is defined.

In this case it’s two classes, but in other programs it may be many more! There are two reasons we don’t want to make the same change on code across multiple files:It’s a waste of time and More importantly, it is a big risk for making mistakes.

In this lesson you’ll learn about a solution to this problem: inheritance. With inheritance, you can define one superclass that contains the shared members (like `SpeedUp()` and `SlowDown()`). All classes that need those members can inherit them from the superclass.



