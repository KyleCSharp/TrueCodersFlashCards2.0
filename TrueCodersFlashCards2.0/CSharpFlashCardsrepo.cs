using TrueCodersFlashCards_NO_DB_.Models;

namespace TrueCodersFlashCards_NO_DB_
{
    public class CSharpFlashCardsrepo : ICSharpFlashCardsrepo
    {

        public IEnumerable<FlashCard> GetCFlashCards()
        {
            #region
            FlashCard flashcard = new FlashCard();
            flashcard.Front = "abstract method";
            flashcard.Back = "A method that includes no implementation details (no method body) in the declaration. Abstract method declarations are permitted only in abstract classes.";
            FlashCard flashcard1 = new FlashCard();
            flashcard1.Front = " What is an Array";
            flashcard1.Back = "A data structure that allows multitude values to be stored under a single identifier.";
            FlashCard flashcard2 = new FlashCard();
            flashcard2.Front = "ASP.NET";
            flashcard2.Back = "The Microsoft programming frame work that enables the creation of applications that run on a Web server and deliver functionality through a browser, such as Internet Explorer";
            FlashCard flashcard3 = new FlashCard();
            flashcard3.Front = "camelCase";
            flashcard3.Back = "A naming convention used for variable and object identifiers in C#. The first letter of the identifier is lowercase and the first letter of each subsequent concatenated word is capitalized (i.e., amountDue). Also called Hungarian notation.";
            FlashCard flashCard4 = new FlashCard();
            flashCard4.Front = "What is C#?";
            flashCard4.Back = "Answer: C# (pronounced C sharp) is a modern, object-oriented programming language designed by Microsoft to build a wide range of applications that run on the .NET Framework.";
            FlashCard flashCard5 = new FlashCard();
            flashCard5.Front = "What is .NET Framework?";
            flashCard5.Back = "Answer: The .NET Framework is a software framework developed by Microsoft that includes a large library of pre-built code and tools for developing and running applications on Windows.";
            FlashCard flashCard6 = new FlashCard();
            flashCard6.Front = "What are the data types in C#?";
            flashCard6.Back = "Answer: C# supports various data types such as integer, float, double, char, string, boolean, etc.";
            FlashCard flashCard7 = new FlashCard();
            flashCard7.Front = "What is the difference between value types and reference types in C#?";
            flashCard7.Back = "Answer: Value types store data directly on the stack, whereas reference types store a reference to the data on the heap.";
            FlashCard flashCard8 = new FlashCard();
            flashCard8.Front = "What is a namespace in C#?";
            flashCard8.Back = "Answer: A namespace is a way of organizing code by grouping related classes and other types into a single logical unit.";
            FlashCard flashCard9 = new FlashCard();
            flashCard9.Front = "What is a class in C#?";
            flashCard9.Back = "Answer: A class is a blueprint or template for creating objects that define a set of related methods, properties, and events.";
            FlashCard flashCard10 = new FlashCard();
            flashCard10.Front = "What is an object in C#?";
            flashCard10.Back = "Answer: An object is an instance of a class that has its own set of values for the class's properties and fields.";
            FlashCard flashCard11 = new FlashCard();
            flashCard11.Front = "What is inheritance in C#?";
            flashCard11.Back = "Answer: Inheritance is a mechanism in C# where one class can inherit the properties and methods of another class.";
            FlashCard flashCard12 = new FlashCard();
            flashCard12.Front = "What is polymorphism in C#?";
            flashCard12.Back = "Answer: Polymorphism is a feature of object-oriented programming that allows objects of different classes to be treated as if they were objects of the same class.";
            FlashCard flashCard13 = new FlashCard();
            flashCard13.Front = "What is an interface in C#?";
            flashCard13.Back = "Answer: An interface is a blueprint for a set of methods, properties, and events that a class can implement to provide specific behavior.";
            FlashCard flashCard14 = new FlashCard();
            flashCard14.Front = "What is a constructor in C#?";
            flashCard14.Back = "Answer: A constructor is a special method in a class that is used to create and initialize objects of that class.";
            FlashCard flashCard15 = new FlashCard();
            flashCard15.Front = "What is a destructor in C#?";
            flashCard15.Back = "Answer: A destructor is a special method in a class that is used to clean up resources used by objects of that class before they are destroyed.";
            FlashCard flashCard16 = new FlashCard();
            flashCard16.Front = "What is an exception in C#?";
            flashCard16.Back = "Answer: An exception is an error condition that occurs during program execution and disrupts the normal flow of control.";
            FlashCard flashCard17 = new FlashCard();
            flashCard17.Front = "What is a try-catch block in C#?";
            flashCard17.Back = "Answer: A try-catch block is a language construct in C# that is used to handle exceptions by enclosing the code that may throw an exception in a try block and catching any thrown exceptions in a catch block.";
            FlashCard flashCard18 = new FlashCard();
            flashCard18.Front = "What is a delegate in C#?";
            flashCard18.Back = "Answer: A delegate is a type that represents a method signature, allowing methods to be passed as parameters or assigned to variables.";
            FlashCard flashCard19 = new FlashCard();
            flashCard19.Front = "What is a lambda expression in C#?";
            flashCard19.Back = "Answer: A lambda expression is a shorthand syntax for defining anonymous functions in C#.";
            FlashCard flashCard20 = new FlashCard();
            flashCard20.Front = "What is LINQ in C#?";
            flashCard20.Back = "Answer: LINQ (Language Integrated Query) is a set of language features in C# that provides a consistent way to query and manipulate data from different sources, such as databases, XML files, and collections.";
            FlashCard flashCard21 = new FlashCard();
            flashCard21.Front = "What is a generic in C#?";
            flashCard21.Back = "Answer: A generic is a type or method that is parameterized with one or more type parameters, allowing it to work with a wide range of data types.";
            FlashCard flashCard22 = new FlashCard();
            flashCard22.Front = "What is a collection in C#?";
            flashCard22.Back = "Answer: A collection is a data structure that holds a group of elements, typically of the same type.";
            FlashCard flashCard23 = new FlashCard();
            flashCard23.Front = "What is a list in C#?";
            flashCard23.Back = "Answer: A list is a type of collection in C# that stores a sequence of elements and allows them to be accessed by index.";
            FlashCard flashCard24 = new FlashCard();
            flashCard24.Front = "What is a dictionary in C#?";
            flashCard24.Back = "Answer: A dictionary is a type of collection in C# that stores a set of key-value pairs, where each key is associated with a unique value.";
            FlashCard flashCard25 = new FlashCard();
            flashCard25.Front = "What is a foreach loop in C#?";
            flashCard25.Back = "Answer: A foreach loop is a language construct in C# that is used to iterate over the elements in a collection.";
            FlashCard flashcard26 = new FlashCard();
            flashcard26.Front = "What is a List<T>";
            flashcard26.Back = "The List<T> is a collection of strongly typed objects that can be accessed by index and having methods for sorting, searching, and modifying list. It is the generic version of the ArrayList that comes under System.Collections.Generic namespace.";
            #endregion
            var flashCards = new List<FlashCard> { flashcard, flashcard1, flashcard2, flashcard3, flashCard4, flashCard5, flashCard6, flashCard7, flashCard8, flashCard9, flashCard10, flashCard11, flashCard12, flashCard13, flashCard14, flashCard15, flashCard16, flashCard17, flashCard18, flashCard19, flashCard20, flashCard21, flashCard22, flashCard23, flashCard24, flashCard25, flashcard26 };
            return flashCards;
            //flashcards in region
        }

