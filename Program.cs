using DecoratorDesgAssignment.ConcreteComponent;
using DecoratorDesgAssignment.Decorator;
using DecoratorDesgAssignment.Interface;

IComponent<string> component = new ConcreteComponent();

// initializing different decorators
var plainDecorator = new PlainDecorator(component);
var upperCaseDecorator = new UpperCaseDecorator(component);
var colorDecorator = new ColorDecorator(component);

// calling GetText() from each object defined above and printing the result in console window.
Console.WriteLine("Introduction Message: " + component.GetText());
Console.WriteLine("PlainMessage: " + plainDecorator.GetText());
Console.WriteLine("UpperCased Message: " + upperCaseDecorator.GetText());
Console.WriteLine("Colored Message: " + colorDecorator.GetText());