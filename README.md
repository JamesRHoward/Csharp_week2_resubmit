# _Words Repeated in Sentence_

#### _This application shows how many time a word appears in a sentence, 7/8/16_

#### By _**James R. Howard**_

## Description

_This application allows the user to see how many times a word appears in a sentence. The user has two input fields, one to input a sentence and the other to put in a single word. Once submitted they will see the result of how many times the single word input shows up in the inputted sentence._

## Behavior Driven Development/Specs

#### _User inputs sentence into input field labeled "sentence"_
* _Example Input: The dogs love to play fetch_
* _Example Output: The dogs love to play fetch_

#### _User inputs a single word into input field labeled "word to see how many times it occurs"_
* _Example Input: dogs_
* _Example Output: the word dogs occurs 1 time._

#### _User inputs sentence into input field labeled "sentence"_
* _Example Input: The cats love to play with lazer_
* _Example Output: The cats love to play fetch_

#### _User inputs a single word into input field labeled "word to see how many times it occurs"_
* _Example Input: dogs_
* _Example Output: the word dogs occurs 0 time._

#### _User inputs sentence into input field labeled "sentence"_
* _Example Input: The dogs! love to play fetch_
* _Example Output: The dogs! love to play fetch_

#### _User inputs a single word into input field labeled "word to see how many times it occurs"_
* _Example Input: dogs_
* _Example Output: the word dogs occurs 1 time._

## Setup/Installation Requirements

* _Internet_
* _Clone project from GitHub_
* _Windows OS (or bootcamp using Windows OS)_
* _Windows Powershell_
* _Mono_

_Once you have all the installation requirements, use the windows powershell to > git clone, then navigate to the project folder, then run the command > dnu restore, after that run the command >dnx kestrel, now open up a web browser(i used googlechrome to build this project) and go to http:localhost:5004._

## Known Bugs

_{Are there issues that have not yet been resolved that you want to let users know you know?  Outline any issues that would impact use of your application.  Share any workarounds that are in place. }_

## Support and contact details

_If you have any questions or concerns please contact me at jrh682@gmail.com_

## Technologies Used

_HTML, atom, Windows Powershell, Mono, Nancy version: "1.3.0", xUnit version:"2.1.0", RazorViewEngine version: "1.3.0"_

### License

*The MIT License (MIT)
Copyright (c) <2016> <James R. Howard>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*

Copyright (c) 2016 **_James R. Howard_**