        public IEnumerable<FlashCard> GetCSSFlashCards()
        {
            #region
            FlashCard flashcard1 = new FlashCard();
            flashcard1.Front = "What is CSS?";
            flashcard1.Back = "Answer: CSS (Cascading Style Sheets) is a style sheet language used for describing the presentation of a document written in HTML or XML.";
            FlashCard flashcard2 = new FlashCard();
            flashcard2.Front = "What are the three ways to include CSS in an HTML file?";
            flashcard2.Back = "Answer: Inline, Internal, and External";
            FlashCard flashcard3 = new FlashCard();
            flashcard3.Front = "What is the syntax for selecting an element by its class in CSS?";
            flashcard3.Back = "Answer: .classname { ... }";
            FlashCard flashCard4 = new FlashCard();
            flashCard4.Front = "What is the syntax for selecting an element by its ID in CSS?";
            flashCard4.Back = "Answer: #idname { ... }";
            FlashCard flashcard5 = new FlashCard();
            flashcard5.Front = "What is the box model in CSS?";
            flashcard5.Back = "Answer: The box model refers to the layout design concept used to represent the different components of an HTML element, including content, padding, border, and margin.";
            FlashCard flashcard6 = new FlashCard();
            flashcard6.Front = "What is the difference between padding and margin in CSS?";
            flashcard6.Back = "Answer: Padding is the space between an element's content and its border, while margin is the space between an element's border and surrounding elements.";
            FlashCard flashcard7 = new FlashCard();
            flashcard7.Front = "What is the difference between absolute and relative positioning in CSS?";
            flashcard7.Back = "Answer: Absolute positioning positions an element relative to its parent element, while relative positioning positions an element relative to its normal position on the page.";
            FlashCard flashcard8 = new FlashCard();
            flashcard8.Front = "What is the display property in CSS?";
            flashcard8.Back = "Answer: The display property determines how an element should be displayed on the page, such as block, inline, or none.";
            FlashCard flashcard9 = new FlashCard();
            flashcard9.Front = "What is the difference between the float and clear properties in CSS?";
            flashcard9.Back = "Answer: The float property positions an element to the left or right of its container, while the clear property prevents elements from floating next to it.";
            FlashCard flashcard10 = new FlashCard();
            flashcard10.Front = "What is the CSS box-sizing property?";
            flashcard10.Back = "Answer: The box-sizing property defines how the total width and height of an element is calculated, including padding and border, and can be set to content-box or border-box.";
            FlashCard flashcard11 = new FlashCard();
            flashcard11.Front = "What is the difference between margin and padding in CSS?";
            flashcard11.Back = "Answer: Margin is the space outside an element, while padding is the space inside an element.";
            FlashCard flashcard12 = new FlashCard();
            flashcard12.Front = "What is the box model in CSS?";
            flashcard12.Back = "Answer: The box model is a concept in CSS that describes the layout of elements on a web page as a series of boxes.";
            FlashCard flashcard13 = new FlashCard();
            flashcard13.Front = "What is the difference between inline and block elements in CSS?";
            flashcard13.Back = "Answer: Inline elements are displayed in a line with other elements, while block elements are displayed on a new line.";
            FlashCard flashcard14 = new FlashCard();
            flashcard14.Front = "What is the display property used for in CSS?";
            flashcard14.Back = "Answer: The display property is used to set how an element should be displayed on a web page.";
            FlashCard flashcard15 = new FlashCard();
            flashcard15.Front = "What is the position property used for in CSS?";
            flashcard15.Back = "Answer: The position property is used to set the position of an element on a web page.";
            FlashCard flashcard16 = new FlashCard();
            flashcard16.Front = "What is the difference between relative and absolute positioning in CSS?";
            flashcard16.Back = "Answer: Relative positioning is based on the element's position relative to its normal position, while absolute positioning is based on the element's position relative to the nearest positioned ancestor.";
            FlashCard flashcard17 = new FlashCard();
            flashcard17.Front = "What is the z-index property used for in CSS?";
            flashcard17.Back = "Answer: The z-index property is used to set the stacking order of elements on a web page.";
            FlashCard flashcard18 = new FlashCard();
            flashcard18.Front = "What is the float property used for in CSS?";
            flashcard18.Back = "Answer: The float property is used to set an element's position to the left or right of its container.";
            FlashCard flashcard19 = new FlashCard();
            flashcard19.Front = "What is the clear property used for in CSS?";
            flashcard19.Back = "Answer: The clear property is used to specify whether an element should be moved below floating elements that come before it.";
            FlashCard flashcard20 = new FlashCard();
            flashcard20.Front = "What is the font-size property used for in CSS?";
            flashcard20.Back = "Answer: The font-size property is used to specify the size of the font of an element.";

            #endregion

            var flashCards = new List<FlashCard> { flashcard1, flashcard2, flashcard3, flashCard4, flashcard5, flashcard6, flashcard7, flashcard8, flashcard9, flashcard10, flashcard11, flashcard12, flashcard13, flashcard14, flashcard15, flashcard16, flashcard17, flashcard18, flashcard19, flashcard20 };
            return flashCards;

        }

