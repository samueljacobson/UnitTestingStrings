using NUnit.Framework;
using System;

namespace StringsHomework
{
    [TestFixture]
    public class StringsHomework
    {
        private object __FILL_ME_IN__ = null;

        [Test]
        public void Concatenation_With_Plus_Operator()
        {
            var one = "Hello";
            var two = "World";

            var allTogetherNow = one + " " + two + "!";

            Assert.That(allTogetherNow, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void Interpolation_With_StringFormat()
        {
            var one = "Hello";
            var two = "World";

            // string.Format lets you do string interpolation, just like Console.Writeline, 
            // but it returns a string rather than printing one out to the console.
            var allTogetherNow = string.Format("{0} {1}!", one, two);

            Assert.That(allTogetherNow, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void Equality_With_DoubleEquals_Operator()
        {
            var one = "hello";
            var two = "hello";

            var result = one == two;

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Equality_With_DoubleEquals_Is_CaseSensitive()
        {
            var one = "hello";
            var two = "HELLO";

            var result = one == two;

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Equality_With_Equals_Method()
        {
            var one = "hello";
            var two = "hello";

            // You can also check equality using a method on a string
            // instance.  It works exactly the same.
            var result = one.Equals(two);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Equality_With_Equals_Method_And_Arguments()
        {
            var one = "hello";
            var two = "HELLO";

            // Why use the Equals method?
            // Using the Equals method, you can use different overloads to get
            // slightly different behavior (like ignoring case!).
            var comparisonType = StringComparison.CurrentCultureIgnoreCase;
            var result = one.Equals(two.ToLower());

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Changing_String_Case()
        {
            var mixedCase = "Los Angeles";

            var lowerCase = mixedCase.ToLower();
            var upperCase = mixedCase.ToUpper();

            Assert.That(mixedCase, Is.EqualTo("Los Angeles"));
            Assert.That(lowerCase, Is.EqualTo("los angeles"));
            Assert.That(upperCase, Is.EqualTo("LOS ANGELES"));
        }

        [Test]
        public void Length_Of_Strings()
        {
            var myString = "Los Angeles";

            var length = myString.Length;

            Assert.That(length, Is.EqualTo(11));
        }

        [Test]
        public void Escape_Characters_With_Strings()
        {
            var myString = "\"hi\"";

            Assert.That(myString.ToLower(), Is.EqualTo("\"hi\""));
            Assert.That(myString[0], Is.EqualTo('"'));
            Assert.That(myString[1], Is.EqualTo('h'));
            Assert.That(myString[2], Is.EqualTo('i'));
            Assert.That(myString[3], Is.EqualTo('"'));
        }

        [Test]
        public void Trim_Removes_Whitespace_From_Beginning_And_End()
        {
            var myString = "           hello    ";

            var result = myString.Trim();

            Assert.That(myString.Trim(), Is.EqualTo("hello"));
        }

        [Test]
        public void IndexOf_Returns_IndexOf_The_First_Character()
        {
            var myString = "abcd";

            Assert.That(myString.IndexOf('b'), Is.EqualTo(1));
            Assert.That(myString.IndexOf("cd"), Is.EqualTo(2));
        }

        [Test]
        public void Contains_Returns_A_Boolean()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            Assert.That(alphabet.Contains("6"), Is.EqualTo(false));
            Assert.That(alphabet.Contains("f"), Is.EqualTo(true));
            Assert.That(alphabet.Contains("F"), Is.EqualTo(false));
        }

        [Test]
        public void StartsWith_Returns_Whether_A_String_StartsWith_Another_String()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            Assert.That(alphabet.StartsWith("abc"), Is.EqualTo(true));
            Assert.That(alphabet.StartsWith("ABC"), Is.EqualTo(false));
            Assert.That(alphabet.StartsWith("def"), Is.EqualTo(false));
        }

        [Test]
        public void EndsWith_Returns_Whether_A_String_EndsWith_Another_String()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            Assert.That(alphabet.EndsWith("abc"), Is.EqualTo(false));
            Assert.That(alphabet.EndsWith("def"), Is.EqualTo(false));
            Assert.That(alphabet.EndsWith("DEF"), Is.EqualTo(false));
        }

        [Test]
        public void Substring_Lets_You_Take_A_Slice_From_A_String()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            var startIndex = 2;
            var length = 4;
            var result = alphabet.Substring(startIndex, length);

            Assert.That(result, Is.EqualTo("cdef"));
        }
    }
}

