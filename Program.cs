using DecoratorDesgAssignment.ConcreteComponent;
using DecoratorDesgAssignment.Decorator;
using DecoratorDesgAssignment.Interface;

IComponent<string> component = new ConcreteComponent();

// initializing different decorators
var plainDecorator = new PlainDecorator(component);
var upperCaseDecorator = new UpperCaseDecorator(component);
var colorDecorator = new ColorDecorator(component);

// calling GetText() from each object defined above and printing the result in console window.
Console.WriteLine("Original: " + component.GetText());
Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());
Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());
Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());