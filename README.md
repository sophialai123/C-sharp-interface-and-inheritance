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