        public IEnumerable<FlashCard> GetHTMLFlashCards()
        {
            #region
            FlashCard flashcard = new FlashCard();
            flashcard.Front = "What is HTML?";
            flashcard.Back = "Answer: HTML (Hypertext Markup Language) is a standard markup language used for creating web pages and web applications.";
            FlashCard flashcard1 = new FlashCard();
            flashcard1.Front = "What are the basic elements of an HTML document?";
            flashcard1.Back = "Answer: HTML document includes head and body sections. Head contains the title and other meta-information about the document, while the body contains the content of the page.";
            FlashCard flashcard2 = new FlashCard();
            flashcard2.Front = "What is the syntax for creating a hyperlink in HTML?";
            flashcard2.Back = "Answer: <a href= url that you want >link text</a>";
            FlashCard flashCard3 = new FlashCard();
            flashCard3.Front = "What are the heading tags in HTML?";
            flashCard3.Back = "Answer: HTML heading tags are h1, h2, h3, h4, h5, and h6, which represent different levels of headings in a document.";
            FlashCard flashcard4 = new FlashCard();
            flashcard4.Front = "What is the difference between a block-level element and an inline element in HTML?";
            flashcard4.Back = "Answer: Block-level elements take up the entire width of their parent element and create a new line, while inline elements only take up the width of their content and do not create a new line.";
            FlashCard flashcard5 = new FlashCard();
            flashcard5.Front = "What is the difference between the <div> and <span> elements in HTML?";
            flashcard5.Back = "Answer: The <div> element is a block-level element used to group other elements together, while the <span> element is an inline element used to apply styles to a small piece of content.";
            FlashCard flashcard6 = new FlashCard();
            flashcard6.Front = "What is the <img> tag used for in HTML?";
            flashcard6.Back = "Answer: The <img> tag is used to insert an image into an HTML document.";
            FlashCard flashCard7 = new FlashCard();
            flashCard7.Front = "What is the difference between the <ol> and <ul> tags in HTML?";
            flashCard7.Back = "Answer: The <ol> tag is used to create an ordered list, while the <ul> tag is used to create an unordered list.";
            FlashCard flashcard8 = new FlashCard();
            flashcard8.Front = "What is the <table> tag used for in HTML?";
            flashcard8.Back = "Answer: The <table> tag is used to create a table in an HTML document.";
            FlashCard flashcard9 = new FlashCard();
            flashcard9.Front = "What is the difference between the <header> and <footer> tags in HTML?";
            flashcard9.Back = "Answer: The <header> tag is used to define a header section for a document or section, while the <footer> tag is used to define a footer section.";
            FlashCard flashcard10 = new FlashCard();
            flashcard10.Front = "What is the difference between the <b> and <strong> tags in HTML?";
            flashcard10.Back = "Answer: The <b> tag is used to make text bold, while the <strong> tag is used to indicate that the text is important.";
            FlashCard flashcard11 = new FlashCard();
            flashcard11.Front = "What is the difference between the <i> and <em> tags in HTML?";
            flashcard11.Back = "Answer: The <i> tag is used to make text italic, while the <em> tag is used to indicate emphasis.";
            FlashCard flashcard12 = new FlashCard();
            flashcard12.Front = "What is the <form> tag used for in HTML?";
            flashcard12.Back = "Answer: The <form> tag is used to create a form for user input.";
            FlashCard flashcard13 = new FlashCard();
            flashcard13.Front = "What is the <input> tag used for in HTML";
            flashcard13.Back = "Answer: The <input> tag is used to create form controls such as text boxes, radio buttons, and checkboxes.";
            FlashCard flashcard14 = new FlashCard();
            flashcard14.Front = "What is the <textarea> tag used for in HTML?";
            flashcard14.Back = "Answer: The <textarea> tag is used to create a multi-line text input field.";
            FlashCard flashcard15 = new FlashCard();
            flashcard15.Front = "What is the <select> tag used for in HTML?";
            flashcard15.Back = "Answer: The <option> tag is used to define an option in a drop-down list created by the <select> tag.";
            FlashCard flashcard16 = new FlashCard();
            flashcard16.Front = "What is the <label> tag used for in HTML?";
            flashcard16.Back = "Answer: The <label> tag is used to associate a label with a form control.";
            FlashCard flashcard17 = new FlashCard();
            flashcard17.Front = "What is the difference between the <id> and <class> attributes in HTML?";
            flashcard17.Back = "Answer: The <id> attribute is used to uniquely identify an element, while the <class> attribute is used to specify one or more classes for an element.";
            FlashCard flashcard18 = new FlashCard();
            flashcard18.Front = "What is the difference between the <div> and <section> tags in HTML?";
            flashcard18.Back = "Answer: The <div> tag is a generic container for content, while the <section> tag is used to group related content.";
            FlashCard flashcard19 = new FlashCard();
            flashcard19.Front = "What is the <option> tag used for in HTML?";
            flashcard19.Back = "Answer: The <option> tag is used to define an option in a drop-down list created by the <select> tag.";
            #endregion


            var flashCards = new List<FlashCard> { flashcard, flashcard1, flashcard2, flashCard3, flashcard4, flashcard5, flashcard6, flashCard7, flashcard8, flashcard9, flashcard10, flashcard11, flashcard12, flashcard13, flashcard14, flashcard15, flashcard16, flashcard17, flashcard18, flashcard19 };
            return flashCards;
        }

        public IEnumerable<FlashCard> GetSQLFlashCards()
        {
            #region
            FlashCard flashcard = new FlashCard();
            flashcard.Front = "What is SQL?";
            flashcard.Back = "Answer: SQL (Structured Query Language) is a programming language used for managing relational databases and performing operations on the data stored in them.";
            FlashCard flashcard1 = new FlashCard();
            flashcard1.Front = "What is a database?";
            flashcard1.Back = "Answer: A database is an organized collection of structured data stored in a computer system.";
            FlashCard flashcard2 = new FlashCard();
            flashcard2.Front = "What is a table in SQL?";
            flashcard2.Back = "Answer: A table is a collection of data organized in rows and columns.";
            FlashCard flashCard3 = new FlashCard();
            flashCard3.Front = "What is a primary key in SQL?";
            flashCard3.Back = "Answer: A primary key is a unique identifier for a record in a table.";
            FlashCard flashcard4 = new FlashCard();
            flashcard4.Front = "What is a foreign key in SQL?";
            flashcard4.Back = "Answer: A foreign key is a field in a table that refers to the primary key of another table.";
            FlashCard flashCard5 = new FlashCard();
            flashCard5.Front = "What is the SELECT statement used for in SQL?";
            flashCard5.Back = "Answer: The SELECT statement is used to retrieve data from a database.";
            FlashCard flashcard6 = new FlashCard();
            flashcard6.Front = "What is the WHERE clause used for in SQL?";
            flashcard6.Back = "Answer: The WHERE clause is used to filter data based on a specified condition.";
            FlashCard flashcard7 = new FlashCard();
            flashcard7.Front = "What is the ORDER BY clause used for in SQL?";
            flashcard7.Back = "Answer: The ORDER BY clause is used to sort the data retrieved by a SELECT statement.";
            FlashCard flashcard8 = new FlashCard();
            flashcard8.Front = "What is the JOIN statement used for in SQL?";
            flashcard8.Back = "Answer: The JOIN statement is used to combine data from two or more tables based on a related column.";
            FlashCard flashcard9 = new FlashCard();
            flashcard9.Front = "What is the difference between a LEFT JOIN and a RIGHT JOIN in SQL?";
            flashcard9.Back = "Answer: A LEFT JOIN returns all records from the left table and the matched records from the right table, while a RIGHT JOIN returns all records from the right table and the matched records from the left table.";
            FlashCard flashcard10 = new FlashCard();
            flashcard10.Front = "What is the GROUP BY clause used for in SQL?";
            flashcard10.Back = "Answer: The GROUP BY clause is used to group the result set by one or more columns.";
            FlashCard flashcard11 = new FlashCard();
            flashcard11.Front = "What is the HAVING clause used for in SQL?";
            flashcard11.Back = "Answer: The HAVING clause is used to filter groups based on a specified condition";
            FlashCard flashcard12 = new FlashCard();
            flashcard12.Front = "What is the MAX function used for in SQL?";
            flashcard12.Back = "Answer: The MAX function is used to return the maximum value in a specified column.";
            FlashCard flashcard13 = new FlashCard();
            flashcard13.Front = "What is the MIN function used for in SQL?";
            flashcard13.Back = "Answer: The MIN function is used to return the minimum value in a specified column.";
            FlashCard flashcard14 = new FlashCard();
            flashcard14.Front = "What is the AVG function used for in SQL?";
            flashcard14.Back = "Answer: The AVG function is used to return the average value of a specified column.";
            FlashCard flashcard15 = new FlashCard();
            flashcard15.Front = "What is the SUM function used for in SQL?";
            flashcard15.Back = "Answer: The SUM function is used to return the sum of a specified column.";
            FlashCard flashcard16 = new FlashCard();
            flashcard16.Front = "What is the INSERT statement used for in SQL?";
            flashcard16.Back = "Answer: The INSERT statement is used to insert data into a table.";
            FlashCard flashcard17 = new FlashCard();
            flashcard17.Front = "What is the UPDATE statement used for in SQL?";
            flashcard17.Back = "Answer: The UPDATE statement is used to update data in a table.";
            FlashCard flashcard18 = new FlashCard();
            flashcard18.Front = "What is the DELETE statement used for in SQL?";
            flashcard18.Back = "Answer: The DELETE statement is used to delete data from a table";
            FlashCard flashCard19 = new FlashCard();
            flashCard19.Front = "What is CRUD";
            flashCard19.Back = "CREATE, READ, UPDATE, DELETE";
            FlashCard flashcard20 = new FlashCard();
            flashcard20.Front = "What is a view in SQL?";
            flashcard20.Back = "Answer: A view is a virtual table that is based on the result set of a SELECT statement.";


            #endregion

            var flashCards = new List<FlashCard> { flashcard, flashcard1, flashcard2, flashCard3, flashcard4, flashCard5, flashcard6, flashcard7, flashcard8, flashcard9, flashcard10, flashcard11, flashcard12, flashcard13, flashcard14, flashcard15, flashcard16, flashcard17, flashcard18, flashCard19, flashcard20 };
            return flashCards;
        }
        public IEnumerable<FlashCard> GetJavaScriptFlashCards()
        {
            #region
            FlashCard flashcard1 = new FlashCard();
            flashcard1.Front = "What is JavaScript?";
            flashcard1.Back = "Answer: JavaScript is a high-level programming language used to create interactive web applications and dynamic user interfaces.";

            FlashCard flashcard2 = new FlashCard();
            flashcard2.Front = "What are the data types in JavaScript?";
            flashcard2.Back = "Answer: JavaScript has six primitive data types: string, number, boolean, null, undefined, and symbol. It also has an object data type.";

            FlashCard flashcard3 = new FlashCard();
            flashcard3.Front = "What is the difference between null and undefined in JavaScript?";
            flashcard3.Back = "Answer: Null represents a deliberate non-value, while undefined represents an absence of a value.";

            FlashCard flashcard4 = new FlashCard();
            flashcard4.Front = "What is a variable in JavaScript?";
            flashcard4.Back = "Answer: A variable is a container for storing data values, such as numbers, strings, or objects.";

            FlashCard flashcard5 = new FlashCard();
            flashcard5.Front = "What is the difference between let and var in JavaScript?";
            flashcard5.Back = "Answer: Both let and var are used to declare variables, but let is block-scoped, while var is function-scoped.";

            FlashCard flashcard6 = new FlashCard();
            flashcard6.Front = "What is a function in JavaScript?";
            flashcard6.Back = "Answer: A function is a set of statements that perform a specific task or calculate a value. Functions can be reused throughout your code.";

            FlashCard flashcard7 = new FlashCard();
            flashcard7.Front = "What is an event in JavaScript?";
            flashcard7.Back = "Answer: An event is an action or occurrence that happens in the browser, such as a user clicking a button or the page finishing loading.";

            FlashCard flashcard8 = new FlashCard();
            flashcard8.Front = "What is an array in JavaScript?";
            flashcard8.Back = "Answer: An array is a data structure that stores a collection of elements, such as numbers or strings, in a single variable.";

            FlashCard flashcard9 = new FlashCard();
            flashcard9.Front = "What is the DOM in JavaScript?";
            flashcard9.Back = "Answer: The Document Object Model (DOM) is a programming interface for web documents. It represents the page so that programs can change the document structure, style, and content.";

            FlashCard flashcard10 = new FlashCard();
            flashcard10.Front = "What is the difference between innerHTML and textContent in JavaScript?";
            flashcard10.Back = "Answer: innerHTML retrieves or sets the HTML content within an element, while textContent retrieves or sets the text content of an element, without any HTML tags.";

            FlashCard flashcard11 = new FlashCard();
            flashcard11.Front = "What is a callback function in JavaScript?";
            flashcard11.Back = "Answer: A callback function is a function that is passed as an argument to another function, and is called when the first function has completed its task.";

            FlashCard flashcard12 = new FlashCard();
            flashcard12.Front = "What is a closure in JavaScript?";
            flashcard12.Back = "Answer: A closure is a function that has access to variables in its outer (enclosing) scope, even after the outer function has returned.";

            FlashCard flashcard13 = new FlashCard();
            flashcard13.Front = "What is the difference between synchronous and asynchronous programming in JavaScript?";
            flashcard13.Back = "Answer: Synchronous programming is when code is executed in sequence, one statement at a time. Asynchronous programming allows";
            #endregion

            var flashCards = new List<FlashCard> {flashcard1, flashcard2, flashcard3, flashcard4, flashcard5, flashcard6, flashcard7, flashcard8, flashcard9, flashcard10, flashcard11, flashcard12, flashcard13};
            return flashCards;
        }
    }
}
